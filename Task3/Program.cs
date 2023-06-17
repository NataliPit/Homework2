// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool validate7sign(int number)
{
    if (number >= 1 && number <= 7)
    {
        return true;
    }

    System.Console.WriteLine("Число должно быть в диапазоне от 1 до 7!");
    return false;
}

int number = ReadInt("Введите число ");
if (number >= 1 && number <= 5)
{
    int Digit = number;
    System.Console.Write($"Сегодня {number} день недели - сегодня будний день.");
}
else
{
    int Digit = number;
    System.Console.Write($"Сегодня {number} день недели - сегодня выходной!");
}