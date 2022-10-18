/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
 Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.*/


// f(1) = 1; f(2) = 1; f(n) = f(n-1) + f(n-2)


void Main()
{
    int N = GetNumber();
    double [] fib = Fibonacci(N);
PrintArray(fib);
}
int GetNumber()
{
    Console.WriteLine("Введите число");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
double[] Fibonacci(int n)
{
    double[] arr = new double[n];

    arr[0] = 0;

    for (int i = 1; i < n; i++)
    {
        if (i == 1)
        {
            arr[i] = 1;
        }
        else
        {
            arr[i] = arr[i - 1] + arr[i - 2];

        }

    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.WriteLine("\nНаш массив");
    for ( int i = 0; i<arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
    }
}

Main();
