using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryPractice
{
    internal class AlreadyExistsException : Exception
    {
        public AlreadyExistsException(string message) : base(message)
        {
        }
    }
}
