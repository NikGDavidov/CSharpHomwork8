//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void PrintRow (int[,] array,int row)
{
Console.WriteLine("Индекс строки с минимальной суммой элементов - " + row );
int xSize = array.GetLength(0);
for (int i=0; i<xSize; i++) Console.Write (array [i,row] + " ");
Console.WriteLine();
}

int MinSumRowIndex (int [,] array)
{
int minSum = 0;
int index = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sumRow = 0;
        for (int i = 0; i <array.GetLength(0); i++)
        {
            sumRow += array[i,j];
        }
      //  Console.WriteLine(sumRow);
        if (j ==0 ) minSum = sumRow;
        if (sumRow < minSum) {minSum = sumRow; index = j;}

    }
 return index; 
}

int xSize = 5;
int ySize = 4;
int [,] array =  Get2dArray( xSize, ySize, -1000, 1000);
Print2dArray(array);
PrintRow(array,MinSumRowIndex (array));

