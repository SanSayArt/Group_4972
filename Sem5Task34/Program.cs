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
string BildStringArr(int[] arr)
{
    string res = string.Empty;
    res = res + "[";
    for (int i = 0; i < arr.Length - 1; i++)
    {
        res = res + arr[i] + ", ";
    }
    res = res + arr[arr.Length - 1] + "]";
    return res;
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
// Метод вывода сообщения на экран
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Сортировка методом пузырька
void BubbleSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (arr[j] > arr[j + 1])
            {
                // Меняем местами элементы
                int tmp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = tmp;
            }
}


int[] array = new int[8];   // Объявляем массив с определенной длиной
FillMass(array, 1, 100);    // Заполняем массов
int count = GetCount(array);// Объявляем переменную для подсчета и вычисляем её 
PrintResult(BildStringArr(array) + " -> " + count);// Вывод результата на экран
BubbleSort(array);          // Запускаем сортировку
PrintResult(BildStringArr(array) + " -> " + count);// Вывод отсортированного результата на экран