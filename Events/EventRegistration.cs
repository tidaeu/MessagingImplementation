
using Microsoft.AspNetCore.Hosting;
using RawRabbit;

namespace EventBusImpl.Events
{
    public class EventRegistration : IEventRegestration
    {
        public void Register(IWebHost webHost, IBusClient bus)
        {
            var register = new RegisterEvent(webHost, bus);
            register.SubscribeToEvent<UserCreated>();
        }
    }
}