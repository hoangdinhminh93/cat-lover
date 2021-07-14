using CatLover.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatLover.Http
{
    public partial class DataClient
    {
        /// <summary>
        /// Get all cat breeds.
        /// </summary>
        public async Task<List<CatBreed>> GetAllCatBreeds()
        {
            return await GetAsync<List<CatBreed>>("breeds");
        }
    }
}