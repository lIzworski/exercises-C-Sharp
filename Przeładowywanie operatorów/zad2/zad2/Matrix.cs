using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Matrix
    {
        int x, y;
        int[,]matrix;
        
        public Matrix(int x, int y)
        {
            this.x = x;
            this.y = y;
            matrix = new int[x, y];

        }

        public static Matrix operator +(Matrix left, Matrix right)
        {
            Matrix tmp = new Matrix(left.matrix.GetLength(0), left.matrix.GetLength(1));
            for (int i = 0; i < left.matrix.GetLength(0); i++)
            {
                for(int j = 0; j < left.matrix.GetLength(1); j++)
                {
                    int tmpL = left.matrix[i, j];
                    int tmpR = right.matrix[i, j];
                    tmp.matrix[i,j] = tmpL + tmpR;                   
                }
            }
            return tmp;
        }
        public static Matrix operator -(Matrix left, Matrix right)
        {
            Matrix tmp = new Matrix(left.matrix.GetLength(0), left.matrix.GetLength(1));
            for (int i = 0; i < left.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < left.matrix.GetLength(1); j++)
                {
                    int tmpL = left.matrix[i, j];
                    int tmpR = right.matrix[i, j];
                    tmp.matrix[i, j] = tmpL - tmpR;
                }
            }
            return tmp;
        }

        public static Matrix operator *(Matrix left, int number)
        {
            Matrix tmp = new Matrix(left.matrix.GetLength(0), left.matrix.GetLength(1));
            for (int i = 0; i < left.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < left.matrix.GetLength(1); j++)
                {
                    int tmpL = left.matrix[i, j];
                    tmp.matrix[i, j] = tmpL * number;
                }
            }
            return tmp;
        }

        public void FillTheMatrix()
        {
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(0, 10);
                }
            }
        }
        public  void ToString()
        {
             for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }   
        }

    }
}
