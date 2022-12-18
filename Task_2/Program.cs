Console.WriteLine("Введите число: ");
string a = Convert.ToString(Console.ReadLine());
int i = Convert.ToInt32(a.Length);
if (i > 2)
{
    Console.WriteLine($"Третья цифра: {a[2]}");
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}