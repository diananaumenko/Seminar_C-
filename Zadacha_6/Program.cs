// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);

if (number % 2 == 0)
{
    Console.WriteLine("Делится без остатка,число четное");
}
else
{
    Console.WriteLine("Делится с остатком, число не четное");
}