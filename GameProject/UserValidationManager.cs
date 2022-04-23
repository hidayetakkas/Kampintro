using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1997 && gamer.FirstName == "Hidayet" && gamer.LastName == "Akkas" && gamer.IdentityNumber == 1235466879)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
