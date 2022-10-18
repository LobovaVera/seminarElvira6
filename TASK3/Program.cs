//45 -> 101101
/*3  -> 11
2  -> 10*/

void Main()
{
    int a = GetNumber();
    ChangeToBinary(a);

}

int GetNumber()
{
    Console.WriteLine("Введите число");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void ChangeToBinary(int number)
{
    
    int SIZE = 0;
    int tempNumber = number;
    for (int j = 0; tempNumber > 0; j++)
    {
        tempNumber = tempNumber / 2;
        SIZE = j;

    }

    int[] arr = new int[SIZE + 1];
    //Console.Write($" SIZE+1 = {SIZE + 1} ");

    for (int i = 0; number > 0; i++)
    {
        arr[SIZE - i] = number % 2;
      
        number = number / 2;

    }

    Console.WriteLine("\nНаше число = ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
    }
}
Main();