﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int ReadInt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = result.Parse(value);
    return result;

}

int number = ReadInt("Введите трехзначное число :");
if (number<100 || number >1000)
{
    Console.WriteLine("Вы ввели неправильное число, повторите ");
    return;
}
Console.WriteLine($"Введенное число '{number}'");