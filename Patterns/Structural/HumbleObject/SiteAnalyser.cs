using System.Net.Http;
using System.Threading.Tasks;

namespace Patterns.Structural.HumbleObject
{
    public class SiteAnalyser : ISiteAnalyser
    {
        private IWebClient WebClient { get; }

        public SiteAnalyser(HttpClient httpClient)
        {
            WebClient = new WebClient(httpClient);
        }

        public SiteAnalyser(IWebClient webClient)
        {
            WebClient = webClient;
        }

        public async Task<int> GetContentSize(string uri)
        {
            var response = await WebClient.GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();
            return content.Length;
        }
    }
}
