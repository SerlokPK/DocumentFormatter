using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFormatter.Common.Helpers
{
    public static class EnvironmentHelper
    {
        /// <summary>
        /// Gets mandatory variable value. If not available, exception is thrown
        /// </summary>
        /// <param name="variableKey">Environment variable key</param>
        /// <returns>Environment variable value</returns>
        public static string GetMandatoryVariableValue(string variableKey) =>
            Environment.GetEnvironmentVariable(variableKey)
            ?? throw new ArgumentNullException($"{variableKey} missing in environment variables!");
    }
}
