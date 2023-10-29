Console.Clear();
        // Функции!!!
// тип возврощающего значения + Название + () + {}

//     // Задача 24: Программа принимает на вход число (А)
//     // и выдаёт сумму чисел от 1 до А.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetSum()
// {
//     int start = 1;
//     int sum=0;

//     while(start<= num)
//     {
//         sum += start; // sum = sum +start;
//         start++;
//     }
//     return sum;
// }

// System.Console.WriteLine(GetSum()); // int result= GetSum();
//                                     // System.Console.WriteLine(result);



        // Задача 26. Программа принимает на вход число и
        // выдаёт количество цифр в числе.

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetCountNumbers(int newNum) // (int newNum) АРГУМЕНТ, необхимо указывать при появлении доп переменных
// {
//     int count = 0;

//     while(newNum> 0)
//     {
//         newNum/=10; // newNum = newNum/10;
//         count++;
//     }
//     return count;
// }

// Console.WriteLine(GetCountNumbers(num)); // int result= GetCountNumbers(num);
//                                          // System.Console.WriteLine(result);



//         // Задача 28. Программа принимает на вход число N
//         // и выдаёт произведение чисел от 1 до N.(Факториал)

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetMultiplication()
// {
//     int start = 1;
//     int multiplication = 1; // multiplication - умножение

//     while(start<= num)
//     {
//         multiplication *= start; // Multiplication = Multiplication *start;
//         start++;

//     }
//     return multiplication;
// }

// Console.WriteLine(GetMultiplication());



        // Задача 30. Программа выводит массив из 8 элементов,
        // заполненный нулями и единицами в случайном порядке.
        // [1,0,1,1,0,1,0,0]

CreateArray(); // вызывает функцию

void CreateArray()
{
    int[] array = new int[8]; // создаем пустой массив из 8 элиментов

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2); // (0,2) указаваем не 0,1 так как последний эл. необходимо указать на 1 болше
        System.Console.Write(array[i]+ " ");
    }
}