int ReadInt(string message) // Ввод переменных
{
    System.Console.WriteLine(message);// Получаем данные из Строки
    string value = Console.ReadLine();// Вызов консольного ввода
    return int.Parse(value);// Возвращает переменную в int
}

bool Weekend(int weekday)
{
if (weekday>5)
{
    return true;
}
return false;
}

bool ValidateWeekday(int number)
{
if (number>0 && number <=7)
{
    return true;
}
Console.WriteLine("Это не день недели");
return false;
}

int weekday= ReadInt("Введите день недели");
if (ValidateWeekday(weekday))
{
    if (Weekend(weekday))
    {
        Console.WriteLine("Выходной");
    }
    else 
    {
        Console.WriteLine("Рабочий день");
    }
}