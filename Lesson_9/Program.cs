﻿Console.Clear();

//         // Задача 63: Задайте значение N. Напишите программу,
//         //  которая выведет все натуральные числа в промежутке
//         // от 1 до N.
//         // N = 5 -> "1, 2, 3, 4, 5"
//         // N = 6 -> "1, 2, 3, 4, 5, 6"

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int firstNum = 1;

// string PrintNumber(int start, int end)
// {
//     if(start==end)
//     {
//         return start.ToString();
//     }

//     return start+ " "+ PrintNumber(start+1, end);
// }

// Console.WriteLine(PrintNumber(firstNum,num));



//         // Задача 65: Задайте значения M и N. Напишите программу, которая
//         // выведет все натуральные числа в промежутке от M до N.
//         // M = 1; N = 5 -> "1, 2, 3, 4, 5"
//         // M = 4; N = 8 -> "4, 6, 7, 8"

// System.Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// string PrintNumber(int start, int end) 
// {
//     if(start==end)
//     {
//         return start.ToString();
//     }

//     return start+ " "+ PrintNumber(++start, end); //Инкремент
// }

// if(num1>num2)
// {
//     Console.WriteLine(PrintNumber(num2,num1));
// }
// else if(num1<num2)
// {
//     Console.WriteLine(PrintNumber(num1,num2));
// }
// else
// {
//      Console.WriteLine("Ввели равные числа");
// }



//         // Задача 67: Напишите программу, которая будет
//         // принимать на вход число и возвращать сумму его цифр.
//         // 453 -> 12
//         // 45 -> 9

// System.Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int start) 
// {
//     if(start==0)
//     {
//         return 0;
//     }
//     return (start % 10+ SumNumber(start/10)); 
// }

// System.Console.WriteLine(SumNumber(num2)); // вызываем рекурсию и передаем в нее число



        // Задача 69: Напишите программу, которая на вход принимает два
        // числа A и B, и возводит число А в целую степень B с помощью рекурсии.
        // A = 3; B = 5 -> 243 (3⁵)
        // A = 2; B = 3 -> 8

System.Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num, int rank) 
{
    if(rank==0)
    {
        return 1;
    }
   if(rank==1)
   {
    return num;
   }
    return (num * SumNumber(num, rank-1)); // rank выступает как счетчик
}

System.Console.WriteLine(SumNumber(num1,num2));


