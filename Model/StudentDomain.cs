using Model.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class StudentDomain
    {
        public class Class : DropdownItem
        {
            public int Id { get; set; }
            public string ClassName { get; set; }
            public string DropdownText() => ClassName;
            public string DropdownValue() => Id.ToString();
            public bool DropdownItemEnabled() => true;
        }
        public class Student
        {
            public int Id { get; set; }
            public int ClassId { get; set; }
            public string Nama { get; set; }
        }
    }
}
