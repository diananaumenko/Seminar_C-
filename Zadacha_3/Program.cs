// Напишите программу, которая будет выдавать название дня недели по заданному номеру
// 3 -> среда
// 5 -> пятница

Console.Write("Введите номер дня недели: ");
string text = Console.ReadLine();
int numberDayOfWeek = Convert.ToInt32(text);

if (numberDayOfWeek == 1)
{
    Console.WriteLine("Понидельник");
}
if (numberDayOfWeek == 2)
{
    Console.WriteLine("Вторник");
}
if (numberDayOfWeek == 3)
{
    Console.WriteLine("Среда");
}
if (numberDayOfWeek == 4)
{
    Console.WriteLine("Четверг");
}
if (numberDayOfWeek == 5)
{
    Console.WriteLine("Пятница");
}
if (numberDayOfWeek == 6)
{
    Console.WriteLine("Суббота");
}
if (numberDayOfWeek ==7)
{
    Console.WriteLine("Вовкресенье");
}