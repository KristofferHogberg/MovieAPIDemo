using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApiCall
{
    public class Run
    {
        private static ApiHelper apiHelper = new ApiHelper();

        public async Task Start()
        {
            apiHelper.InitClient();

            Console.Write("Enter a movie or a band: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Fetching result...");
            var result = await TestDiveProcessor.LoadTestDiveInformation(input);

            if (result != null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Check these out!\n");
                Console.ResetColor();
                foreach (var r in result.Similar.Results)
                {
                    Console.WriteLine(r.Name + " " + r.Type);
                }
            }
            else
            {
                Console.WriteLine("There was a problem with your request");
            }

            //var Test = await SunProcessor.LoadSunInformation();
            //Console.WriteLine($"Sunrise: {Test.Sunrise}");
            //Console.WriteLine($"Sunset: {Test.Sunset}");
        }
    }
}