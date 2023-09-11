Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()??"0");

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(firstNumber == Math.Pow(secondNumber,2)? "Да" : "Нет");