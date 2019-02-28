using System;
using System.Threading.Tasks;

namespace MultiThreading.Task3
{
    public class Program
    {
        private const int MatrixSize = 9;

        public static void Main(string[] args)
        {
            var firstMatrix = CreateMatrix();
            PrintMatrixInConsole(firstMatrix);

            var secondMatrix = CreateMatrix();
            PrintMatrixInConsole(secondMatrix);

            var resultMatrix = SumMatrix(firstMatrix, secondMatrix);
            PrintMatrixInConsole(resultMatrix);

            Console.ReadLine();
        }

        private static int[,] SumMatrix(int[,] firstMatrix, int[,] secondMatrix)
        {
            var resultMatrix = new int[MatrixSize, MatrixSize];
            Parallel.For(0, MatrixSize, (x) =>
            {
                Parallel.For(0, MatrixSize, (y) =>
                {
                    resultMatrix[x, y] = firstMatrix[x, y] + secondMatrix[x, y];
                });
            });

            return resultMatrix;
        }

        private static void PrintMatrixInConsole(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col].ToString().Length == 1 ? "  " : " ");
                    Console.Write(matrix[row, col].ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static int[,] CreateMatrix()
        {
            var random = new Random();
            var matrix = new int[MatrixSize, MatrixSize];

            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            return matrix;
        }
    }
}

