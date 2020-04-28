using System;


namespace ReverseStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write something: ");
            string input = Console.ReadLine();
            Console.WriteLine(Reverse(input));
        }

        static string Reverse(string input)
        {
            char[] ara = input.ToCharArray();
            Array.Reverse(ara);
            return new string(ara);
        }
    }
}