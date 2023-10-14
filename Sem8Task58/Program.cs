// -------------------------------------------------------------------------------------------------------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// -------------------------------------------------------------------------------------------------------------------------------------------------

//метод заполнения массива (матрицы)
void FillMass(int[,] arr, int lowBorder, int maxBorder)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(lowBorder, maxBorder + 1);
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
            Console.Write(matrix[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Метод умножения массивов (матриц)
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int xM1 = matrix1.GetLength(0);
    int yM1 = matrix1.GetLength(1);
    int xM2 = matrix2.GetLength(0);
    int yM2 = matrix2.GetLength(1);
    if (yM1 == xM2)
    {
        int[,] resultMatrix = new int[xM1, yM2];
        for (int x = 0; x < xM1; x++)
        {
            for (int y = 0; y < yM2; y++)
            {
                resultMatrix[x,y] = 0;
                for (int z = 0; z < yM1; z++)
                {
                    resultMatrix[x,y] += (matrix1[x, z] * matrix2[z, y]);
                }                
            }
        }
        return resultMatrix;
    }
    else
    {
        int[,] resultMatrix = new int[0, 0];
        return resultMatrix;
    }
}

// Метод вывода на экран
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[,] m1 = new int[2,2];
int[,] m2 = new int[2,2];
FillMass(m1,0,10);
Print2DArray(m1);
PrintResult("--------------------------------------------------");
FillMass(m2,0,10);
Print2DArray(m2);
PrintResult("--------------------------------------------------");
Print2DArray(MultiplicationMatrix(m1,m2));