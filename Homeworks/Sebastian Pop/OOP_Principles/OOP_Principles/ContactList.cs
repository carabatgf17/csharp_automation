using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    class ContactList
    {
        List<Person> contactList;

        public ContactList()
        {
            this.contactList = new List<Person>();
        }

        public void AddPersonToContacts(Person person)
        {
            this.contactList.Add(person);
        }

        public List<Person> SortById()
        {
            List<Person> listSortedById = GetContactList();
            listSortedById.Sort((x, y) => x.Id.CompareTo(y.Id));
            return listSortedById;
            
        }

        public List<Person> SortByName()
        {
            List<Person> listSortedByName = GetContactList();
            listSortedByName.Sort((x, y) => x.Name.CompareTo(y.Name));
            return listSortedByName;

        }

        public List<Person> GetContactList()
        {
            return this.contactList;
        }

        public Person FindByName(string name)
        {
            return contactList.Find((x => x.Name == name));
           
        }



    }
}
