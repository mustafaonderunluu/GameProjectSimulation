using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //çalışabilmek için başka bir mikroservise ihtiyaç duyuyorum diyor.
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                ID = 1,
                BirthYear = 1985,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 12345
            });
            



        }
    }
}
