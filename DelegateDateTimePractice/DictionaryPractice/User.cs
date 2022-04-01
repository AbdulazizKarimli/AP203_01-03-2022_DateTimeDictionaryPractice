using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryPractice
{
    internal class User
    {
        private static int _id;
        public User()
        {
            _id++;
            Id = _id;
        }

        public int Id { get; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public User(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}
