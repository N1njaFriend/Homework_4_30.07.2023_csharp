// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number;
        bool isNumberParsed = int.TryParse(Console.ReadLine(), out number);
        int sumOfDigits = 0;

        if (isNumberParsed)
        {           
            while (number > 0)
            {
                int digit = number % 10;
                sumOfDigits += digit;
                number /= 10;
            }

            Console.WriteLine("Сумма цифр в числе: " + sumOfDigits);
        }
        else
        {
            Console.WriteLine("Введите цифры!");
        }
    }
}