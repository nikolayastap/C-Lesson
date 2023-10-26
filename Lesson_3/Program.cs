Console.Clear();

    // Задача №17. Программа, принимает навход координаты
    // точки (X и Y), причем X ≠ 0 и Y ≠ 0 и выдаёт номер
    // четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Координаты X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты Y: ");
// int y = int.Parse(Console.ReadLine()!);

// if(x==0 || y==0)
// {
// Console.WriteLine("Не верные данные! Координата не может быть равной 0. \n Введите правильные данные");
// }
// else if(x>0 && y>0)
// {
// Console.WriteLine("1");
// }
// else if(x<0 && y>0)
// {
// Console.WriteLine("2");
// }
// else if(x<0 && y<0)
// {
// Console.WriteLine("3");
// }
// else
// {
// Console.WriteLine("4");
// }



    // Задача 18. Программа, которая по заданному
    // номеру четверти, показывает диапазон возможных
    // координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());

// switch (num)
// {
//     case 1:
//     {
//         Console.WriteLine("x>0 y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("x<0 y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("x<0 y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("x>0 y<0");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("Нет такой четверти!");
//         break;
//     }
// }



        // Пример использования SWITCH
        // char ch;
        // Console.WriteLine("Введите букву");
        // ch = Convert.ToChar(Console.ReadLine());

        // switch(Char.ToLower(ch))
        // {
        //     case 'а':
        //     case 'у':
        //     case 'о':
        //     case 'ы':
        //     case 'и':
        //     case 'э':
        //     case 'я':
        //     case 'ю':
        //     case 'е':
        //     case 'ё':
        //         Console.WriteLine("Гласная");
        //         break;
        //     default:
        //         Console.WriteLine("Согласная");
        //         break;
        // }



    // Задача 21 Программа, принимает на вход координаты
    // двух точек и находит расстояние между ними в 
    // 2D пространстве.

    // Фортула из теоремы пифогора S= √((x2-x1)²+(y2-y2)²)

// Console.Write("Координаты первой точки по оси x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Координаты первой точки по оси y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Координаты второй точки по оси x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Координаты второй точки по оси y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double s= Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)); // Math.Sqrt()-вычесляет √; Math.Pow()-возводит число в необходимую степень

// Console.WriteLine($"Растояние между точками: {Math.Round(s,2)}"); // Math.Round()-сокращает количество ззнаков после ","




    // Задача 22 Программа, принимает на вход число (N)
    // и выдаёт таблицу квадратов чисел от 1 до N.

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i<=num; i++)
// {
//     Console.Write(Math.Pow(i,2)+ " "); // ( + " ")-конкатинация, способ выведения
// }

    // Таже хадача но с использованием while
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i<=num)
{
    double result = Math.Pow(i,2);
    Console.Write($"{result} "); // ($" ")-интерполяция, способ выведения
    i++;
}