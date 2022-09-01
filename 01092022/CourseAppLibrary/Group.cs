using CourseAppLibrary.Enums;
using System;
using System.Collections.Generic;

namespace CourseAppLibrary
{
    public class Group
    {
        private string _no;
        public string No
        {
            get => _no;
            set
            {
                if (CheckGroupNo(value))
                {
                    _no = value;
                }
            }
        }
        public byte Limit;
        public GroupType Category;
        public List<Student> Students = new List<Student>();

        public string GetInfo()
        {
            return $"{this.No} - {this.Limit} - {this.Category}";
        }

        public static bool CheckGroupNo(string no)
        {
            if (string.IsNullOrWhiteSpace(no) || no.Length != 4)
                return false;

            return true;
        }


    }
}
