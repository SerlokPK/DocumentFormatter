using DocumentFormatter.BusinessLogic;
using DocumentFormatter.Common.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace DocumentFormatter.Main
{
    /// <summary>
    /// Main execution class
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddBusinessLogicServices()
                .BuildServiceProvider();

            var test = ConfigurationHelper.GetMandatoryConfigurationValue("LoadLocation");

            Console.WriteLine("App started");
            Console.ReadKey();
        }
    }
}