using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IFacebookGroupMediator facebookMediator = new FacebookGroupMediator();
            AbstractUser Ram = new User(facebookMediator, "Ram");
            AbstractUser Dave = new User(facebookMediator, "Dave");
            AbstractUser Smith = new User(facebookMediator, "Smith");
            AbstractUser Rajesh = new User(facebookMediator, "Rajesh");
            AbstractUser Sam = new User(facebookMediator, "Sam");
            AbstractUser Pam = new User(facebookMediator, "Pam");
            AbstractUser Anurag = new User(facebookMediator, "Anurag");
            AbstractUser John = new User(facebookMediator, "John");

            facebookMediator.RegisterUser(Ram);
            facebookMediator.RegisterUser(Dave);
            facebookMediator.RegisterUser(Smith);
            facebookMediator.RegisterUser(Rajesh);
            facebookMediator.RegisterUser(Sam);
            facebookMediator.RegisterUser(Pam);
            facebookMediator.RegisterUser(Anurag);
            facebookMediator.RegisterUser(John);

            Dave.Send("India won bronze in Men's hockey at Tokyo Olympics");
            Console.WriteLine();

            Rajesh.Send("Listen to the latest BTS song");
            Console.Read();
        }
    }
}
