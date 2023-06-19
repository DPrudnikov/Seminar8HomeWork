// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.

int[,] array = new int[4, 4];

CreatFillArray();
PrintArray();
Console.WriteLine("_______________");
MinSumRowArray();



void CreatFillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }
        Console.WriteLine();
    }
}
void MinSumRowArray()
{
    int minsum = int.MaxValue;
    int newindex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        //Console.WriteLine(sum);
        if (sum < minsum)
        {
            minsum = sum;
            newindex = i;
        }
    }
    Console.WriteLine("Сумма - " + minsum);
    Console.WriteLine("Строка: " + newindex);


}