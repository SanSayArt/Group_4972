// -----------------------------------------------------------------------------------------------------------------------------------------------------------
// №34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// (со звездочкой) Отсортировать массив методом пузырька
// ----------------------------------------------------------------------------------------------------------------------------------------------------------

// Метод заполнения массива cслучайными числами из указанного диапазона
void FillMass(int[] arr, int lowBorder, int maxBorder)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(lowBorder, maxBorder + 1);
    }
}
// Метод вывода массива на экран
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

// Метод подсчета четных чисел в массиве
int GetCount(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            res++;
    }
    return res;
}
// Метод 
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = new int[8];
FillMass(array, 100, 999);
int count = GetCount(array);
PrintArr(array);
PrintResult(" -> " + count);