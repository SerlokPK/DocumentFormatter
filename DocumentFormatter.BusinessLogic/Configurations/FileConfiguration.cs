namespace DocumentFormatter.BusinessLogic.Configurations
{
    /// <summary>
    /// File configuration
    /// </summary>
    internal class FileConfiguration
    {
        /// <summary>
        /// From which location should file be loaded
        /// </summary>
        public string LoadPath { get; set; }

        /// <summary>
        /// To which location should file be saved
        /// </summary>
        public string SavePath { get; set; }
    }
}
