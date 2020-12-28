namespace EventBusImpl.Events
{
    public class UserCreated : IEvent
    {
        public UserCreated()
        {
        }

        public UserCreated(string email, string name)
        {
            this.Email = email;
            this.Name = name;

        }
        public string Email { get; init;}
        public string Name { get; init;}
    }
}