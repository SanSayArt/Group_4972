Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()??"0");
if (num > 99 && num < 1000)
{
    int lastDig = num%10;
    Console.WriteLine("Последняя цифра числа " + num + " это: "+ lastDig);
}
else
{
    Console.WriteLine("Число не трехзначное");
}