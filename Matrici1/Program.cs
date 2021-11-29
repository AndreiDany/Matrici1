using System;

namespace Matrici1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul de linii!");

            int n = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            bool esteIdentitate = true;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"[{row},{col}]:");
                    matrix[row, col] = Int32.Parse(Console.ReadLine());

                    if (row != col)
                    {
                        if (matrix[row, col] != 0)
                        {
                            esteIdentitate = false; 
                        }
                    }
                    else if (matrix[row, col] != 1)
                    {
                        esteIdentitate = false; 
                    }
                }
            }
            if (esteIdentitate == true)
                Console.WriteLine("Este matrice identitate!");
            else
                Console.WriteLine("Nu este matrice identitate");
        }
    }
}
