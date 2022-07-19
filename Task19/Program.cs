// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

Console.WriteLine("Insert a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number) < 10000 || Math.Abs(number) > 99999)
{
    Console.WriteLine("The number does not match the condition");
}

else 
{
    int digital1 = number / 10000 % 10;
    int digital2 = number / 1000 % 10;
    int digital4 = number / 10 % 10;
    int digital5 = number % 10;

    if (digital1 == digital5 && digital2 == digital4)
    {
        Console.WriteLine($"The number {number} is a palindrome");
    }

    else
    {
        Console.WriteLine($"The number {number} is'not a palindrome");
    }
}