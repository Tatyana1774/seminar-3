﻿/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число ");
string? n = Console.ReadLine();
int N = n.Length;
if(N==5)
{
if (n[0] == n[4] && n[1] == n[3])
{
Console.WriteLine($"{n} - Палиндром");
}
else
{
Console.WriteLine($"{n} - НЕ палиндром");
}
}
else
{
Console.WriteLine($"ОШИБКА: {n} - не является пятизначным");
}