// Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел
// 2, 3, 7 -> 7;
// 44, 5, 78 -> 78;
// 22, 3, 9 -> 22

Console.Write("Введите A:");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);
Console.Write("Введите B:");
string text2 = Console.ReadLine();
int number2 = Convert.ToInt32(text2);
Console.Write("Введите С:");
string text3 = Console.ReadLine();
int number3 = Convert.ToInt32(text3);

if (number1 < number2)
{
    Console.WriteLine("max = В");
}
else
{
    Console.WriteLine("max = A");
}
if (number2 < number3)
{
    Console.WriteLine("max = С");
}
else
{
    Console.WriteLine("max = B");
}
if (number1 < number3)
{
    Console.WriteLine("max = C");
}
else
{
    Console.WriteLine("max = A");
}
