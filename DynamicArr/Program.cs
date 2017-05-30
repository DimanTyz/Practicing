using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace DynamicArr
{
    //struct mystr : ICloneable
    //{
    //   static  int x;
    //    public static explicit operator Digit(byte arg)
    //    {
    //        int  a
    //            Int32 a
    //    }

    //}
    //class A: mystr
    //{

    //}
    static class A
    {
        public static void Method(this string value)
        {
            Console.WriteLine(value);
        }
    }


    class Program
    {
        //public const Program jdhf;
        public static string MyProperty;

        //a=>null;
        //Action act = new Action(a => {null});

        static void Main(string[] args)
        {

            try
            {
                throw null;
            }

            catch (Exception) { }

            Console.WriteLine("dsf");

            //MyProperty = "df";
            //Console.WriteLine(MyProperty);
               int[] arr = new int[5] { 5, 4, 3, 2, 1 };
            //    ArrayList list = new ArrayList();

            //    Console.WriteLine(list.BinarySearch(1));

            //    foreach (var item in list)
            //    {
            //        Console.WriteLine(item);
            //    }

            //Queue que = new Queue();
            //que.Enqueue(1);
            //que.Enqueue(2);
            //que.Enqueue(3);

            //Console.WriteLine(que.Peek());

            //que.Dequeue();

            //Console.WriteLine(que.Peek());

            //Console.WriteLine(2.CompareTo(1));


            // Console.WriteLine(arr.Rank);

            //int x = 5;
            //switch (x)
            //{

            //    case 1:
            //        goto case 2;
            //    //default:
            //    //    break;
            //    case 2: break;


            //}

            ////if (Method1() && Method2())
            ////{
            ////    Console.WriteLine(2);
            ////}

            //int a = 1;
            //if (true &&  a/(a-a)==0)
            //{
            //    Console.WriteLine(2);
            //}
            //else
            //    Console.WriteLine(1);

            //int c = 0, d;
            ////Console.WriteLine(c+d);

            //char b = '\0';

            //Method2(ref d);
            int[,] mas = new int[2, 4] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };

            //Der cl = new Der();
            int[,,] arrr = new int[2, 2, 2];
            //Console.WriteLine(arrr.Length);
            //A.x = 5;
            //A a = new A();
            //Pupil.Method();

            Console.WriteLine("here");
            Mystruct str = default(Mystruct);
            Console.WriteLine(str);
            str.SetVa(1);
            Console.WriteLine(str);
            object o = str;
            Console.WriteLine(o);
            Console.WriteLine("end");
            //FileStream 
            Console.WriteLine("here2");
            Console.WriteLine(EnumType.One);
            Console.WriteLine("------------------");

            Myde del1 = () => 1;
            Myde del2 = () => 2;
            Myde del3 = del1 + del2;
            Console.WriteLine(del3());

            Console.WriteLine("-----------------");
            int? a = null;
            int? b = null;
            Console.WriteLine(a++ == ++b);//? a ?? 10 : 5);

            //a = a + 5;
            Console.WriteLine(b + ",");


           // MyName.B.A t= new MyName.B.A();

            Pupil.Method();
            Console.ReadKey();
        }

        static bool Method1()
        {
            Console.WriteLine("meth1");
            return false;
        }
        static bool Method2(ref int b)
        {
            Console.WriteLine("Method2");
            return true;
        }
    }
    delegate int Myde();

    //class A: IDictionary
    //{
    //    static class Nested
    //    {

    //    }

    //    public static int x;
    //    static A(int temp)
    //    {
    //        Console.WriteLine(temp);
    //    }
    //}

        

    partial class Hi
    {

        //void Method(params[]a, string a) { }
        //partial void Method(int t)
        //{

        //}
    }
    //class Base
    //{
    //    protected int MyProperty { public get; set; }

    //    public Base()
    //    {
    //        Console.WriteLine("base");
    //    }
    //}
    //class Der: Base
    //{
    //    public Der()
    //    {
    //        Console.WriteLine("der");
    //    }
    //}

    public class Studetn
    {
        public Studetn()
        {
            Console.WriteLine("std");
        }
    }
    public class Pupil:Studetn
    {
        static Pupil()
        {
            Console.WriteLine("static");
        }

        public static void Method()
        {
            Console.WriteLine("study");
        }
    }
    enum EnumType : int
    {
        Zero = 0,
        One = 1
    }

    struct Mystruct
    {
        private int x;
        public void SetVa(int v) { x = v; }
        public override string ToString()
        {
            return x.ToString();
        }
    }
}

namespace MyName
{
    class A: ICollection , IEnumerable<T>
    {
        public A()
        {
            Console.WriteLine("A");
        }

        public int Count => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    namespace B
    {
        class A
        {

            public MyName.A prop { get; set; }


            public A()
            {
                Console.WriteLine("A from inside");
            }
        }
    }
}
