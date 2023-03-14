using Patterns.Behavioural.ChainOfResponsibility.Incidents;

namespace Patterns.Behavioural.ChainOfResponsibility.Handlers
{
    public interface IHandler
    {
        void Handle(Incident incident);
    }
}
