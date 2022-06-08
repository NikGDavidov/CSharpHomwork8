// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
string flag ="true";
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

int [,] MatrixMultiply(int [,] array1, int [,]array2)
{
    int m = array1.GetLength(0);
    int n = array1.GetLength(1);
    int q = array2.GetLength(0);
    int r = array2.GetLength(1);

if (!(m==r)) {flag = "Произведние данных матриц невозможно."; return array1;}
    int [,] result = new int [q,n]; 
 for (int j=0; j<n ; j++)
 {
     for (int i = 0 ; i<q; i++)
     {
         int sum = 0;
        for (int k = 0 ; k < m; k++)
        {
            sum += array1[k,j] * array2 [i,k];
        }
        result [i,j]= sum;
     }
 }
    return result;
}
int xSize1 = 2;
int ySize1 = 3;
int xSize2 = 3;
int ySize2 = 2;
int [,] array1 = Get2dArray( xSize1, ySize1, 1, 5);
int [,] array2 = Get2dArray( xSize2, ySize2, 1, 5);
Print2dArray(array1);
Print2dArray(array2);
int [,] result = MatrixMultiply (array1, array2);
if (flag=="true") Print2dArray (result);
else Console.WriteLine(flag);