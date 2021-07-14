using System.Collections.Generic;
using System.Threading.Tasks;
using CatLover.Http;
using CatLover.Models;

namespace CatLover.Services
{
    public interface ICatService
    {
        List<CatBreed> SearchAllBreeds();
    }

    public class CatService : ICatService
    {
        public List<CatBreed> SearchAllBreeds()
        {
            var callResult = Task.Run(async () => await DataClient.Create().GetAllCatBreeds()).Result;
            return callResult;
        }
    }
}