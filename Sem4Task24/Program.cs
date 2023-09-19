// -------------------------------------------------------------------------------------------------------------------------------------------------------
// Задача № 24
// Напишите программу, которая принимает на вход число (А) и выдает сумму от 1 до А.
// -------------------------------------------------------------------------------------------------------------------------------------------------------

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
// Вычисляем сумму чисел
int Sum(int numb)
{
    int sumOfNumber = 0;
    
    for (int i = 1; i <= numb; i++)
    {
        sumOfNumber += i;
    }
    return sumOfNumber;
}

int GaussSum(int numb)
{
    int sumOfNumber = 0;
    sumOfNumber = numb*(numb+1)/2;
    return sumOfNumber;
}
int numbA = ReadData("Введите число А: ");
DateTime d1 = DateTime.Now;
int res1 = Sum(numbA);
Console.WriteLine(DateTime.Now - d1);
DateTime d2 = DateTime.Now;
int res2 = GaussSum(numbA);
Console.WriteLine(DateTime.Now - d2);
PrintResult("Сумма чисел от 1 до " + numbA + " (простой) = " + res1);
PrintResult("Сумма чисел от 1 до " + numbA + " (по Гауссу) = " + res2);






