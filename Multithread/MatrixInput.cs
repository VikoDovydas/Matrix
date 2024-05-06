using System;

namespace Multithread
{
    internal class MatrixInput
    {
        public static int[,] InputMatrix()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            //example matrix
            Console.WriteLine("");
            Console.WriteLine($"Example Matrix ({rows}x{cols}):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"A{(i + 1)}{(j + 1)} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine($"Enter the values for the {rows}x{cols} matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter value for element [A{(i + 1)}{(j + 1)}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("");
            return matrix;
        }
    }
}
