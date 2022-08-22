// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите целое положительное число 1:  ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число 2:  ");
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1 == 0) Console.WriteLine("ответ равен 0 ");
else if (num1 == 0 && num2 == 0) Console.WriteLine("ответ равен 1");
else if (num1 > 0 && num2 > 0)
{
    int DegryNum(int number1, int number2)
    {
        int result = 1;
        for (int i = 1; i <= number2; i++)
        {
            result = result * number1;
        }
        return result;
    }

    int exponentiation = DegryNum(num1, num2);
    Console.WriteLine($"Ответ:   {exponentiation} ");
}
else Console.WriteLine("введите положительные числа");