//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int GetPowNums(int number, int power)
{
    int powerResult = 1;
    for (int i = 1; i <= power; i++)
    {
        powerResult *= number;
    }
    return powerResult;
}
Console.WriteLine();

Console.WriteLine("Введите натуральное число A: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int numB = int.Parse(Console.ReadLine());

int rezult = GetPowNums(numA, numB);

Console.WriteLine($"Число {numA} в степени {numB} = {rezult}.");
