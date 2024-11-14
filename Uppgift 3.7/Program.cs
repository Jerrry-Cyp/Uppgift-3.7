using System;
using System.Globalization;
using System.Net.Security;

namespace Uppgift_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en addition eller subtraction:");
            string S = Console.ReadLine();
            int N = S.IndexOfAny(new char[] { '+', '-' });
            string Vänster = S.Substring(0, N);
            string Höger = S.Substring(N + 1);
            char tecken = S[N];
            int Tal1 = int.Parse(Vänster);
            int Tal2 = int.Parse(Höger);
            
            if (tecken == '+')
            {
                Console.WriteLine(Tal1 + Tal2);
            }
            if (tecken == '-')
            {
                Console.WriteLine(Tal1 - Tal2);
            }
            
        }
    }
}