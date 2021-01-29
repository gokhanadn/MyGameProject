using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    interface IUserService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
