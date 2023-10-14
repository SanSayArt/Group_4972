// --------------------------------------------------------------------------------------------------------------------------------------
//                                                  Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// --------------------------------------------------------------------------------------------------------------------------------------


// Метод Считывания с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
// Функция Аккермана 
int CalcAck(int n, int m)
{
    if (n == 0)
    {
        return (m + 1);
    }
    else if (m == 0)
    {
        return CalcAck(n - 1, 1);
    }
    else
    {
        return CalcAck(n - 1, CalcAck(n, m - 1));
    }
}
// Метод вывода на экран
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int n = ReadData("введите число (n): ");
int m = ReadData("введите число (m): ");
PrintResult(CalcAck(n, m).ToString());