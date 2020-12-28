using System.Threading.Tasks;
using EventBusImpl.Commands;

namespace EventBusImpl
{
    public interface ICommandHandler<in T> where T : ICommand
    {
         Task HandleAsync(T command);
    }
}