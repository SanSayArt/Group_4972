// Console.Write("Введите номер дня недели: ");
// int day = int.Parse(Console.ReadLine()??"0");
// string[] dayOfWeek = new string[7];
// dayOfWeek[0] = "Понедельник";
// dayOfWeek[1] = "Вторник";
// dayOfWeek[2] = "Среда";
// dayOfWeek[3] = "Четверг";
// dayOfWeek[4] = "Пятница";
// dayOfWeek[5] = "Суббота";
// dayOfWeek[6] = "Воскресенье";
// if (day < 7) Console.WriteLine(dayOfWeek[day-1]);
// else Console.WriteLine("Неверный номер дня недели.");


Console.Write("Введите номер дня недели (выборка из системы): ");
int day = int.Parse(Console.ReadLine()??"0");
string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));

Console.WriteLine(outDayOfWeek);