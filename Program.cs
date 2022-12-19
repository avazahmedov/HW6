// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.


// int FindPositive(int M)
// {
//     int count = 0;
//     for (int i = 0; i<M; i++)
//     {
//         Console.WriteLine ("Введите число");
//         int n = Convert.ToInt32(Console.ReadLine());
//         if (n>0)
//         count++;
//     }
//     return count;
// }

// Console.WriteLine ("Введите количество чисел");
// int M = Convert.ToInt32(Console.ReadLine());
// int result = FindPositive(M);
// Console.WriteLine($"Количество чисел больше 0 - {result}");


// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void FindPoint(double b1, double k1 , double b2 , double k2)
// {
//     double x = (b1 - b2)/(k2 - k1);
//     double y = k1 * x + b1;
//     if (k2 - k1 == 0) Console.WriteLine ("NaN");
//     else 
//     Console.WriteLine($"Точка пересечение двух прямых - ({x};{y})");
// }

// Console.WriteLine ("Введите b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите k2");
// double k2 = Convert.ToInt32(Console.ReadLine());
// FindPoint(b1, k1 , b2 , k2);
