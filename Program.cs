using System;
using System.Collections.Generic;

namespace StrType
{
    class MyString
    {
        List<char> _data = new List<char>();

        public MyString() { }
        public MyString(string str)
        {
            _data.AddRange(str);
        }

        public char this[int i]
        {
            get => _data[i]; 
        }
        public override string ToString()
        {
            return new string(_data.ToArray());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyString str = new MyString("Hello world!");
            
            Console.WriteLine(str);
        }
    }
}
