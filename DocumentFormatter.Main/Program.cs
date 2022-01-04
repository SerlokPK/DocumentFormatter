using DocumentFormatter.BusinessLogic;
using DocumentFormatter.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DocumentFormatter.Main
{
    /// <summary>
    /// Main execution class
    /// </summary>
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddBusinessLogicServices()
                .BuildServiceProvider();

            Console.WriteLine("App started");

            var mainService = serviceProvider.GetService<IMainService>();
            if (mainService is null)
            {
                throw new ArgumentNullException(nameof(mainService));
            }

            await mainService.Execute();

            Console.ReadKey();
        }
    }
}