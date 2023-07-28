/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/


Console.WriteLine("Введите 1 координату: ");
int ax = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 координату: ");
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3 координату: ");
int az = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 4 координату: ");
int bx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 5 координату: ");
int by = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 6 координату: ");
int bz = int.Parse(Console.ReadLine());

double res = Math.Sqrt( Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2) + Math.Pow((az - bz), 2));
Console.WriteLine($"{res:f2}");




