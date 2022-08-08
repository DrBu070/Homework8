Console.WriteLine("Задача 56 ");
Console.WriteLine(".......................................................... ");
Console.WriteLine();

Console.WriteLine("Введите размер квадратного массива: ");// Желательно 7)
int massVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[massVol, massVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("╔===================╗");
PrintArray(numbers);
int minsum = Int32.MaxValue;
int indexLine = 0;


for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}
Console.WriteLine("╚===================╝");
Console.WriteLine("==> Наименьшая сумма элементов " + (minsum) + ", В " + (indexLine) + " строке");

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("║ [ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("] ║");
        Console.WriteLine("");
    }
}