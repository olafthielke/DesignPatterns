using System.Net.Http;
using System.Threading.Tasks;

namespace Patterns.Structural.HumbleObject
{
    public interface IWebClient
    {
        Task<HttpResponseMessage> GetAsync(string requestUri);
    }
}
