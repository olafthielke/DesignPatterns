using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Patterns.Structural.HumbleObject;

namespace Tests.Structural
{
    public class SiteAnalyserTests
    {
        [Fact]
        public async Task Test_SiteAnalyser_With_Real_HttpClient()
        {
            var analyser = new SiteAnalyser(new HttpClient());
            var contentSize = await analyser.GetContentSize("https://codecoach.co.nz");
            contentSize.Should().Be(93456);
        }


        [Fact]
        public async Task Unit_Test_SiteAnalyser_With_Stub()
        {
            var webClient = new StubWebClient("Hello World!");
            var analyser = new SiteAnalyser(webClient);
            var contentSize = await analyser.GetContentSize("https://codecoach.co.nz");
            contentSize.Should().Be(12);
        }
    }
}
