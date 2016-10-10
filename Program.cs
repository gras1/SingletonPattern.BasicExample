using System;

namespace SingletonPattern.BasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor is protected -- cannot use new
            var s1 = Singleton.Instance();
            var s2 = Singleton.Instance();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
