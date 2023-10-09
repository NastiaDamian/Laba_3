using System;
using System.Reflection;
using System.Runtime.Serialization.Formatters;

class Program
{
    static void Main()
    {
        //Завдання 1 
        
        Console.WriteLine("Парні числа від 1 до 20 включно");

        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        //Завдання 2
        
        Console.WriteLine("Сумма чисел від 1 до 100");
        int num = 0;
        for (int s = 1; s <= 100; s++) 
        {
            num += s ;
        }
        Console.WriteLine("Сума всіх чисел " + num ) ;

        //Звдання 3 
        Console.Write("Введіть число ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Таблиця множення для числа {number}:");

        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} * {i} = {result}");
        }
        

        //Завдання 4 
        Console.WriteLine("Введіть число для обчислення факторіалa");
        int b = Convert.ToInt32(Console.ReadLine());
        int a = 1;
         for (int c = 1; c<=b; c++)
        {
            a *= c;
        }
        Console.WriteLine($"Факторiал числа {b} дорiвнює {a}");

        //Завдання 5 

        int sumPrimes = 0;

        for (int num1 = 2; num1 <= 50; num1++)
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(num1); i++)
            {
                if (num1 % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                sumPrimes += num1;
            }
        }

        Console.WriteLine(" Сума простих чисел вiд 1 до 50: " + sumPrimes);


        // Завдання 6 

        Console.WriteLine("Введіть число ");
        int numberA = Convert.ToInt32(Console.ReadLine());
        string numberB = Convert.ToString(numberA, 2);
        Console.WriteLine($"Двiйкове представлення числа: {numberB}");

        //Завдання 7 
        Console.Write("Введіть максимальне число Фібоначчі: ");
        int maxN = Convert.ToInt32(Console.ReadLine());

        int ang = 0, bi = 1, sum = 0, count = 0;

        while (ang + bi < maxN)
        {
            int temp = ang + bi;
            if (temp % 2 == 0)
            {
                sum += temp;
            }
            ang = bi;
            bi = temp;
            count++;
        }

        Console.WriteLine($"Сума парних чисел Фібоначчі, які менше {maxN}, дорівнює {sum}");
        Console.WriteLine($"Кількість елементів Фібоначчі, які менше {maxN}, дорівнює {count}");

        //Завдання 8 
        Console.WriteLine("Введіть перше число");
        int ccc = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть друге число");
        int ggg = Convert.ToInt32(Console.ReadLine());
        int h1 = 1;

        for (int i = 1; i <= ccc && i <= ggg; i++)
        {
            if (ccc % i == 0 && ggg % i == 0)
            {
                h1 = i;
            }
        }

        Console.WriteLine($"НСД чисел {ccc} i {ggg} дорiвнює {h1}");




    }



}


        
    
