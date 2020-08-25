using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************************");
            Console.ResetColor();
            Contact Cont = new Contact();
            Cont.firstname = "Tala";
            Cont.phonenumber = ("09058172622");
            Console.WriteLine(Cont);
            Console.ReadKey();

  
        }
    }
}
