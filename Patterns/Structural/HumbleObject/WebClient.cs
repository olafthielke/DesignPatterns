using System.Net.Http;
using System.Threading.Tasks;

namespace Patterns.Structural.HumbleObject
{
    public class WebClient : IWebClient
    {
        private HttpClient HttpClient { get; }

        public WebClient()
        {
            HttpClient = new HttpClient();
        }

        public WebClient(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return await HttpClient.GetAsync(requestUri);
        }
    }
}
