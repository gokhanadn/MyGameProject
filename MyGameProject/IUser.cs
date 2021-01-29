using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    interface IUser
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        long TC { get; set; }
        int BirthYaer { get; set; }
    }
}
