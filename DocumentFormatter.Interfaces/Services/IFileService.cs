using System.Threading.Tasks;

namespace DocumentFormatter.Interfaces.Services
{
    /// <summary>
    /// File service contract
    /// </summary>
    public interface IFileService
    {
        /// <summary>
        /// Get file content
        /// </summary>
        /// <param name="filePath">Path to the file</param>
        /// <returns>Content</returns>
        Task<string> LoadFileContentAsync(string filePath);

        /// <summary>
        /// Update number bullets from provided content
        /// </summary>
        /// <param name="content">String content</param>
        /// <param name="savePath">Save path location</param>
        Task UpdateNumberBullets(string content, string savePath);
    }
}
