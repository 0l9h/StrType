using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace StrType
{
    class MyString : IComparable<MyString>
    {
        List<char> _data = new List<char>();

        public MyString() { }
        public MyString(string str)
        {
            _data.AddRange(str);
        }
        public MyString(char[] arr)
        {
            _data.AddRange(arr);
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
            if (obj is MyString ms)
            {
                return ToString() == ms.ToString();
            }
            return false;
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }



        public int CompareTo(MyString other)
        {
            if (other is null)
            {
                throw new ArgumentNullException(nameof(other));
            }
            return string.Compare(ToString(), other.ToString());
        }



        public static bool operator ==(MyString first, MyString second)
        {
            return first.Equals(second);
        }
        public static bool operator !=(MyString first, MyString second)
        {
            return !first.Equals(second);
        }
        public static bool operator >(MyString first, MyString second)
        {
            if (string.Compare(first.ToString(), second.ToString()) == 1) return true;
            return false;
        }
        public static bool operator <(MyString first, MyString second)
        {
            if (string.Compare(first.ToString(), second.ToString()) == -1) return true;
            return false;
        }
        public static bool operator >=(MyString first, MyString second)
        {
            if (string.Compare(first.ToString(), second.ToString()) == -1) return false;
            return true;
        }
        public static bool operator <=(MyString first, MyString second)
        {
            if (string.Compare(first.ToString(), second.ToString()) == 1) return false;
            return true;
        }

        public static implicit operator MyString(string str)
        {
            return new MyString(str);
        }
        public static implicit operator string(MyString str)
        {
            return str.ToString();
        }
        public static explicit operator MyString(char[] arr)
        {
            return new MyString(arr);
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            
            char[] arr = new char[] { 'f', 'o', 'o' };
            MyString ms = (MyString)arr;

            Console.WriteLine(ms);
        }
    }
}
