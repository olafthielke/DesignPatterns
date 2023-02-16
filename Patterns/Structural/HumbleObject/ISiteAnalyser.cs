using System.Threading.Tasks;

namespace Patterns.Structural.HumbleObject
{
    public interface ISiteAnalyser
    {
        Task<int> GetContentSize(string uri);
    }
}
