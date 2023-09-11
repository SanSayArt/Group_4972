Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()??"0");

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine()??"0");

if (firstNumber > secondNumber) Console.WriteLine("Первое число больше второго.");
else if (firstNumber == secondNumber) Console.WriteLine("Введенные числа одинаковые.");
else Console.WriteLine("Второе число больше первого.");