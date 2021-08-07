using System.Collections.Generic;

namespace Mediator
{
    public class FacebookGroupMediator : IFacebookGroupMediator
    {
        private List<AbstractUser> userList = new List<AbstractUser>();

        public void RegisterUser(AbstractUser user)
        {
            userList.Add(user);
        }

        public void SendMessage(string message, AbstractUser sender)
        {
            foreach(var user in userList)
            {
                if (user != sender)
                {
                    user.Receive(message);
                }
            }
        }
    }
}
