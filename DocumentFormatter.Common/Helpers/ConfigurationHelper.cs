using System;
using System.Configuration;

namespace DocumentFormatter.Common.Helpers
{
    public static class ConfigurationHelper
    {
        /// <summary>
        /// Gets mandatory config value. If not available, exception is thrown
        /// </summary>
        /// <param name="configKey">App config key</param>
        /// <returns>App config value</returns>
        public static string GetMandatoryConfigurationValue(string configKey) =>
            ConfigurationManager.AppSettings[configKey]
            ?? throw new ArgumentNullException($"{configKey} missing in config file!");
    }
}
