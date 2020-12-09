using System;
namespace Maths
{
    class Program
    {
        public static int Addition(int a,int b)
        {
            int c = a + b;
            return c;
        }
        public static void Main(String []args)
        {
            Func<int, int,int> add = Addition;
            int a;
            a=add(10, 20);
            Console.WriteLine(a);     
            Func<int, int, int, int> mul = (a, b, c) => a * b * c;
            int b=mul(10, 20, 30);
            Console.WriteLine(b);
            Action<String> show = (s) => Console.WriteLine($"My Name is-{s}");
            show("Malli");
            Predicate<int> Check = (age) => age >18;
            bool agecheck = Check(19);
            Console.WriteLine(agecheck);
            agecheck = Check(12);
            Console.WriteLine(agecheck);
        }
    }
}
