using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerManager gamerManager = new GamerManager(new UserValidationManager()); 
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            { Id = 1, BirthYear = 1997, LastName = "Akkas", FirstName = "Hidayet", IdentityNumber = 1235466879 });
            //gamerManager.Add(new Gamer
            //{ Id = 1, BirthYear = 1998, LastName = "Akkas", FirstName = "Hidayet", IdentityNumber = 1235466879 });

        }
    }
}
