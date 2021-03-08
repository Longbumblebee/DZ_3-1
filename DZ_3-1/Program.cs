using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[6, 6];
            matrix[0, 0] = 9;
            matrix[1, 1] = 1;
            matrix[2, 2] = 2;
            matrix[3, 3] = 3;
            matrix[4, 4] = 4;
            matrix[5, 5] = 5;


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write($"{matrix[i, j]} ");
                }
                System.Console.WriteLine();
            }





        }
    }
}
