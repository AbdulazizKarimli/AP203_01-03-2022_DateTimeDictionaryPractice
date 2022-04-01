using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryPractice
{
    internal class Contact
    {
        Dictionary<string, string> _contacts;

        public Contact()
        {
            _contacts = new Dictionary<string, string>();
        }

        public void AddContact(User user)
        {
            foreach (var contact in _contacts)
            {
                if (contact.Key == user.Name || contact.Value == user.PhoneNumber)
                    throw new AlreadyExistsException("bele bir contact movcuddur");
            }
            _contacts.Add(user.Name, user.PhoneNumber);
        }
        public Dictionary<string, string> GetAllContacts()
        {
            return _contacts;
        }
        public string GetContactByName(string name)
        {
            return _contacts.GetValueOrDefault(name);
        }
    }
}
