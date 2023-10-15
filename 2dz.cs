//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int ReadInt(string message) // Ввод переменных
{
    Console.WriteLine(message);// Получаем данные из Строки
    string value = Console.ReadLine();// Вызов консольного ввода
    int result = Convert.ToInt32(value);// Возвращает переменную в int
    return result;
}
int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цыфры нет");
        return false;
    }
    return true;
}

int number = ReadInt("Введите число больше 100 :");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}