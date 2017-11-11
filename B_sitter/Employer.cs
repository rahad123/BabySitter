using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_sitter
{
    public class Person
    {
        public string name;

    }
    public class PhoneNumber : Person
    {
        public int phoneNumber;
    }

    public class Employer : PhoneNumber
    {
        public string address;
        public List<Child> child;
        public Relative relative;
        internal string age;
        internal int healthInformation;
        internal string relationShip;

        public Employer()
        {
            child = new List<Child>();
        }
    }

    public class Relative : PhoneNumber
    {
        public string relationShip;
    }

    public class Child : Person
    {
        public int age;
        public string healthInformation;
    }
}
