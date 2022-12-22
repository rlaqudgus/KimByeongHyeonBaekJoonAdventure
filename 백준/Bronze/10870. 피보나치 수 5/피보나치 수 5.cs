using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Test
    {
        static int Fibo(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibo(n - 2) + Fibo(n - 1);

        }
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int answer = Fibo(N);

            Console.WriteLine(answer);
        }
    }
}
