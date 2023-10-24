// Программа, выводит случайное число шз отрезка[10, 99]
// и показывает таибольшую цифру числа


// int num = new Random().Next(10, 100); // генерирует случ. ч. в диапазоне 10-99
// Console.WriteLine(num); // выводит его на экран

// int num1 = num / 10; // берет десятки числа
// int num2 = num % 10; // берет единицы числа
// if(num1 > num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }



// Программа выводит случайное трехзначеное число и удаляет 
// вторую цифру этого числа

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int num1 = num / 100;
// int num2 = num % 10;

// int result = num1 * 10 + num2;
// Console.WriteLine(result);



// Программа, принимает на вход два числа и выводит,
// является ли первое число кратным второму. Если число 1 не
// кратно числу 2, то программа выводит остаток от деления.

// Console.WriteLine("Введите число");
// int num1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int num2= Convert.ToInt32(Console.ReadLine());
// if(num1 >= num2)
// {
//     if(num1 %num2==0)
//     {
//     Console.WriteLine("кратно");
//     }
//     else
//     {
//     Console.WriteLine($"не кратно, остаток {num1 %num2} ");
//     }
// }
// else
// {
//     Console.WriteLine("Число 1 меньше числа 2!");
// }



// Программа, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// Console.WriteLine("Введите число");
// int num1= Convert.ToInt32(Console.ReadLine());

// if(num1 % 7 == 0 && num1 % 23 == 0) // && -то и то, || - или
// {
// Console.WriteLine("Да");
// }
// else
// {
// Console.WriteLine("Нет");
// }



// Программа, которая принимает на вход два числа и 
// проверяет, является ли одно число квадратом другого.

// Console.WriteLine("Введите число");
// int num1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int num2= Convert.ToInt32(Console.ReadLine());

// if(num1 ==num2* num2 || num2 ==num1 *num1) // && - и || - или
// {
// Console.WriteLine("Да");
// }
// else
// {
// Console.WriteLine("Нет");
// }
