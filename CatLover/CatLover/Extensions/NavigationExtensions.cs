using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CatLover.Extensions
{
    public static class NavigationExtensions
    {
        private static bool isTransitioning;

        /// <summary>
        /// Asynchronously adds a Xamarin.Forms.Page to the top of the navigation stack if it is different from the last page.
        /// </summary>
        public static async Task PushAsyncSingle(this INavigation nav, Page page, bool animated = true)
        {
            if (isTransitioning) return;
            isTransitioning = true;

            if (App.Current.MainPage.Navigation.NavigationStack.Count == 0 || App.Current.MainPage.Navigation.NavigationStack.Last().GetType() != page.GetType())
            {
                await nav.PushAsync(page, animated);
                await Task.Delay(500);
            }

            isTransitioning = false;
        }
    }
}