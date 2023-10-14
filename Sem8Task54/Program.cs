// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// ----------------------------------------------------------------------------------------------------------------------------------------------------------------------

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
//метод сортировки
void SortMass(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            int temp = arr[i,j];
            int z = j - 1;

            // Поиск места для числа в левой части
            while (z >= 0 && arr[i,z] > temp)
            {
                arr[i,z + 1] = arr[i,z];
                arr[i,z] = temp;
                z--;
            }
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
PrintResult("-----------------------------------------------");
SortMass(array);
Print2DArray(array);