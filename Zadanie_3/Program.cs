//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.(в примере показаны два разных массива, создаем именно для 8 элементов)
void GetArray(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 20);
        Console.Write($" {arr[i]};");
    }
    Console.WriteLine();
}

void PrintArray(int[] arr)
{
    Console.Write($"[");
    int size = arr.Length;
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
    Console.Write($"{arr[size - 1]}]");
    Console.WriteLine();
}

int[] arr = new int[8];
GetArray(arr);
PrintArray(arr);