namespace Mediator
{
    public interface IFacebookGroupMediator
    {
        void SendMessage(string message, AbstractUser user);

        void RegisterUser(AbstractUser sender);
    }
}
