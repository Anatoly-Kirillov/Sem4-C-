// Напишите программу, которая вводит массив из 8 элементов, заполненный нулями и единицами 
// в случайном порядке[1,0,1,1,0,1,0,0]
int[] AddArray(int[] array)
{
    var random = new Random();
    for(int i = 0; i < array.Length; i = i + 1)
    {
        array[i] = random.Next(0, 2);
    }
    return array;
}
int[] arr = new int[8];
int[] newArray = AddArray(arr);
Console.WriteLine($"[{String.Join(", ", newArray)}]");