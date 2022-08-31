// напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N(4->24;5->120)
int ProdNumbers(int number)
{
    int result = 1;
    for(int i = 1; i <= number; i = i + 1)
    {
        result = result * i;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {num} = {ProdNumbers(num)}");