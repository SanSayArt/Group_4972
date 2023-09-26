// -------------------------------------------------------------------------------------------------------------------------------
// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// (со звездочкой) Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и последним элементом. 
// Для задачи со звездочкой использовать заполнение массива целыми числами.
// -------------------------------------------------------------------------------------------------------------------------------

// Метод заполнения массива вещественными числами
void FillMass(double[] arr, int lowBorder, int maxBorder)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(lowBorder, maxBorder + 1) + Math.Round(rnd.NextDouble(),2);
    }
}

// Метод заполнения массива целыми числами
void FillMassInt(int[] arr, int lowBorder, int maxBorder)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(lowBorder, maxBorder + 1);
    }
}

// Метод составления строки из массива
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
// Метод составления строки из массива
string BildStringArrInt(int[] arr)
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
    return Math.Round(res,2);
}
// Метод вывода сообщения на экран
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Сортировка массива вставками
void InsertSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int temp = arr[i];
        int j = i - 1;

        // Поиск места для числа в левой части
        while (j >= 0 && arr[j] > temp)
        {
            arr[j + 1] = arr[j];
            arr[j] = temp;
            j--;
        }
    }
}

// Обратная сортировка массива подсчетом для произвольного целочисленного диапазона
void CountingSort(int[] arr)
{
    // Поиск минимального и максимального значений в массиве
    int min = arr[0];
    int max = arr[0];
    foreach (int element in arr)
    {
        if (element > max) { max = element; }
        else if (element < min) { min = element; }
    }

    // Поскольку индекс массива не может быть отрицательным, то приведем минимальное значение диапазона к нулю
    int correctionFactor = min != 0 ? -min : 0;
    max += correctionFactor;

    // Создание массива, в котором считаем количество вхождений каждого элемента исходного массива
    int[] count = new int[max + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        count[arr[i] + correctionFactor]++;
    }

    // Исходя из данных полученных в предыдущем шаге, формируем отсортированный массив
    int index = 0;
    for (int i = count.Length - 1; i >= 0; i--)
    {
        for (int j = 0; j < count[i]; j++)
        {
            arr[index] = i - correctionFactor;
            index++;
        }
    }
}

double[] array = new double[8];       // Объявляем массив с определенной длиной
FillMass(array, 1, 100);        // Заполняем массив
double delta = GetDelta(array);       // Объявляем переменную для суммы и вычисляем её
PrintResult(BildStringArr(array) + " -> " + delta);// Вывод результата на экран

int[] arr = new int[8];       // Объявляем массив с определенной длиной
FillMassInt(arr, 1, 100);        // Заполняем массив целыми числами
InsertSort(arr);                  // Сортироуем методом вставки
PrintResult("Массив после сортировки методом вставки: ");
PrintResult(BildStringArrInt(arr));// Вывод результата на экран
CountingSort(arr);
PrintResult("Массив после обратной сортировки методом вставки: ");
PrintResult(BildStringArrInt(arr));// Вывод результата на экран
