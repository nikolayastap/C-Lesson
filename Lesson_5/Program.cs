Console.Clear();

//         // Задача 31. Задайте массив из 12 элементов,
//         // заполненный случайными числами из промежутка
//         // [-9, 9]. Найдите сумму отрицательных и положительных
//         // элементов массива.

// CreateArray(); // вызов функции

// void CreateArray()
// {
//     int sumPosNum=0; // создали переменные сум
//     int sumNegNum=0;

//     int[] array = new int[12]; // создает массив из 12 эл.

//     for (int i = 0; i < array.Length; i++) // заполняет массив 
//     {
//         array[i] = new Random().Next(-9,10); // заполняет массив случайнами числами в деапазоне от -9 ДО 9+1
//         Console.Write(array[i]+ " "); // выводит массив в строку

//         if(array[i]>0) // ищет положительные эллемнты
//         {
//             sumPosNum= sumPosNum + array[i]; // сумирует все пол. эл.
//         }
//         else
//         {
//             sumNegNum = sumNegNum+ array[i]; // сумирует все отрицательные эл.
//         }
//     }
//     System.Console.WriteLine("\nПолож. = "+
//     sumPosNum+ " отриц.= "+ sumNegNum);
// }



//         // Задача 32. Программа замены элементов массива: положительные
//         // элементы замените на соответствующие отрицательные, и наоборот.

// CreateArray();

// void CreateArray()
// {
//     int[] array = new int[]{-4, -8, 8, 2, -31};

//     for (int i = 0; i < array.Length; i++)
//     {
//         // array[i] = array[i] *-1;
//         array[i] *= -1;
//         Console.Write(array[i]+ " ");
//     }
// }



//         // Задача 33. Программа создает массив из случ. чисел и определяет,
//         // присутствует ли заданное число в массиве.
//         // 4; массив [6, 7, 19, 345, 3] -> нет
//         // 3; массив [6, 7, 19, 345, 3] -> да

// CreateArray();

// void CreateArray()
// {
//     Console.WriteLine("Введите число");
//     int num = Convert.ToInt32(Console.ReadLine()); // поучаем от пользователя число

//     bool isFind = false; //буливая переменная для проверки есть ли число которое вводит пользователь
//     int[] array = new int[12]; // создаем массив

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,10);
//         Console.Write(array[i]+ " "); // заполняем массив

//         if(array[i]==num) // проверяем совподает ли с пользовательским числом
//         {
//             isFind =true; // тогда выводим isFind меняем на true
//         }
//     }

//     if(isFind==true)
//     {
//         Console.Write("Да");
//     }
//     else
//     {
//         Console.Write("Нет");
//     }
// }



//         // Задача 35. Задайте одномерный массив из 123 случайных чисел.
//         // Найдите количество элементов массива, значения которых лежат
//         // в отрезке [10,99].

// CreateArray();

// void CreateArray()
// {
//     int count =0;
//     int[] array = new int[123]; // создаем массив на 123 эллемента

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,200);
//         Console.Write(array[i]+ " "); // заполняем его числами от 0 до 200

//         if(array[i]> 9 && array[i]<100) // проверяем на соответствие условий
//         {
//             count++;
//         }
//     }
//     System.Console.WriteLine("Кол. = "+ count);
// }



//         // Задача 37. Найдите произведение пар чисел в одномерном 
//         // массиве. Парой считаем первый и последний элемент, второй
//         // и предпоследний и т.д. Результат запишите в новом массиве.

// CreateArray();

// void CreateArray()
// {
//     Console.WriteLine("Введите число");
//     int num = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя размер массива

//     int[] array = new int[num]; // полученное число указываем как размер 1го массива
//     int[] array2 = new int[array.Length/2+ array.Length%2]; // указываем размер 2го массива(/2 +%2 так как числа в первом массив сокращаются в 2е)

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,10);
//         Console.Write(array[i]+ " "); // с помощю цикла заполняем 1й массив
//     }
//     System.Console.WriteLine(); // создаем пустой консоль стобы разеденить оба массива
//     for (int i = 0; i < array2.Length; i++)
//     {
//         array2[i] = array[i] * array[array.Length-1-i]; // во 2й массив записываем произведение чисел первого

//     if(i== array.Length-1-i)
//     {
//         array2[i] = array[i]; // в случае если массив не четный, записываем среднее число
//     }
//     System.Console.Write(array2[i]+ " ");
//     }
// }
