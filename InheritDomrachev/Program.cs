using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritDomrachev
{
    class A
    {
        public virtual void Method() { Console.WriteLine("A"); }
    }
    class B : A
    {
        public override void Method() { Console. WriteLine("b"); }
    }
    class C : B
    {
        public virtual void Method() { Console.WriteLine("c"); }
    }
    class D : C
    {
        public override void Method()
        {
            Console.WriteLine("d");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            A a = d;
            B b = d;
            C c = d;

            
            a.Method();
            b.Method();
            c.Method();
            d.Method();

            Console.ReadKey();
        }
    }
}
