// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10*/

void Main()
{
    int a = GetNumber();
    int b = GetNumber();
    int c = GetNumber();
CheckForTriangle(a, b, c);
}
int GetNumber()
{
    Console.WriteLine("Введите число");
    int num = int.Parse(Console.ReadLine()!);
    return num;
    }

void CheckForTriangle(int a, int b, int c)
    
    {
        if(a<(b+c)&&b<(c+a) && c< (a+b))
        {
            Console.WriteLine("Может");
        }
        else
        {
            Console.WriteLine("Не может");
        }
    }

Main();
