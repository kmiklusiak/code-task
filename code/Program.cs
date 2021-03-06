using System;
using System.Collections.Generic;

namespace code
{
    class Program
    { 
        public static List<int> A = new List<int> { 2, 3, 9, 2, 5, 1, 3, 7, 10 };
        public static List<int> B = new List<int> { 2, 1, 3, 4, 3, 10, 6, 6, 1, 7, 10, 10, 10 };
        public static List<int> C = new List<int> { };

        public static void Check(List<int> A, List<int> B)
        {
            DateTime startTime = DateTime.Now;
            C.Clear();
            foreach (int a in A)
            {
                List<int> H = B.FindAll(
                delegate (int element)
                {
                    return element == a;
                }
                );
                if (!IsPrime(H))
                {
                    C.Add(a);
                }
            }
            Console.WriteLine("Lista C:");
            foreach (int c in C)
            { Console.WriteLine(c); }
            if (C.Count == 0)
                Console.WriteLine("-"); 
            DateTime endTime = DateTime.Now;
            TimeSpan workTime = endTime - startTime;
            Console.WriteLine("Time [ms]: " + workTime.TotalMilliseconds);
        }
        public static bool IsPrime(List<int> list)
        {
            for (int i = 2; i <= Math.Sqrt(list.Count); i++)
            {
                if (list.Count % i == 0) return false;
            }
            if (list.Count < 2) return false;
            else return true;

        }
        static void Main(string[] args)
        {            
            Check(A, B);           
        }
    }
}
