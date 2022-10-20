/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine();
int numberA = int.Parse(number);
int first = numberA / 100;
int second = numberA / 10;
int result = second - first * 10;

Console.WriteLine (result);

