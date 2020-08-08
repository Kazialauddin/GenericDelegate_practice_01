using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate_practice_01
{
    class Program
    {
       public delegate void newDelegate(string name,int age);
        static void Main(string[] args)
        {
            newDelegate newDelegate = add;
            newDelegate("asad",17);
            Console.WriteLine("-----dd--");
            Console.ReadKey();

         }
       public static void add(string name)
        {
            Console.WriteLine("this is "+name);
            Console.WriteLine("this is method has 1 parameter");
        }
        public static void add(string name,int age)
        {
            Console.WriteLine("this is "+name+". And Age "+age);
            Console.WriteLine("Method overloading 2parameter");
        }
    }
}
