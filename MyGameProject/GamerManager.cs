using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class GamerManager : IUserService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Added");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Updated");
        }
    }
}
