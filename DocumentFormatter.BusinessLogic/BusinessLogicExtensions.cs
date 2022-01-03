using DocumentFormatter.BusinessLogic.Services;
using DocumentFormatter.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DocumentFormatter.BusinessLogic
{
    /// <summary>
    /// Business logic extensions for DI registration
    /// </summary>
    public static class BusinessLogicExtensions
    {
        /// <summary>
        ///     Adds dependencies related to business logic
        /// </summary>
        /// <param name="services">Services to be extended</param>
        /// <returns>Services</returns>
        public static IServiceCollection AddBusinessLogicServices(this IServiceCollection services)
        {
            return services.AddScoped<IFileService, FileService>();
        }
    }
}
