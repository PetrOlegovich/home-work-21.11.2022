// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
string str = num.ToString();


if (num > 9999 && num < 100000)
{
     if (str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine($"число {num} ЯВЛЯЕТСЯ  палиндромом");
    }
    else
    {
        Console.WriteLine($"число {num} НЕ является палиндромом");
    }
}
else if (num < -9999 && num > -100000)
{
     if (str[1] == str[5] && str[2] == str[4])
    {
        Console.WriteLine($"число {num} ЯВЛЯЕТСЯ  палиндромом");
    }
    else
    {
        Console.WriteLine($"число {num} НЕ является палиндромом");
    }
}
else 
{
    Console.WriteLine("это не пятизначное число");
}