// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Точка A, введите x=  ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Точка A, введите y=  ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Точка A, введите z=  ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Точка B, введите x=  ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Точка B, введите y=  ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Точка B, введите z=  ");
double zB = Convert.ToDouble(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow((xB-xA), 2) + Math.Pow((yB-yA), 2) + Math.Pow((zB-zA), 2));
dist = Math.Round(dist, 2);
Console.WriteLine($"длинна между точками А и В = {dist}");