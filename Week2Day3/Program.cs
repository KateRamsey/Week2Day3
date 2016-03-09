using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bob bob = new Bob();
            string remark = "";
            remark = "WATCH OUT!";
            Console.WriteLine(bob.hey(remark));
            Console.WriteLine("\t\t\t\t\t");

            Console.ReadLine();
        }
    }
}
