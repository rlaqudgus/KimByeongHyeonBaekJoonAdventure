using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_10250
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();
            //Input testcase T height H roomNumber W customerNumber N
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int H = input[0];
                int W = input[1];
                int N = input[2];

                //process input으로 N의 값을 구해보자 모든 경우의수가 다 있는 배열을 만들어볼까? 는 에바고 간단히 해보자
                // H=6,W=12,10번째인 경우 402호 10나누기6 나머지는 4 몫은 1 YY(층수)는 나머지 XX(번호)는 몫더하기 1
                //1층만 있는 경우는 따로 해주기
                if (H==1)
                {
                    string firstFloorAnswer = H + "" + N;
                    if (firstFloorAnswer.Length==2)
                    {
                        sb.AppendLine(H + "0" + N);
                        continue;
                    }

                    sb.AppendLine(firstFloorAnswer);
                    continue;
                    
                }

                int YY = N % H;
                int XX = (N / H) + 1;

                if (N%H==0)
                {
                    YY = H;
                    XX = (N / H);
                }

                string answer = YY + "" + XX;

                if (XX.ToString().Length==1)
                {
                    string newAnswer = answer.Insert(answer.Length-1, "0");
                    sb.AppendLine(newAnswer);
                    continue;
                }

                sb.AppendLine(answer);
            }

            Console.WriteLine(sb);
        }
    }
}
