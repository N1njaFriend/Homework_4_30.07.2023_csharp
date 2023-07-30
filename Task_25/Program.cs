// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int numberA;
bool isNumberAParsed = int.TryParse(Console.ReadLine(), out numberA);

Console.Write("Введите степень: ");
int numberB;
bool isNumberBParsed = int.TryParse(Console.ReadLine(), out numberB);

if (isNumberAParsed && isNumberBParsed)
{
    void ToDegree(int a, int b)
    {
        int result = 1;
        for (int i = 1; i <= b; i++)
        {
            result *= a;
        }
        Console.WriteLine(a + " в степени " + b + " = " + result);
    }

    ToDegree(numberA, numberB);
}
else
{
    Console.WriteLine("Введите числа!");
}