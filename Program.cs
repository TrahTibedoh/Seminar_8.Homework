//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] Array2dRandom()
{ 
        Console.WriteLine("Введите количество строк масива: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столюцов: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите минимальное число масива: ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите максимальное число масива: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, columns];
       
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }

        return array;
}
void SortToRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
 
int[,] newArray = Array2dRandom();
Console.WriteLine("Исходный масив");
ShowArray(newArray);
Console.WriteLine();
Console.WriteLine("Измененный масив");
SortToRows(newArray);
ShowArray(newArray);
*/

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] Array2dRandom()
{ 
        Console.WriteLine("Введите количество строк масива: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столюцов: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите минимальное число масива: ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите максимальное число масива: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, columns];
       
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }

        return array;
}

int[] RowsSum(int[,] array)
{
    int[] minSum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    
        for (int j = 0; j < array.GetLength(1); j++)
            minSum[i] = minSum[i] + array[i, j];
    return minSum;        
}

int GetMinSumNumber(int[] array)
{
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
        if (array[minIndex] > array[i]) minIndex = i;
    return minIndex + 1;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] newArray = Array2dRandom();
ShowArray(newArray);
Console.WriteLine($"Строка с минимальной суммой = {GetMinSumNumber(RowsSum(newArray))}");
*/



//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] ArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 3); 
        }
    }

    return array;
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int size = InputInt("Размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
ArrayRandom(matrixA);
ArrayRandom(matrixB);
int[,] matrixC = new int[size, size];
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        
        Console.WriteLine("");
    }
}

Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray(matrixC);
*/

//.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*

int[,,] Array3dRandom()
{
    Console.WriteLine("Input to rows:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input to columns: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input to laers: ");
    int layers = Convert.ToInt32(Console.ReadLine());

    int[,,] array = new int[rows, column, layers];

    for(int i = 0; i < array.GetLength(0); i++)
    {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    int num;
                    do
                    {
                         num = new Random().Next(10, 100);
                    }
                    while (array.Cast<int>().Contains(num));
                    array[i, j, k] = num;                              
                }
            }
        }
    return array;
}

void ShowArrayIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

int[,,] newArray = Array3dRandom();
ShowArrayIndex(newArray);
*/

//Напишите программу, которая заполнит спирально массив axb
/*
int[,] Array2d()
{ 
        Console.WriteLine("Введите количество строк масива: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столюцов: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, columns];
           
        int counter = 1;
        int startRow = 0, endRow = array.GetLength(0) - 1;
        int startCol = 0, endCol = array.GetLength(1) - 1;
        while (counter <= array.Length)
        {
            
            for (int i = startCol; i <= endCol; i++)
                {
                    array[startRow, i] = counter++;
                }
                    startRow++;
            for (int i = startRow; i <= endRow; i++)
                {
                    array[i, endCol] = counter++;
                }
                    endCol--;
            for (int i = endCol; i >= startCol; i--)
                {
                    array[endRow, i] = counter++;
                }
                    endRow--;
            for (int i = endRow; i >= startRow; i--)
                {
                    array[i, startCol] = counter++;
                }
                    startCol++;
        }
        return array;
                
        
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    
    Console.WriteLine("");
    }
}

int[,] newArray = Array2d();
ShowArray(newArray);

*/