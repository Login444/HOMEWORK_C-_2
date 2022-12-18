Console.WriteLine("Введите трёхзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int b = (num1 % 100) / 10;
Console.WriteLine($"Вторая цифра - {b}");

Console.WriteLine($"Второй вариант решения:");
Console.WriteLine($"Введите Ваше число: ");

string num2 = Convert.ToString(Console.ReadLine());

Console.WriteLine($"Вот Ваша вторая цифра: {num2[1]}");

