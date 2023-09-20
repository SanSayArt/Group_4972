// ---------------------------------------------------------------------------------------------------------------------------------------
// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// (задание со *) Сделать оценку времени алгоритма через вещественные числа и строки
// ---------------------------------------------------------------------------------------------------------------------------------------

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
// Метод подсчета суммы цифр в числе без перевода в строку 
int SumDigits(int numb)
{
    int res = 0;
    while(numb > 0)
    {
        res += numb%10;
        numb /= 10;
    }
    return res;
}

int SumDigString(int numb)
{
    int res = 0;
    //string chislo = numb.ToString();
    char[] digits = numb.ToString().ToCharArray();
    for (int i = 0; i < digits.Length; i++)
    {
        res += int.Parse(digits[i].ToString());
    }
    return res;
}
int num = ReadData("Введите число: ");
DateTime time = DateTime.Now; 
PrintResult($"Сумма цифр в числе: {num} равна {SumDigits(num)}. Вычисления числами были произведены за: {(DateTime.Now - time).ToString()} ");
time = DateTime.Now; 
PrintResult($"Сумма цифр в числе: {num} равна {SumDigString(num)}. Вычисления с конвертацией в строку были произведены за: {(DateTime.Now - time).ToString()} ");
