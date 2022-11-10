//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
string InputNumber()
{
    Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
if (int.Parse(num[0].ToString()) == 0)
Console.WriteLine($"Неподходящее значение!");
return num;
}

int SumDigitalsOfNumber(string num)
{
   int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        sum = sum + int.Parse(num[i].ToString());
    }
    Console.WriteLine($"Сумма цифр в чиселе {num} = {sum}"); 
    return sum;
}
SumDigitalsOfNumber(InputNumber());