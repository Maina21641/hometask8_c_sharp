// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите через интер два числа, отвечающие за размер двумерного массива");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

void GetArray( int[,] matrix)
{    
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i,j] = new Random().Next(-100, 100);
        }            
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                Console.Write(matrix[i,j] + "  ");
            }
            Console.WriteLine();
        }
}

int Sum(int[,] matrix, int i)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); ++j)
    {
        sum += matrix[i,j];
    }
    return sum;
}

int Min(int[,] matrix)
{
    int min = 0;
    int[] summ = new int[matrix.GetLength(0)]; // первая строка с нулевым индексом

    for (int i = 0; i < summ.GetLength(0); ++i)
        summ[i] = Sum(matrix, i);

    for (int i = 1; i < summ.GetLength(0) - 1; ++i)
        if (summ[min] > summ[i])
           {
            min = i;
           }

    return min;
}

int[,] matrix = new int[m,n];

GetArray(matrix);

Console.WriteLine("\nМассив");
Print(matrix); // первая строка печати массива с нулевым индексом
Console.WriteLine();
Console.WriteLine(Min(matrix)); 
