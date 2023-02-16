using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Patterns.Structural.HumbleObject;

namespace Tests.Structural
{
    public class StubWebClient : IWebClient
    {
        private string ContentToReturn { get; }

        public StubWebClient(string contentToReturn)
        {
            ContentToReturn = contentToReturn;
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return new HttpResponseMessage
            {
                Content = new StringContent(ContentToReturn),
                StatusCode = HttpStatusCode.OK
            };
        }
    }
}
