//Задача 47 задайте двумерный массив размером мхн, заполненный вещественными числами
double [,] GetArray (int rows,int colums)
{
   double [,] matrix = new double [rows,colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix [i,j]= Math.Round(new Random().NextDouble()*100,2);
        }
    }
    return matrix;
}


void PrintMatrix (double[,] matrix)
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
Console.WriteLine("Введите число строк:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
double [,] resultMatrix=GetArray(m,n);

PrintMatrix(resultMatrix);