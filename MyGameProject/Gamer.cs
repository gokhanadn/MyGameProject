using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class Gamer : IUser
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long TC { get; set; }
        public int BirthYaer { get; set; }
    }
}
