/*Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

int[] array = GetArray(10);
int [] newArray = ReverseArray2(array);
PrintArray(newArray);

int[] GetArray(int size)
{
    int [] arr = new int[size];
    for ( int i =0; i< size; i++)
    {
        arr[i] = new Random().Next(1, 10);
        Console.Write($"{arr[i]} ");

    }
    return arr;

}

int[] ReverseArray(int[] arr)
{
    int size = arr.Length;
    int temp = 0;
    for( int i = 0; i< size/2; i++)
    {
        
        temp = arr[i];
        arr[i] = arr[size-1-i];
        arr[size-1-i]= temp;
        

    }
    return arr;
    
}

int[] ReverseArray2(int[]arr)
{ int[]newArr = new int[arr.Length];
    for (int i = 0; i<arr.Length; i++)
    {
   
     newArr[i] = arr[arr.Length-1-i];

}
return newArr;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("\nНаш массив");
    for ( int i = 0; i<arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
    }
}