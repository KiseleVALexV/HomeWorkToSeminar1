﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;

Console.WriteLine("Четные числа в заданном диапазоне : ");

while (count <= number)
{
   if (count % 2 == 0) 
   {
    Console.Write($"{count} ");
   }
   count = count + 1;
}

Console.WriteLine();
Console.ReadKey();

