using EventBusImpl.RabbitMQ;
using EventBusImpl.Services;
using Microsoft.AspNetCore.Hosting;
using RawRabbit;

namespace EventBusImpl.Events
{
    public class RegisterEvent
    {
        private readonly IWebHost _webHost;
        private IBusClient _bus;

        public RegisterEvent(IWebHost webHost, IBusClient bus)
        {
            _webHost = webHost;
            _bus = bus;
        }

        public RegisterEvent()
        {
        }

        public void SubscribeToEvent<TEvent>() where TEvent : IEvent
        {
            var handler = (IEventHandler<TEvent>)_webHost.Services
                    .GetService(typeof(IEventHandler<TEvent>));

            _bus.WithEventHandlerAsync(handler);
        }

        public void Build()
        {
            return;
        }
    }
}