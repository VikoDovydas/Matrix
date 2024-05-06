using System;
using System.Threading;

namespace Multithread
{
    internal class MatrixCalculations
    {
        public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rowsA = matrix1.GetLength(0);
            int colsA = matrix1.GetLength(1);
            int rowsB = matrix2.GetLength(0);
            int colsB = matrix2.GetLength(1);

            // Verify that the matrices can be multiplied
            if (colsA != rowsB)
            {
                throw new ArgumentException("Number of columns in the first matrix must equal the number of rows in the second matrix.");
            }

            int[,] resultMatrix = new int[rowsA, colsB];

            // Array to hold threads
            Thread[] threads = new Thread[rowsA * colsB];

            // Perform matrix multiplication using threads
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    int rowIndex = i;
                    int colIndex = j;
                    threads[i * colsB + j] = new Thread(() =>
                    {
                        int sum = 0;
                        for (int k = 0; k < colsA; k++)
                        {
                            sum += matrix1[rowIndex, k] * matrix2[k, colIndex];
                        }
                        resultMatrix[rowIndex, colIndex] = sum;
                    });
                    threads[i * colsB + j].Start();
                }
            }

            // Wait for all threads to complete
            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            return resultMatrix;
        }


        public int Mult(int[,] matrixA, int[,] matrixB, int row, int col)
        {
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum += matrixA[row, k] * matrixB[k, col];
            }
            return sum;
        }

    }

}
