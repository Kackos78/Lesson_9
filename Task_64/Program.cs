﻿// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int NaturalToN(int n)
{
    if (n == 0)
    {
        return 1;
    }
    System.Console.Write($"{n} ");
    return NaturalToN (n-1);
}

System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalToN(n);
