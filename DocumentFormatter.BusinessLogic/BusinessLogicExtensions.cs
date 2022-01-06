using DocumentFormatter.BusinessLogic.Configurations;
using DocumentFormatter.BusinessLogic.Services;
using DocumentFormatter.Common.Helpers;
using DocumentFormatter.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DocumentFormatter.BusinessLogic
{
    /// <summary>
    /// Business logic extensions for DI registration
    /// </summary>
    public static class BusinessLogicExtensions
    {
        private const string LoadPath = "LoadPath";
        private const string SavePath = "SavePath";

        /// <summary>
        ///     Adds dependencies related to business logic
        /// </summary>
        /// <param name="services">Services to be extended</param>
        /// <returns>Services</returns>
        public static IServiceCollection AddBusinessLogicServices(this IServiceCollection services)
        {
            var loadPath = ConfigurationHelper.GetMandatoryConfigurationValue(LoadPath);
            var savePath = ConfigurationHelper.GetMandatoryConfigurationValue(SavePath);

            FileConfiguration fileConfiguration = new()
            {
                LoadPath = loadPath,
                SavePath = savePath,
            };

            return services
                .AddScoped<IFileService, FileService>()
                .AddScoped<IMainService>(provider =>
                {
                    return ActivatorUtilities.CreateInstance<MainService>(provider, fileConfiguration);
                });
        }
    }
}
