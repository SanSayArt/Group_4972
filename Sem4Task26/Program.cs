﻿// ----------------------------------------------------------------------------------------------------------------------------
// Задача №26
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// ----------------------------------------------------------------------------------------------------------------------------

// Метод для ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}
// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
// Подсчет количества цифр в числе
int numDigits(int numb)
{
    int count = 0;
    while(numb > 0)
    {
        count++;
        numb = numb/10;
    }
    return count;
}

int num = ReadData("Введите число: ");
PrintResult("Количество цифр в числе - " + numDigits(num));