using System;
using System.Collections.Generic;
using System.Text;

namespace CatLover.Pages
{
    public class ViewId
    {
        /// <summary>
        /// Title of pages.
        /// </summary>
        public static Dictionary<Type, string> Title = new Dictionary<Type, string>()
        {
            {typeof(MainPage), "Cat Breeds"},
            {typeof(BreedDetailPage), "Breed Detail"},
        };
    }
}