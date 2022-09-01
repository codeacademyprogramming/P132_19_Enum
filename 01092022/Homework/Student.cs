using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Student
    {
        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; private set; }
        public readonly string Surname;
        public const byte Age = 50;

        public void SetValue(string name)
        {
            Name = name;
        }
    }
}
