
class Lab
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int prev = int.Parse(Console.ReadLine());
        int cur = int.Parse(Console.ReadLine());
        int LocalMin = 0;
        for (int i = 2; i < n; i++)
        {
            int next = int.Parse(Console.ReadLine());
            if (cur < prev && cur < next)
            {
                LocalMin++;
            }
            prev = cur;
            cur = next;
        }
        Console.WriteLine(LocalMin);

    }

}


