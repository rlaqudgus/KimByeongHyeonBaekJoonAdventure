class Bj_11720
{
    public static void Main()
    {
        int caseNum = int.Parse(Console.ReadLine());
        string number = Console.ReadLine();
        int newNum = 0;

        for (int i = 0; i < number.Length; i++)
        {
            newNum += int.Parse(number[i].ToString());
        }

        Console.WriteLine(newNum);
    }
}