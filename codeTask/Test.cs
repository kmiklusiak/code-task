using System;
using System.Collections.Generic;
using System.Text;

namespace codeTask
{
    class Test
    {
        public static List<int> A = new List<int> { };
        public static List<int> B = new List<int> { };

        public static void CreateList(List<int> L)
        {
            Random rnd = new Random();
            int size = 21;
            for(int i = 0; i < size; i++)
            {
                int obj = rnd.Next(0, 10);
                L.Add(obj);
            }
        }
        public static void Testing()
        {
            CreateList(A);
            CreateList(B);
            Functions.Check(A, B);
        }
    }
}
