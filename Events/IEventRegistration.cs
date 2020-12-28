
using Microsoft.AspNetCore.Hosting;
using RawRabbit;

namespace EventBusImpl.Events
{
    public interface IEventRegestration
    {
        void Register(IWebHost webHost, IBusClient bus);
    }
}