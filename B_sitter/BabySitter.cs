using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_sitter
{
    class BabySitter
    {
        List<Employer> anEmployer = new List<Employer>();

        public void Start()
        {
            Console.WriteLine("Add employee for 1");
            Console.WriteLine("Remove employee for 2");
            Console.WriteLine("Show database for 3");
            int value = int.Parse(Console.ReadLine());
            if(value == 1)
            {
                Add_Employee();
            }
            else if(value == 2)
            {
                Remove_Empliyee();
            }
            else
            {
                Database();
            }
        }

        public void Add_Employee()
        {
            Console.WriteLine("Enter new employee name");
            string employee_Name = Console.ReadLine();
            Console.WriteLine("Enter new employee address");
            var em_Address = Console.ReadLine();
            Console.WriteLine("Enter new ph_number");
            var ph_Number = int.Parse(Console.ReadLine());
            var employer = new Employer() { name = employee_Name, address = em_Address, phoneNumber = ph_Number };
            anEmployer.Add(employer);
            AddRelativesOrExit();
        }

        public void AddRelativesOrExit()
        {
            Console.WriteLine("Add relatives for 1");
            Console.WriteLine("Exit for 2");
            int value = int.Parse(Console.ReadLine());
            if(value == 1)
            {
                AddRelatives();
            }
            else
            {
                Start();
            }
        }

        public void AddRelatives()
        {
            Console.WriteLine("Enter relatives name");
            var rel_Name = Console.ReadLine();
            Console.WriteLine("Enter relationship");
            var relation = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            int ph_Number = int.Parse(Console.ReadLine());
            var employer = new Employer { name = rel_Name, relationShip = relation, phoneNumber = ph_Number};
            anEmployer.Add(employer);
            AddChildOrExit();
        }

        public void AddChildOrExit()
        {
            Console.WriteLine("Add child for 1");
            Console.WriteLine("Exit for 2");
            int value = int.Parse(Console.ReadLine());
            if (value == 1)
            {
                AddChild();
            }
            else
            {
                Start();
            }
        }
        public void AddChild()
        {
            Console.WriteLine("Enter child name");
            var child_Name = Console.ReadLine();
            Console.WriteLine("Enter age");
            var ch_Age = Console.ReadLine();
            Console.WriteLine("Enter health information");
            int hl_Information = int.Parse(Console.ReadLine());
            var employer = new Employer { name = child_Name, age = ch_Age, healthInformation = hl_Information };
            anEmployer.Add(employer);
            AddChildOrExit();
        }
        public void Remove_Empliyee()
        {
            Console.WriteLine("enter new id which you want to delete");
            int press = int.Parse(Console.ReadLine());
            if(anEmployer.Count == 0)
            {
                Console.WriteLine("you have no data,insert first");
                Start();
            }
            else
            {
                anEmployer.RemoveAt(press - 1);
                Database();
                Start();
            }
        }
        public void Database()
        {
            if(anEmployer.Count == 0)
            {
                Console.WriteLine("you have no data insert first");
                Start();
            }
            else
            {
                EmployerDetails();
            }
        }
        public void EmployerDetails()
        {
            Console.WriteLine("Id\t Name\t Addres\t ph_Number");
            for (int i = 0; i < anEmployer.Count; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", i + 1, anEmployer[i].name, anEmployer[i].address, anEmployer[i].phoneNumber);

                if (anEmployer[i].relative != null)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t", anEmployer[i].relative.name, anEmployer[i].relative.phoneNumber, anEmployer[i].relative.relationShip);
                }
                for (int j = 0; j < anEmployer.Count; j++)
                {
                    if (anEmployer[i].child != null)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", anEmployer[i].child[j].name, anEmployer[i].child[j].age, anEmployer[i].child[j].healthInformation);
                    }
                }
            }
            Start();
        }
       
    }
}
