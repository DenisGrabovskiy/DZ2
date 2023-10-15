//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int ReadInt(string message) // Ввод переменных
{
    System.Console.WriteLine(message);// Получаем данные из Строки
    string value = Console.ReadLine();// Вызов консольного ввода
    return int.Parse(value);// Возвращает переменную в int
}

int number = ReadInt("Введите трехзначное число :");
if (number<100 || number >1000)
{
    Console.WriteLine("Вы ввели неправильное число, повторите ");
    return;
}
Console.WriteLine($"Введенное число '{number}'");
int secondRank=number / 10 % 10;
Console.WriteLine($"Вторая цифра '{secondRank}'");