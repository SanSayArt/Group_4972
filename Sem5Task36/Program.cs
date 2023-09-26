// -------------------------------------------------------------------------------------------------------------------------------
// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// (со звездочкой) Найдите все пары в массиве и выведите пользователю
// -------------------------------------------------------------------------------------------------------------------------------

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

// Метод подсчета чисел в массиве
int GetSumm(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
            res += arr[i];
    }
    return res;
}
// Метод вывода сообщения на экран
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
//Метод  нахождения пары в массиве и вывода на экран
void FindDubl(int[] arr)
{
    int numb = 0;
    for (int x = 0; x < arr.Length; x++)
    {
        numb = arr[x];
        for (int y = x + 1; y < arr.Length; y++)
        {
            if (numb == arr[y])
                PrintResult($"Найдены пара чисел {numb} и {arr[y]}");
        }
    }
}

int[] array = new int[15];       // Объявляем массив с определенной длиной
FillMass(array, 1, 100);        // Заполняем массов
int sum = GetSumm(array);       // Объявляем переменную для суммы и вычисляем её
PrintResult(BildStringArr(array) + " -> " + sum);// Вывод результата на экран
FindDubl(array);                // Запускаем поиск пар чисел