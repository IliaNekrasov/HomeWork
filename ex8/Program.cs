﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число, N ");
int a = int.Parse(Console.ReadLine());

for (int i =2; i <= a; i = i + 2)
{
    Console.Write($"{i}, ");
}
