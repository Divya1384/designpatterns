namespace Mediator
{
    public abstract class AbstractUser
    {
        protected IFacebookGroupMediator mediator;
        protected string name;

        public AbstractUser(IFacebookGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public abstract void Send(string message);

        public abstract void Receive(string message);
    }
}
