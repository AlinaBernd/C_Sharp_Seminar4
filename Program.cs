// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int Power(int num, int n)
{
    int res = num;
    for (int i = 1; i < n; i++)
    {
        res *= num;
    }
    return res;
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a power: ");
int pow = Convert.ToInt32(Console.ReadLine());
int res = Power(number, pow);
Console.WriteLine("Result: " + res);
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }
        return sum;
    }
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = CalculateSumOfDigits(num);
Console.WriteLine("Calculate sum of digits: " + sum);