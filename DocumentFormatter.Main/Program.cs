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
            .BuildServiceProvider();
        }
    }
}