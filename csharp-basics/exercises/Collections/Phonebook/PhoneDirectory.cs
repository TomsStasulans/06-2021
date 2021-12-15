using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, PhoneEntry> _data;
        private int _dataCount;

        public PhoneDirectory(string name, PhoneEntry number) 
        {

            _data.Add(name, number);
            _dataCount++;
        }

        private int Find(string name) {
            for (var i = 0; i < _dataCount; i++) 
            {
                if (_data.Keys.Equals(name)) 
                {
                    return i;
                }
            }

            return -1;
        }

        public string GetNumber(string name) 
        {
                return _data[name].number;
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }

            var i = Find(name);
            if (i >= 0) 
            {
                _data[name].number = number;
            }
            else 
            {
                var newEntry = new PhoneEntry {number = number };
                _data.Add(name, newEntry);
                _dataCount++;
            }
        }
    }
}