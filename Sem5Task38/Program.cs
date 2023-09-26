// -------------------------------------------------------------------------------------------------------------------------------
// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// (со звездочкой) Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и последним элементом. 
// Для задачи со звездочкой использовать заполнение массива целыми числами.
// -------------------------------------------------------------------------------------------------------------------------------


void FillMass(double[] arr, int lowBorder, int maxBorder)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(lowBorder, maxBorder + 1) + Math.Round(rnd.NextDouble(),2);
    }
}
// Метод вывода массива на экран
string BildStringArr(double[] arr)
{
    string res = string.Empty;
    res = res + "[";
    for (int i = 0; i < arr.Length - 1; i++)
    {
        res = res + arr[i] + "; ";
    }
    res = res + arr[arr.Length - 1] + "]";
    return res;
}

// Метод подсчета чисел в массиве
double GetDelta(double[] arr)
{
    double res = 0;
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
        if (min > arr[i]) min = arr[i];
    }
    res = max - min;
    return res;
}
// Метод вывода сообщения на экран
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

double[] array = new double[8];       // Объявляем массив с определенной длиной
FillMass(array, 1, 100);        // Заполняем массов
double delta = GetDelta(array);       // Объявляем переменную для суммы и вычисляем её
PrintResult(BildStringArr(array) + " -> " + delta);// Вывод результата на экран