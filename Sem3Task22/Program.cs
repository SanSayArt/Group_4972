// --------------------------------------------------------------------------------------------------------
//                                              Задача №22
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// --------------------------------------------------------------------------------------------------------

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
//Вычисляем и составляем строку
string BuildLine(int num, int pow)
{
    string res = string.Empty;
    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, pow) + " ";
    }

    return res;
}

int x = ReadData("Введите число: ");     // Считываем введенное число

PrintResult(BuildLine(x,1));    // Выводим первую строку (без возведения в степень)
PrintResult(BuildLine(x,2));    // Выводим вторую строку (с возведением в степень)