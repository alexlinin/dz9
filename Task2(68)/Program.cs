/*Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int funcAccerman(int m, int n)
{
    //Базовый случай
    if (m == 0) return n + 1;
    // Рекурсивные случаи
    else
        if ((m != 0) && (n == 0)) return funcAccerman(m - 1, 1);
        
        else return funcAccerman(m - 1, funcAccerman(m, n - 1));
}

Console.WriteLine($"Значение функции Аккермана для m = {m} и n = {n} = {funcAccerman(m, n)}");