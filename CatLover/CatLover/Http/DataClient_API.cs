using CatLover.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatLover.Http
{
    public partial class DataClient
    {
        public async Task<List<CatBreed>> GetAllBreads()
        {
            return await GetAsync<List<CatBreed>>("breeds");
        }
    }
}