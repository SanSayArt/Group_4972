// ------------------------------------------------------------------------------------------------------------------
// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// (задание со *) Написать калькулятор с операциями +, -, /, * и возведение в степень
// ------------------------------------------------------------------------------------------------------------------

// Метод для считывания введенного числа из консоли
int ReadNumber(string msg)
{
    int num = 0;
    Console.Write(msg);
    num = int.Parse(Console.ReadLine()??"0");
    return num;
}
// Метод для считыванрия знака действия
string ReadOperand(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}
// Метод сложения
int Sum(int numA, int numB)
{
    int res = 0;
    res = numA + numB;
    return res;
}
// Метод вычитания
int Dif(int numA, int numB)
{
    int res = 0;
    res = numA - numB;
    return res;
}
// Метод умножения
long Mult(int numA, int numB)
{
    long res = 0;
    res = numA * numB;
    return res;
}
// Метод деления
double Div(int numA, int numB)
{
    double res;
    res = (double) numA / numB;
    return res;
}
// Метод возведения в степень
long MyPow(int numA, int numB)
{
    long res = 1;
    for(int i=1; i <= numB; i++)
    {
        res *= numA;
    }
    return res;
}
// Метод вывода на экран
void PrintRes(string msg)
{
    Console.WriteLine(msg);
} 

int numA = ReadNumber("Введите число А: "); 
string oper = ReadOperand("Введите символ действия (+,-,/,*,^): ");
int numB = ReadNumber("Введите число B: ");

// Проверяем введенный символ вычисления и выполняем действие
switch (oper)
{
    case "+":
        PrintRes($"Сумма чисел {numA} и {numB} равна {Sum(numA, numB)}");
        break;
    case "-":
        PrintRes($"Разность чисел {numA} и {numB} равна {Dif(numA, numB)}");
        break;
    case "*":
        PrintRes($"Произведение чисел {numA} и {numB} равна {Mult(numA, numB)}");
        break;
    case "/":
        PrintRes($"Частное чисел {numA} и {numB} равна {Div(numA, numB)}");
        break;
    case "^":    
        PrintRes($"Возведение числа {numA} в степень {numB} равна {MyPow(numA, numB)}");
        break;
    default:
        PrintRes($"Введеный символ '{oper}' не определен.");
        break;
}
