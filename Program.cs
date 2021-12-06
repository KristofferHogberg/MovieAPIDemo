
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace TestApiCall
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //ApiHelper.InitClient();

            //var Test = await SunProcessor.LoadSunInformation();
            //Console.WriteLine($"Sunrise: {Test.Sunrise}");
            //Console.WriteLine($"Sunset: {Test.Sunset}");

            Run run = new Run();
            
            

            try
            {
                run.Start().GetAwaiter().GetResult();   
                //run.Start().Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());   
            }


        }

        
    }
}