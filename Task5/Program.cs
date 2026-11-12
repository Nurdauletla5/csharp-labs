using System;

class Program
{
    static void Main()
    {
        int nomer = 15;
        int n = 5;
        int[,] matrix = new int[n, n];
        Random rnd = new Random(nomer);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                matrix[i, j] = rnd.Next(-10, 11);

        Console.WriteLine("Матрица:");
        PrintMatrix(matrix);

        int rowNumber, maxSum;
        FindMaxSumRow(matrix, out rowNumber, out maxSum);
        Console.WriteLine($"Қосындысы ең үлкен жолдың нөмірі = {rowNumber}, қосынды = {maxSum}");
    }
    static void FindMaxSumRow(int[,] m, out int rowNumber, out int maxSum)
    {
        // бастапқы мән: бірінші жолдың қосындысы
        maxSum = 0;
        for (int j = 0; j < m.GetLength(1); j++)
            maxSum += m[0, j];
        rowNumber = 1;

        for (int i = 1; i < m.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < m.GetLength(1); j++)
                sum += m[i, j];

            if (sum > maxSum) // қатаң ">" болғандықтан, тең болса бірінші жол қалады
            {
                maxSum = sum;
                rowNumber = i + 1; // нөмір 1-ден басталады
            }
        }
    }

    static void PrintMatrix(int[,] m)

    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                Console.Write($"{m[i, j],4}");
            Console.WriteLine();
        }
    }



}

