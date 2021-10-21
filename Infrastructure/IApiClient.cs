using System.Threading.Tasks;

namespace CMDb___project.Infrastructure
{
    public interface IApiClient
    {
        Task<T> GetAsync<T>(string endpoint);
    }
}