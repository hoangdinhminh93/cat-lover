using CatLover.Models;
using CatLover.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace CatLover.Http
{
    public partial class DataClient
    {
#if DEBUG
        DateTime startTime;
#endif
        private static readonly HttpClient _httpClient;
        private const int ConnectionTimeout = 10;

        static DataClient()
        {
            _httpClient = new HttpClient();
        }

        public static DataClient Create()
        {
            return new DataClient();
        }

        private async Task<T> GetAsync<T>(string method)
        {
            var url = Const.URI + method;
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                // Todo
                return default(T);
            }

#if DEBUG
            startTime = DateTime.Now;
            System.Diagnostics.Debug.WriteLine("▼ " + "[" + startTime.ToString("HH:mm:ss.fff") + "] " + url + "\nGET Request: ");
#endif

            HttpResponseMessage response = null;
            _httpClient.DefaultRequestHeaders.Add("x-api-key", Const.APIKey);

            for (int i = 0; i < 3; i++)
            {
                var tokensource = new CancellationTokenSource();
                try
                {
                    tokensource.CancelAfter(ConnectionTimeout * 1000);
                    response = await _httpClient.GetAsync(url, tokensource.Token).ConfigureAwait(false);
                }
                catch (TaskCanceledException)
                {
                    response = null;
                    break;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.ToString());
                    await Task.Delay(500);
                    response = null;
                    continue;
                }
            }

            // Handle error
            if (response == null || response.StatusCode == HttpStatusCode.Forbidden || response.StatusCode == HttpStatusCode.Unauthorized)
            {
                // Todo
                return default(T);
            }

            // Read content
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(content);

#if DEBUG
            System.Diagnostics.Debug.WriteLine("▲ " + "[" + (DateTime.Now - startTime).Milliseconds + "ms]" + url + "\nResponse:\n");
#endif

            return result;
        }
    }
}