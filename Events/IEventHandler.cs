using System.Threading.Tasks;

namespace EventBusImpl.Events
{
    public interface IEventHandler<in T> where T : IEvent
    {
        Task HandleAsync(T @event);
    }
}