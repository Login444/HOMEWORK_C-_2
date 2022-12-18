Console.WriteLine("Введите трёхзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Найдем вторую цифру Вашего числа:");

int b = (num1%100)/10;

Console.WriteLine($"{b}");