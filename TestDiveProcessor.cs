using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestApiCall
{
    public class TestDiveProcessor
    {
        public static async Task<Rootobject> LoadTestDiveInformation(string query)
        {
            //string url = "https://tastedive.com/api/similar?q=the+machinist";

            string url = "https://tastedive.com/api/similar?q=" + query;

            HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                Rootobject result = await response.Content.ReadAsAsync<Rootobject>();
                return result;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}