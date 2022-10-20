using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_1769
    {
        public static void Main()
        {
            //Input 큰 수 X 입력

            string input = Console.ReadLine();
            
            int Y = 0;
            int check = 0;

            //Process X의 각 자리수 더한 값 계속 구하기 X가 1의자리수가 될때까지

            do
            {
                if (input.Length<2)
                {
                    Y = int.Parse(input);
                    break;
                }
                int newInt = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    newInt += (input[i] - '0');
                }
                Y = 0;
                Y += newInt;
                input = Y.ToString();
                check++;
            }
            while (Y >= 10);

            string answer = Y % 3 == 0 ? "YES" : "NO";

            Console.WriteLine(check + "\n" + answer);
        }
        
        

    }
}
