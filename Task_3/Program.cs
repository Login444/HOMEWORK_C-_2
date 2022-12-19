// решение задачи в рамках одной недели
int[] array = {0, 1, 2, 3, 4, 5, 6, 7};
// Console.WriteLine(string.Join(",", array));
Console.WriteLine($"Какой день проверяем?");
int b = Convert.ToInt32(Console.ReadLine());

if (((array[b] % 7) == 0) || ((array[b] % 6) == 0))
{
    Console.WriteLine($"УРА, ВЫХОДНОЙ, МОЖЕМ ОТДЫХАТЬ!");
}
else
{
    Console.WriteLine($"Рабочий день, идем работать!(");
}