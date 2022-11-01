class Bj_1065
{
    public static void Main()
    {
        //Input
        int inputNum = int.Parse(Console.ReadLine());

        //Process
        //연속된 두개의 수의 차이가 일정한가?
        //반복문을 돌면서 if로 두개 수 차가 일정한지 확인 일정하면 count++
        //주어진 수가 한자리수 혹은 두자리수라면 무조건 한수임

        int count = 0;

        for (int i = 1; i <= inputNum; i++)
        {
            if (i < 100)
            {
                count++;
            }

            else
            {
                string istring = i.ToString();
                int a = int.Parse(istring.Substring(0, 1));
                int b = int.Parse(istring.Substring(1, 1));
                int c = int.Parse(istring.Substring(2, 1));  
                
                if (a-b==b-c)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);

    }
}
