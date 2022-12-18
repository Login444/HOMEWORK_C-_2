Console.WriteLine("Введите трёхзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int b = (num1%100)/10;
Console.WriteLine($"Вторая цифра - {b}");