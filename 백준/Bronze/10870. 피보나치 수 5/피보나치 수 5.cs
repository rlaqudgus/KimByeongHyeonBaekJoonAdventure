using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_10870
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int Fibo(int n)
            {
                if (n == 0)
                    return 0;
                if (n == 1)
                    return 1;

                return Fibo(n - 1) + Fibo(n - 2);
            }

            int answer = Fibo(n);

            Console.WriteLine(answer);
        }
        

    }
}