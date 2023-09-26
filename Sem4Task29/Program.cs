﻿// ---------------------------------------------------------------------------------------------------------------------------------------
// №29 
//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// (задание со *) Ввести с клавиатуры длину массива и диапазон значений элементов
// (задание со *) Дополнительно: Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).
// ---------------------------------------------------------------------------------------------------------------------------------------

// Метод для ввода данных
string ReadData(string msg)
{
    Console.Write(msg);
    string str = Console.ReadLine();
    return str;
}

// Печатаем результат
void Print(string msg)
{
    Console.WriteLine(msg);
}

// Метод создания и заполнения массива 
int[] GenArray(int len, int minDig, int maxDig)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(minDig, maxDig + 1);
    }
    return arr;
}

// Метод составления строки из элементов массива
string BildString(int[] arr)
{
    string res = string.Empty;
    int len = arr.Length;
    for (int i = 0; i < len - 1; i++)
    {
        res += arr[i] + ", ";
    }
    res += arr[len - 1];
    return res;
}

//Метод разделения строки на компоненты (массив)
string[] SplitString(string str)
{
    string[] res = str.Split(',');
    return res;
}

// Метод выбора случайного значения из массива
string RandomElement(string[] str)
{
    Random rnd = new Random();
    int len = str.Length;
    int i = rnd.Next(0, len);
    string res = str[i].ToString();
    return res;
}

//  Метод создания и вывода заранее определенного массива 
void AutoGenArray()
{
    // Выводим сообщение на экран
    Print("Автоматически сформированный массив состоящий из 8-ми элементов и заполняемый числами от 0 до 5: ");
    // Запускаем метод генерации массива и передаем ему заданные параметры 
    Print(BildString(GenArray(8, 0, 5)));
}

// Печать разделителя
Print("-----------------------------------------------------------------------------------------");

// Метод создания и вывода массива по параметрам от пользователя
void UserGenArray()
{
    // Выводим сообщения пользователю и считываем введенные числа
    int len = int.Parse(ReadData("Введите длину массива: ") ?? "0");
    int minDig = int.Parse(ReadData("Введите минимальное число для заполнения массива: ") ?? "0");
    int maxDig = int.Parse(ReadData("Введите максимальное число для заполнения массива: ") ?? "0");
    if (minDig < maxDig)    // Проверяем, чтобы минимальное число было меньше максимального
    {
        // Выводим сообщение на экран
        Print("Массив, сформированный по считанным данным: ");
        // Запускаем метод генерации массива и передаем ему введенные параметры 
        Print(BildString(GenArray(len, minDig, maxDig)));
    }
    else
    {
        // Выводим сообщение на экран
        Print("По считанным данным, массив не может быть заполнен. Минимальное число больше, чем максимальное. ");
    }
}

// Печать разделителя
Print("-----------------------------------------------------------------------------------------");

// Метод выбора случайного элемента из списка введенного пользователем в строку с разделителем "запятая"
void UserRndElement()
{
    string nam = ReadData("Введите значения в строку через запятую: ");
    Print($"Случайный элемент: {RandomElement(SplitString(nam))}");
} 

// запускаем программу на выполнение
AutoGenArray();
UserGenArray();
UserRndElement();
System.Threading.Thread.Sleep(1000);