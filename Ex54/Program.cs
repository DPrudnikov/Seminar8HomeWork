// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] newarray = new int[4, 4];

CreatFillArray();
PrintArray();
Console.WriteLine("________________");
ModernArray();
PrintArray();

void ModernArray()
{
     
     for (int i = 0; i < newarray.GetLength(0); i++)
    {
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            
           for (int k = 0; k < newarray.GetLength(1)-1; k++)
           {
            if (newarray[i,k] < newarray[i,k+1])
            {
                int temp = newarray[i,k+1];
                newarray[i, k+1] = newarray[i,k];
                newarray[i, k] = temp;
            }
           }
            
        }
    }Console.WriteLine();
    
}

void CreatFillArray()
{
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            newarray[i, j] = new Random().Next(0, 10);
        }
    }

}

void PrintArray()
{
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            Console.Write(newarray[i, j] + " | ");
        }
        Console.WriteLine();
    }
        
}