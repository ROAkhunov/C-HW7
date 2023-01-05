//Задайте двумрный массив из целых чисел. Найдите среднее арифметическое из элементов в каждом столбце.
int [,] GetArray ()
{
    int rows = new Random().Next(2,5);
   int colums= new Random().Next(2,5);
    int [,] matrix = new int [rows,colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix [i,j]= new Random().Next(0,10);
        }
    }
    return matrix;
}


void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j<matrix.GetLength(1); j++)
        {
           Console.Write(matrix[i,j]+"  "); 
        }
        Console.WriteLine();
    }

}
double [] GetAverege(int [,] inputMatrix)
{
   int rows= inputMatrix.GetLength(0);
   int colums = inputMatrix.GetLength(1);
   double [] array = new double [inputMatrix.GetLength(1)];
   double sum = 0;
    for (int i = 0; i < colums; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            sum+= inputMatrix [j,i];   
        }
        array[i]=Math.Round(sum/rows,2);
        sum = 0;
    }
    return array;
}
int [,] resultMatrix=GetArray();
PrintMatrix(resultMatrix);
double [] arrayAverege = GetAverege(resultMatrix);
Console.WriteLine($"Среднее столбцов матрицы соответственно равно: {String.Join(" ",arrayAverege)}");