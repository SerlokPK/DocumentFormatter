using DocumentFormatter.BusinessLogic.Configurations;
using DocumentFormatter.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace DocumentFormatter.BusinessLogic.Services
{
    /// <summary>
    /// Main service thah will call all necessary logic
    /// </summary>
    internal class MainService : IMainService
    {
        private readonly FileConfiguration _fileConfiguration;

        private readonly IFileService _fileService;

        public MainService(IFileService fileService, FileConfiguration fileConfiguration)
        {
            _fileService = fileService ?? throw new ArgumentNullException(nameof(fileService));
            _fileConfiguration = fileConfiguration ?? throw new ArgumentNullException(nameof(fileConfiguration));
        }

        /// <inheritdoc/>
        public async Task Execute()
        {
            var content = await _fileService.LoadFileContentAsync(_fileConfiguration.LoadPath);
            await _fileService.UpdateNumberBullets(content, _fileConfiguration.SavePath);
        }
    }
}
