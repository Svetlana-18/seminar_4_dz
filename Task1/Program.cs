// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите целое положительное число:  ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}

int result = SumNumbers(num);
if (result == 0)
    Console.WriteLine($" Введите число больше нуля");

else Console.WriteLine($" Сумма цифр в числе равна: {result} ");

