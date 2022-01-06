using System.Threading.Tasks;

namespace DocumentFormatter.Interfaces.Services
{
    /// <summary>
    /// Main service contract
    /// </summary>
    public interface IMainService
    {
        /// <summary>
        /// Default method that will start execution of the business logic
        /// </summary>
        Task ExecuteAsync();
    }
}
