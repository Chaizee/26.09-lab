// Определить количество локальных минимумов﻿
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
//Определить все ли элементы последовательности чётные
class Program {
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int prev = int.Parse(Console.ReadLine());
        int Chet = 1;
        for (int i = 1; i < n; i++)
        {
            int next = int.Parse(Console.ReadLine());
            if ((prev % 2) == 0)
            {
                Chet++;
            }        
            prev = next;
        }
        if (Chet == n)
        {
            Console.WriteLine("Все эллементы четные");
        }
        else
        {
            Console.WriteLine("Не все эллементы четные");
        }
    }
}

//Необходимо определить два максимума
    
