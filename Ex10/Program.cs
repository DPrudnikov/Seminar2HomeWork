// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456->5
// 918->1

Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int num = 0;
num = ((n % 100) - (n % 10)) / 10;
Console.WriteLine(num);
Console.WriteLine("End");
