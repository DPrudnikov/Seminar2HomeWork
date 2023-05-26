// Напишите программу, которая принимает на вход цифру, обозначающую день недели
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 6)
{
    Console.WriteLine("Выходной");
}
else if (n == 7)
{
    Console.WriteLine("Выходной");
}
else if  (n > 7)
{
    Console.WriteLine("Не существует, повтори попытку ");
}
else
{
    Console.WriteLine("Не выходной");
}
