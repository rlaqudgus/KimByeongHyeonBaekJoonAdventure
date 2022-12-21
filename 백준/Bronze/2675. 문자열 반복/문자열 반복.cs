using System;
using System.Text;
class Bj_2675
{
    public static void Main()
    {
        //Input 입력값 T로 받고 반복문으로 각각의 케이스마다 S와 R을 따로 선언
        int T =int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < T; i++)
        {
            string[] array = Console.ReadLine().Split(" ");
            int R = int.Parse(array[0]);
            string S = array[1];

            for (int j = 0; j < S.Length; j++)
            {
                string newstring = new string(S[j], R);
                sb.Append(newstring);
            }

            sb.Append("\n");
        }
        Console.WriteLine(sb.ToString());
    }
}
