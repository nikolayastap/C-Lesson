Console.Clear();

//         // Задача 40. Программа, принимает на вход три числа и
//         // проверяет, может ли существовать треугольник с 
//         // сторонами такой длины.
//         // Теорема о неравенстве треугольника: каждая 
//         // сторона треугольника меньше суммы двух других сторон.

// System.Console.WriteLine("Введите число");
// int num1 = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число");
// int num3 = int.Parse(Console.ReadLine());

// if(num1<num2+num3 && num2<num1+num3 && num3<num2+num1) // || - или && - и
// {
//     System.Console.WriteLine("Подходит");
// }
// else
// {
//     System.Console.WriteLine("Не подходит");
// }



//         // Задача 42. Программа, преобразовывает десятичное
//         // число в двоичное. -- 45 -> 101101; 3  -> 11; 2  -> 10

// System.Console.WriteLine("Введите число");
// int num1 = int.Parse(Console.ReadLine());

// string result= "";

// while(num1>0)
// {
//     result = num1%2 + result; // такое строение (+result) делает запись перевернутой
//     num1= num1/2; // после записи остатка от деления, делим число
// }

// System.Console.WriteLine(result);



//         // Задача 44: Не используя рекурсию, выведите первые 
//         // N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//         // Если N = 5 -> 0 1 1 2 3
//         // Если N = 3 -> 0 1 1
//         // Если N = 7 -> 0 1 1 2 3 5 8

// int firstNum =0; // так как первые 2а чесла даны, их надо записать
// int secondNum=1;

// System.Console.WriteLine("Введите число");
// int num1 = int.Parse(Console.ReadLine());

// System.Console.Write(firstNum + " " +secondNum + " "); // спразу выводим данные элементы

// for (int i = 3; i <= num1; i++) // начинаем с 3 элемента так как 2 уже жаны
// {
//     int nextNum = firstNum+secondNum;
//     System.Console.Write(nextNum+" ");

//     firstNum = secondNum; // делаем присвоение на шаг вправо
//     secondNum = nextNum;
// }



        // Задача 39 Программа, перевернёт одномерный массив (последний
        // элемент будет на первом месте, а первый - на последнем и т.д.)
        // [1 2 3 4 5] -> [5 4 3 2 1]
        // [6 7 3 6] -> [6 3 7 6]

System.Console.WriteLine("Укажите размер массива:");
int num = int.Parse(Console.ReadLine());

int[] array = new int[num]; //создаем пустой массив, размером указанным пользователем

for (int i = 0; i < array.Length; i++)
{
array[i]= new Random().Next(0,10); //с помощи цикла заполняем массив случайными числами
System.Console.Write(array[i]+ " "); //выводим массив
}

for (int i = 0; i < array.Length/2; i++)
{
int temp = array[i]; //с помощю временной переменной temp сохраняем элемент слева, для замены с правым
array[i] =array[array.Length-1-i]; //записываем в освободившиюся ячейку эл. справа
array[array.Length-1-i]=temp; //в освободившийся эл. справа записываем temp
}

System.Console.WriteLine(); //чтобы массивы не сливались и вывелись на разных строках

for (int i = 0; i < array.Length; i++)
{
System.Console.Write(array[i]+ " "); //выводим перевернутый массив
}



