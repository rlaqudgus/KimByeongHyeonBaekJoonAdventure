using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_20004
    {
        public static void Main()
        {
            //Input A
            int A = int.Parse(Console.ReadLine());

            for (int i = 1; i <= A; i++)
            {
                if (30 % (i+1) == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
