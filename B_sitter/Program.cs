using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_sitter
{
    class Program
    {
        static void Main(string[] args)
        {
            BabySitter babysitter = new BabySitter();
            babysitter.Start();
           // babysitter.Add_Employee();
            Console.ReadKey();
        }
    }
}
