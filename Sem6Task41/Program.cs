// ------------------------------------------------------------------------------------------------------------------------------------------------------------
// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// (Задание со звездочкой) Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.
// -----------------------------------------------------------------------------------------------------------------------------------------------------------

// Метод для ввода данных
string ReadData(string msg)
{
    Console.Write(msg);
    string val = Console.ReadLine();
    return val;
}
// Метод вывода сообщения на экран
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int countNumb(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) res +=1;
    }
    return res;
}
int[] StringToIntArr(string val)
{    
    string[] values = val.Split(",");
    int len = values.Length;
    int[] numb = new int[len];
    for (int i = 0; i < len; i++)
    {
        numb[i] = Convert.ToInt32(values[i]);
    }    
    return numb;
}
string str = ReadData("Введите числа через запятую: ");
PrintResult("Вы ввели: " + str + " -> " + countNumb(StringToIntArr(str)).ToString());