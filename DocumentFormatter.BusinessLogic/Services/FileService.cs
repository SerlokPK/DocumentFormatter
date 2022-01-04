using DocumentFormatter.Interfaces.Services;
using System.IO;
using System.Threading.Tasks;

namespace DocumentFormatter.BusinessLogic.Services
{
    /// <summary>
    /// Service for file operations
    /// </summary>
    internal class FileService : IFileService
    {
        /// <inheritdoc/>
        public async Task<string> LoadFileContentAsync(string filePath)
        {
            return await File.ReadAllTextAsync(filePath);
        }
    }
}
