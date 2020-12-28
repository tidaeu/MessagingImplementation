using System;
using System.Threading.Tasks;
using EventBusImpl.Events;

namespace EventBusImpl.Handlers
{
    public class UserCreatedHandler : IEventHandler<UserCreated>
    {
        public async Task HandleAsync(UserCreated @event)
        {
            await Task.CompletedTask;
            Console.WriteLine($"User Created Event: {@event.ToString()}");
        }
    }
}