﻿/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

System.Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
int sum = 0;

while(num > 0)
{
    int i = num%10; 
    num = num/10;
    sum = sum + i;
}
System.Console.WriteLine(sum);


