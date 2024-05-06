using System;

namespace Multithread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NOTE: Matrix multiplication is only valid if \n" +
                  "the number of columns of the first matrix are equal to the number of rows of the second matrix");

            int[,] matrix1 = null;
            int[,] matrix2 = null;

            while (true)
            {               
                Console.WriteLine("\nChoose the operation:");
                Console.WriteLine("1. Input new matrices");
                Console.WriteLine("2. Multiplication");
                Console.WriteLine("3. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Input Matrix A:");
                        matrix1 = MatrixInput.InputMatrix();
                        Console.WriteLine("Input Matrix B:");
                        matrix2 = MatrixInput.InputMatrix();
                        break;
                    case 2:
                        if (matrix1 == null || matrix2 == null)
                        {
                            Console.WriteLine("You forgot to enter matrices");
                            break;
                        }
                        Console.WriteLine("\nResult Matrix (Multiplication):");
                        MatrixPrint.PrintMatrix(MatrixCalculations.MultiplyMatrices(matrix1, matrix2));
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
