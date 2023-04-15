// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
// a = 25; b = 5 -> да
// a = 2; b = 10 -> нет 
// a = 9; b = -3 -> да
// a = -3; b = 9 -> нет

Console.Write("Введите А: ");
string text1 = Console.ReadLine();
int numder1 = Convert.ToInt32(text1);
Console.Write("Введите В: ");
string text2 = Console.ReadLine();
int numder2 = Convert.ToInt32(text2);

if (numder2 * numder2 == numder1)
{
    Console.WriteLine("A является квадратом В");
}
else
{
    Console.WriteLine("A не является квадратом В");
}
