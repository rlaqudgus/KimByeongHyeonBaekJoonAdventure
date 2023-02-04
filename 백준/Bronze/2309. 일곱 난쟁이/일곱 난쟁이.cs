using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_2309
    {
        public static void Main()
        {
            List<int> heightList = new List<int>();
            List<int> answerList = new List<int>();
            StringBuilder sb = new StringBuilder();
            bool isFinished = false;
            int heightSum = 0;

            //Input 난쟁이 키 9줄
            for (int i = 0; i < 9; i++)
            {
                heightList.Add(int.Parse(Console.ReadLine()));
            }

            //Process 모든 경우의 수를 다 찾는 로직 7중for문..?
            List<int> method(List<int> list)
            {
                for (int i = 0; i < heightList.Count; i++)
                {
                    if (isFinished) break;
                    for (int j = i + 1; j < heightList.Count; j++)
                    {
                        if (isFinished) break;
                        for (int k = j + 1; k < heightList.Count; k++)
                        {
                            if (isFinished) break;
                            for (int l = j + 1; l < heightList.Count; l++)
                            {
                                if (isFinished) break;
                                for (int m = l + 1; m < heightList.Count; m++)
                                {
                                    if (isFinished) break;
                                    for (int n = m + 1; n < heightList.Count; n++)
                                    {
                                        if (isFinished) break;
                                        for (int o = n + 1; o < heightList.Count; o++)
                                        {
                                            heightSum = heightList[i] + heightList[j] + heightList[k] +
                                                heightList[l] + heightList[m] + heightList[n] + heightList[o];
                                            if (heightSum == 100)
                                            {
                                                //sb.AppendLine(heightList[i].ToString());
                                                //sb.AppendLine(heightList[j].ToString());
                                                //sb.AppendLine(heightList[k].ToString());
                                                //sb.AppendLine(heightList[l].ToString());
                                                //sb.AppendLine(heightList[m].ToString());
                                                //sb.AppendLine(heightList[n].ToString());
                                                //sb.AppendLine(heightList[o].ToString());

                                                answerList.Add(heightList[i]);
                                                answerList.Add(heightList[j]);
                                                answerList.Add(heightList[k]);
                                                answerList.Add(heightList[l]);
                                                answerList.Add(heightList[m]);
                                                answerList.Add(heightList[n]);
                                                answerList.Add(heightList[o]);

                                                answerList.Sort();
                                                isFinished = true;
                                                break;
                                                
                                            }

                                            else
                                            {

                                                heightSum = 0;
                                                

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                return answerList;
            }

            //OutPut 출력

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(method(heightList)[i]);
            }
        }
    }
}
