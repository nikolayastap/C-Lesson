Console.Clear();

//         // Задача 53: Задайте двумерный массив. Напишите программу,
//         // которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите кол-во строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во солбцев:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] CreateArray() // Создаем массив и заполняем случайными числами
// {
//     int[,] array = new int[rows,columns];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] matrix) // Печатаем массив
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j]+ "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] ChangeArray(int[,] matrix) // Меняем элементы первой строки на элементы последней строки
// {
//     int indexEndRow = matrix.GetLength(0)-1; // Находим индекс последней сторки

//     for (int j = 0; j < matrix.GetLength(1); j++) // Перещелкиваем столбцы
//     {
//         int temp = matrix[0,j]; // Во временную переменную записываем элемент из первой строчки
//         matrix[0,j] = matrix[indexEndRow,j]; // В первую строку записываем элемент с последней строчки
//         matrix[indexEndRow,j] = temp; // В последнюю строку записываем знасение из временной переменной
//     }
//     return matrix; // По завершению цикла возращаем получееный результат
// }

// int[,] result = CreateArray(); // Созаем пустой думерный массив и передаем в него результат функции
// PrintArray(result); 
// ChangeArray(result);
// System.Console.WriteLine();
// PrintArray(result);



//         // Задача 59: Задайте двумерный массив из целых чисел. Напишите
//         // программу, которая удалит строку и столбец, на пересечении
//         // которых расположен наименьший элемент массива.
//         // Например, задан массив:
//         // 1 4 7 2
//         // 5 9 2 3
//         // 8 4 2 4
//         // 5 2 6 7
//         // Наименьший элемент - 1, на выходе получим следующий массив:
//         // 923
//         // 424
//         // 267


// Console.WriteLine("Введите кол-во строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцев:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int minElement= 10; // Храниться минимальный эл.
// int rowMinEl=0; // Номер строчки мин. эл.
// int columnsMinEl=0; // Номер столбца мин. эл

// int[,] CreateArray()
// {
//     int[,] array = new int[rows,columns];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10);

//             if(minElement > array[i,j]) // Делаем проверку, если данный эл. меньше чем наш мин. эл.
//             {
//                 minElement = array[i,j]; // Тогда меняем переменную
//                 rowMinEl= i; // Сохраняем расположение
//                 columnsMinEl = j;
//             }
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             System.Console.Write(matrix[i,j]+ "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void ChangeArray(int[,] matrix) // выводим только те элементы которые не содержат мин
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i != rowMinEl && j != columnsMinEl) // Если номер строки и номер столбца не равняется мин.
//             {
//                 System.Console.Write(matrix[i,j]+ "\t"); // Тогда выводим
//             }
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] result = CreateArray();
// PrintArray(result);

// System.Console.WriteLine();
// ChangeArray(result);



        // Задача 55: Задайте двумерный массив. Напишите программу,
        // которая заменяет строки на столбцы. В случае, если это
        // невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine()); 

int[,] CreateArray()
{
    int[,] array = new int[rows,rows];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j]+ "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] matrix)
{
    int[,] result = new int[rows,rows];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[j,i] = matrix[i,j]; // В эом цикле меняем строки на столбцы
        }
    }
    return result;
}

int[,] result = CreateArray();
PrintArray(result);

System.Console.WriteLine();
PrintArray(ChangeArray(result));





