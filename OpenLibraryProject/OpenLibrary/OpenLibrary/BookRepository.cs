using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json.Linq;
namespace OpenLibrary
{
    public static class BookRepository
    {
        private static List<BookModel> allBooksCache;
        public static async Task<List<BookModel>> GetAllBooksAsync()
        {
            if (allBooksCache != null)
            {
                return allBooksCache;
            }
            
            var client = new HttpClient();
            var stream = await client.GetStreamAsync("http://openlibrary.org/search.json?q=animal+farm");
            var serializer = new DataContractJsonSerializer(typeof(List<BookModel>));
            allBooksCache = (List<BookModel>)serializer.ReadObject(stream);

            return allBooksCache;
        }

    }
}

