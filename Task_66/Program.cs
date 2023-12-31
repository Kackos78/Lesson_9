﻿// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NaturalFromMToN(int m, int n)
{
    if (n == m)
    {
        return n;
    }
    return n + NaturalFromMToN(m, n - 1);
}

System.Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.Write(NaturalFromMToN(m, n));