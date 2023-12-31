﻿// ------------------------------------------------------------------------------------------------------------------------------------
//                                                                  Задача №15 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary
// -----------------------------------------------------------------------------------------------------------------------------------

// Метод с первым вариантом
void Variant1(int day)
{
    // Сообщение о варианте
    Console.WriteLine("Вариант решения - 1");
    // Проверяем, укзанный день - один из рабочих
    if (day > 0 && day < 6) { Console.WriteLine("нет"); }
    // Если не рабочий, то проверяем на выходной
    else if (day > 5 && day < 8) { Console.WriteLine("да"); }
    // Если ни одно из условий не выполнено - выводим сообщение о числе несоответствующем дням недели
    else { Console.WriteLine("Введенное число не день недели."); }
}
//Метод со вторым вариантом
void Variant2(int day)
{
    // Сообщение о варианте
    Console.WriteLine("Вариант решения - 2");
    // Обявляем справочник и заполняем его
    Dictionary<int, string> days = new Dictionary<int, string>()
    {
        {1,"нет - Понедельник"},
        {2,"нет - Вторник"},
        {3,"нет - Среда"},
        {4,"нет - Четверг"},
        {5,"нет - Пятница"},
        {6,"да - Суббота"},
        {7,"да - Воскресенье"}
    };
    // Проверяем на то, что указанное число является днем недели. 
    //Если да - то выдаем сообщение из справочника, если нет - сообщение о числе несоответствующем дням недели
    Console.WriteLine((day > 0 && day < 8) ? days[day] : "Введенное число не день недели.");
}

Console.Write("Введите число: ");
// Считываем введенное число
int numb = int.Parse(Console.ReadLine() ?? "0");
// Вызываем метод с первым вариантом и передаем ему считанное число
Variant1(numb);
// Вызываем метод со вторым вариантом и передаем ему считанное число
Variant2(numb);