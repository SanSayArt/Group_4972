Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()??"0");

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine()??"0");

Console.Write("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine()??"0");

if (firstNumber > secondNumber && firstNumber > thirdNumber)
    Console.WriteLine("Первое число максимальное");
if (secondNumber > firstNumber && secondNumber > thirdNumber)
    Console.WriteLine("Второе число максимальное");
if (thirdNumber > firstNumber && thirdNumber > secondNumber)
    Console.WriteLine("Третье число максимальное");

