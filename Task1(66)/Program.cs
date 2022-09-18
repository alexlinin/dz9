﻿/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());


int sumNumbers(int start, int end)
{
    // Базовый случай
    if (start > end) return 0;
    // Рекурсивный случай
    return (start + sumNumbers(start + 1, end));
}
Console.WriteLine($"Сумма чисел от {M} до {N} = {sumNumbers(M, N)}");



