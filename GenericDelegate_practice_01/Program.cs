using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate_practice_01
{
    class Program
    {
       public delegate void newDelegate(string name);
        static void Main(string[] args)
        {
            newDelegate newDelegate = add;
            newDelegate("asad");
            Console.WriteLine("-------");
            Console.ReadKey();

         }
       public static void add(string name)
        {
            Console.WriteLine("this is "+name);
        }
    }
}
