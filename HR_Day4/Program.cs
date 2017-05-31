using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //hr code
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }

            Console.ReadKey();
        }


    }
    class Person
    {
        int age;
        public Person(int inage)
        {
            if (inage < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
                return;
            }
            age = inage;

        }

        public void yearPasses()
        {
            age++;
        }
        public void amIOld()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");
                return;
            }
            else if (age < 18)
            {
                Console.WriteLine("You are a teenager.");
                return;
            }

            Console.WriteLine("You are old.");
        }
    }
}
