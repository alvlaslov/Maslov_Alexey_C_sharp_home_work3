// Задача 23. Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Insert a number from 1");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
    Console.WriteLine($"The number {number} does not match the condition");
}
else
{
    int startnumber = 1;
    while (startnumber <= number)
    {
        Console.WriteLine($"{startnumber}^3 = {Math.Pow(startnumber, 3)}");
        startnumber++;
    }
}
