using DocumentFormatter.Interfaces.Services;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DocumentFormatter.BusinessLogic.Services
{
    /// <summary>
    /// Service for file operations
    /// </summary>
    internal class FileService : IFileService
    {
        private const string NumberRegex = @"^\d+";
        private const int NumberOfSubstrings = 2;

        /// <inheritdoc/>
        public async Task<string> LoadFileContentAsync(string filePath)
        {
            return await File.ReadAllTextAsync(filePath);
        }

        /// <inheritdoc/>
        public async Task UpdateNumberBullets(string content, string savePath)
        {
            int bulletPosition = 0;
            StringBuilder formattedBuilder = new();

            using (StringReader reader = new(content))
            {
                while (true)
                {
                    string line = await reader.ReadLineAsync();
                    if (line is null)
                    {
                        break;
                    }

                    if (Regex.IsMatch(line, NumberRegex))
                    {
                        var splitted = line.Split('.', NumberOfSubstrings);

                        formattedBuilder.Append(++bulletPosition);
                        formattedBuilder.Append(".");
                        formattedBuilder.AppendLine(splitted[1]);

                        continue;
                    }

                    formattedBuilder.AppendLine(line);
                }
            }

            var formattedContent = formattedBuilder.ToString();
            File.WriteAllText(savePath, formattedContent);
        }
    }
}
