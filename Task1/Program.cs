
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int [,] Get2dArray(int xSize, int ySize, int from, int to)
{
    int[,] result = new int[xSize, ySize];
    for (int j = 0; j < ySize; j++)
    {
        for (int i = 0; i < xSize; i++)
        {
            result[i, j] =new Random().Next(from,to);
        }
    }
    return result;
}
void Print2dArray(int [,]array)
{
    int xSize = array.GetLength(0);
    int ySize = array.GetLength(1);
   
for (int j = 0; j < ySize; j++)
    {
        Console.WriteLine();
        for (int i = 0; i < xSize; i++)
        {
           Console.Write(array[i,j] + " ");
        }
    }
    Console.WriteLine();
   
}

 int [,] Sorted2dArray (int[,]array)
 {
    int xSize = array.GetLength(0);
    int ySize = array.GetLength(1);
  
    for (int j = 0; j < ySize; j++)
    {
        for (int i = 0; i < xSize; i++)
        {
            int max = array [i,j];
            int indexMax = i;
            for (int k = i + 1; k < xSize; k++)
            {
        
                if (array [k,j] > max) { max = array[k,j]; indexMax = k;}
            }
            (array[i,j],array[indexMax,j]) = (array[indexMax,j], array[i,j]);
        }
    }
    return array;
 }
int xSize = 5;
int ySize = 4;
int [,] array =  Get2dArray( xSize, ySize, 10, 100);
Print2dArray (array);
array = Sorted2dArray(array);
Print2dArray(array);
