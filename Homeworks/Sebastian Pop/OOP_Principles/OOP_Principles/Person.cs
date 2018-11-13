using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    class Person
    {
        public string Id, Name, Surname, Phonenumber;

        public Person(string id, string name, string surname, string phonenumber)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Phonenumber = phonenumber;
        }
    }
}
