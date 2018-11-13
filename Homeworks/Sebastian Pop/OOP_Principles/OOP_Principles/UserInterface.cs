using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    class UserInterface
    {

        private ContactList contactList;

        public UserInterface()
        {
            contactList = new ContactList();
        }

        private void DisplayMenu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add person");
            Console.WriteLine("2. Display person list by ID");
            Console.WriteLine("3. Display person list by Name");
            Console.WriteLine("4. Search for a person");
            Console.WriteLine("X. Exit");
            Console.WriteLine(" ");
        }

        public void Run()
        {
            DisplayMenu();
            string inputOption = Console.ReadLine();

            while (true)
            {
                if (inputOption == "1") AddPerson();
                if (inputOption == "2") SortById();
                if (inputOption == "3") SortByName();
                if (inputOption == "4") SearchPerson();
                if ((inputOption == "X")||(inputOption=="x")) break;
                DisplayMenu();
                inputOption = Console.ReadLine();
            }
        }

        private void SearchPerson()
        {
            Console.Write("Name of the person: = ");
            string inputSearch = Console.ReadLine();
            Console.Write("Found person: ");
            PrintPerson(contactList.FindByName(inputSearch));
        }

        private void SortByName()
        {
            foreach (var person in contactList.SortByName())
            {
                PrintPerson(person);
            }
        }

        private void SortById()
        {
            foreach (var person in contactList.SortById())
            {
                PrintPerson(person);
            }
        }

        private void AddPerson()
        {
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter phonenumber: ");
            string phonenumber = Console.ReadLine();

            Person person = new Person(id, name, surname, phonenumber);

            contactList.AddPersonToContacts(person);
        }

        private void PrintPerson(Person person)
        {
            Console.WriteLine(person.Id + ".  " + person.Name + " " + person.Surname + " " + person.Phonenumber);
        }

    }
}
