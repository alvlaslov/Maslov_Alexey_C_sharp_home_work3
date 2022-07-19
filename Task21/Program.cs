// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Insert A[x]");
int numberAx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert A[y]");
int numberAy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert A[z]");
int numberAz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert B[x]");
int numberBx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert B[y]");
int numberBy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert B[z]");
int numberBz = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt((Math.Pow(numberAx - numberBx, 2) + Math.Pow(numberAy - numberBy, 2) + Math.Pow(numberAz - numberBz, 2)));

Console.WriteLine(Math.Truncate(100 * S) / 100);