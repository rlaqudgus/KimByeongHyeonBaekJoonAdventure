using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_2897
    {
        public static void Main()
        {
            //Input 행 R과 열 C

            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int R = input[0];
            int C = input[1];

            int zero = 0;
            int one=0;
            int two=0;
            int three=0;
            int four=0;

            //일단 모든 결과를 한 문자열에 저장
            StringBuilder sb = new StringBuilder();

             

            for (int i = 0; i < R; i++)
            {
                sb.Append(Console.ReadLine());
            }


            //process
            //첫번째부터 돌아가면서 옆,밑,대각선 4개의 문자를 확인해야함
            //옆:i+1 / 밑:i+C / 대각선: i+1+C
            //이증에 하나라도 #이 포함되어 있으면 continue
            //X가 있으면 그 수와 대응하는 변수에 ++
            //#도 X도 없으면 0 변수에 ++
            //인덱스값이 C-1의 배수일 경우 건너뛰기
            int a = 0;
            for (int i = 0; i < sb.Length-C-1; i++)
            {
                
                if ((i+1) % C == 0)
                {
                    continue;
                }
                int Xcount = 0;

                if (sb[i]=='#' || sb[i+1]=='#' || sb[i+C]=='#'|| sb[i+1+C]=='#')
                {
                    continue;
                }

                //else
                //{
                    StringBuilder sb2 = new StringBuilder();
                    sb2.Append(sb[i]);
                    sb2.Append(sb[i + 1]);
                    sb2.Append(sb[i + C]);
                    sb2.Append(sb[i + 1 + C]);

                    //list.Add(sb[i].ToString());
                    //list.Add(sb[i+1].ToString());
                    //list.Add(sb[i+C].ToString());
                    //list.Add(sb[i+1+C].ToString());

                    if (sb2.ToString()=="....")
                    {
                        zero++;
                        continue;
                    }

                    for (int j = 0; j < sb2.Length; j++)
                    {
                        if (sb2[j]=='X')
                        {
                            Xcount++;
                        }
                    }

                    
                    //foreach (var item in sb2)
                    //{
                    //    if (item == 'X'.ToString())
                    //    {
                    //        Xcount++;
                    //    }
                    //    Console.Write(item);

                    //}

                    //if (Xcount==0)
                    //{
                    //    zero++;
                    //}
                 

                    if (Xcount==1)
                    {
                        one++;
                    }
                    if (Xcount==2)
                    {
                        two++;
                    }
                    if (Xcount==3)
                    {
                        three++;
                    }
                    if (Xcount==4)
                    {
                        four++;
                    }

                    //a++;
                    
                //}
            }
            //Console.WriteLine(a);
            Console.WriteLine(zero);
            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(three);
            Console.WriteLine(four);

        }
    }
}
