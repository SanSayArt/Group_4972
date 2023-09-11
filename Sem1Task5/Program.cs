Console.Write("Введите число: ");
int numN = int.Parse(Console.ReadLine()??"0");
int enumN = (-1) * numN;
while (enumN < numN)
{
    Console.Write(enumN + ", ");
    enumN = enumN + 1;
}
Console.WriteLine(numN);