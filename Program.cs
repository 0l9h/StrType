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
        public override bool Equals(object obj)
        {
            if(obj is MyString ms)
            {
                return ToString() == ms.ToString();
            }
            return false;
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            MyString str = new MyString("Hello world!");
            MyString str2 = new MyString("Hello world!!");
            Console.WriteLine(str.Equals(str2));
        }
    }
}
