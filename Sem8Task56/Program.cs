// ---------------------------------------------------------------------------------------------------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// ---------------------------------------------------------------------------------------------------------------------------------------------------------

// Метод для ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}
//метод заполнения массива
void FillMass(int[,] arr, int lowBorder, int maxBorder)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(lowBorder, maxBorder + 1);
        }
    }
}
// Метод печати двумерного массива
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+"\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
//Метод поиска строки с наименьшей суммой элементов
int FindMinStringInMass(int[,] matrix)
{
    int sum = 0;
    int numbOfString = -1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempSum += matrix[i,j];
        }
        if (numbOfString > -1)
        {
            if (tempSum < sum)
            {
                sum = tempSum;
                numbOfString = i + 1;
            }
        }
        else
        {
            sum = tempSum;
            numbOfString = i + 1;
        }
    }
    return numbOfString;
}
// Метод вывода на экран
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int n = ReadData("Введите количество строк: ");
int m = ReadData("Введите количество столбцов: ");
int[,] array = new int[n,m];
FillMass(array,1,15);
Print2DArray(array);
PrintResult($"Строка с минимальной суммой элементов -> {FindMinStringInMass(array)}");

