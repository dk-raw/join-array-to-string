using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            JoinToString('D', 'O', 'G', 'E');
        }
        private static void JoinToString(char foo1, char foo2, char foo3, char foo4)
        {
            //First way
            char[] p = new char[] { foo1, foo2, foo3, foo4 };
            string final = new string(p);
            Console.WriteLine(final);
            Console.WriteLine("~~~~~~~~~~~~");
            //Second way
            string final2 = string.Join("", foo1, foo2, foo3, foo4);
            Console.WriteLine(final2);
        }
    }
}
