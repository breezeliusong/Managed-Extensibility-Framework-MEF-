using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    class Program
    {
        A a=new A();
        B b=new B();
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.a.GetType().Name);
            Console.WriteLine(program.b.GetType().Name);
            Console.ReadLine();
        }
    }

    class A
    {

    }
    class B:A
    {
    }

}
