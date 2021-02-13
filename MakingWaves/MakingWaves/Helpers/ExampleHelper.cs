using MakingWaves.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MakingWaves.Helpers
{
    public static class ExampleHelper
    {
        public static async Task<ExampleModel> FetchExample(int perPage, int page)
        {

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"https://reqres.in/api/example?per_page={perPage}&page={page}");
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ExampleModel>(content);
            }
        }
    }
}
