// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


Console.WriteLine("Введите размер массива:  ");
int lenght = Convert.ToInt32(Console.ReadLine());

if (lenght == 0 || lenght < 0)
{
    Console.Write("Вы ввели недопустимое значение");
    return;
}

int[] RandArray(int len)
{
    int[] arrays = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < arrays.Length - 1; i++)
    {
        arrays[i] = rnd.Next(0, 100);
        Console.Write($"{arrays[i]}, ");

    }
    Console.Write($"{arrays[arrays.Length - 1]}");
    return arrays;
}
int[] res = RandArray(lenght);


void PrintArray(int[] res1)
{
    Console.Write(" -> [");
    for (int i = 0; i < res1.Length - 1; i++)
    {
        Console.Write($"{res1[i]}, ");

    }
    Console.Write($"{res1[res1.Length - 1]}]");
}

PrintArray(res);

