﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i;
int cub;

for (i=1; i<=num; i++)
{
    cub = i*i*i;
    Console.WriteLine($"{i},{cub}");
}

