// решение задачи в рамках одной недели
int[] array = Enumerable.Range(0, 8).ToArray();
Console.WriteLine("Итак в неделе семь дней, первый день - понедельник.");
Console.WriteLine($"Какой по счету день проверяем?");
int b = Convert.ToInt32(Console.ReadLine());

if (((array[b] % 7) == 0) || ((array[b] % 6) == 0))
{
    Console.WriteLine($"УРА, ВЫХОДНОЙ, МОЖЕМ ОТДЫХАТЬ!");
}
else
{
    Console.WriteLine($"Рабочий день, идем работать!(");
}