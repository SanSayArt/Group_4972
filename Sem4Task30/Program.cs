// --------------------------------------------------------------------------------------------------------------------
// Задача №30
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// --------------------------------------------------------------------------------------------------------------------

// Метод для ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}
//Заполняем массив генерируемыми числами
int[] GenArr(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i=0; i<len; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}
//Выводим заполненный массив на экран
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i=0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length -1]+"]");
}

int len = ReadData("Введите длину массива: ");
PrintArray(GenArr(len));