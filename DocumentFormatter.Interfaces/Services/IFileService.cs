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
    }
}
