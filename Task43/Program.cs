﻿/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
Пример:
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


Console.Clear();
Console.Write("Введите значение b1:\t");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1:\t");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2:\t");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2:\t");
double k2 = double.Parse(Console.ReadLine()!);

double x = (b2-b1) / (k1-k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2; 
Console.WriteLine($"\nТочка пересечения прямых: ({y1:f2}; {y2:f2})");