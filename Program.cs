using System;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main()
        {
            int M;
            Console.Write("Введите: ");
            M = Convert.ToInt32(Console.ReadLine());
            var a = GetSpire(M);
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    a[i, j] = 1 - (i + j) % 2;
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static int[,] GetSpire(int M)
        {
            var result = new int[M, M];
            for (int currentChar = 1, padding = 0; padding < M / 2; padding++)
            {
                for (int j = padding; j < M - padding; j++)
                    result[padding, j] = currentChar;
                for (int j = padding; j < M - padding; j++)
                    result[M - padding - 1, j] = currentChar;
                for (int i = padding + 2; i < M - padding - 1; i++)
                    result[i, padding] = currentChar;
                for (int i = padding + 1; i < M - padding - 1; i++)
                    result[i, M - padding - 1] = currentChar;
                currentChar = 1 - currentChar;
                result[padding + 1, padding] = currentChar;
            }
            return result;
        }
    }
}