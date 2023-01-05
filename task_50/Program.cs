//Зфдача 50. Напишите программу, которая на взод принмает позиции элемента в двумерном массиве и возвращает значение этого элемента, или ответ, что такого элемента не существует.

double [,] GetArray ()
{
   int rows = new Random().Next(2,5);
   int colums= new Random().Next(2,5);
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
double [,] resultMatrix=GetArray();
PrintMatrix(resultMatrix);
Console.WriteLine("Введите адрес элемента матрицы:");
string [] inputArray = Console.ReadLine().Split();
int a = Convert.ToInt32(inputArray[0]);
int b = Convert.ToInt32(inputArray[1]);
if (a< resultMatrix.GetLength(0) && b<resultMatrix.GetLength(1))
{
    Console.WriteLine("Искомое число: "+resultMatrix[a,b]);
}
else Console.WriteLine("Нет числа с таким адресом");



