using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    //766. Toeplitz Matrix 
    //Easy

    //Given an m x n matrix, return true if the matrix is Toeplitz.Otherwise, return false.

    //A matrix is Toeplitz if every diagonal from top-left to bottom-right has the same elements.
    public class Toeplitz_Matrix
    {
        //Input: matrix = [[1,2,3,4],
        //                 [5,1,2,3],
        //                 [9,5,1,2]]
        //Output: true
        //Explanation:
        //            In the above grid, the diagonals are:
        //"[9]", "[5, 5]", "[1, 1, 1]", "[2, 2, 2]", "[3, 3]", "[4]".
        //In each diagonal all elements are the same, so the answer is True.
        public static bool IsToeplitzMatrix(int[][] matrix)
        {
            var flag = true;
            for (var i = 0; i < matrix.Length - 1; i++)
            {
                //Console.WriteLine($"$ : {i}");
                //Console.WriteLine($"matrix[i][0] : {matrix[i][0]}");
                //if (matrix.Length > i+1 && matrix[i].Length > 1)
                //{
                //  Console.WriteLine($"matrix[i + 1][1] : {matrix[i + 1][1]}");
                //}
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    //Console.WriteLine($"matrix[i][j] : {matrix[i][j]}");
                    //if (matrix[i].Length > j + 1) {
                    //  Console.WriteLine($"matrix[i + 1][j + 1] : {matrix[i + 1][j + 1]}");
                    //}
                    if (matrix[i].Length > j + 1 && !Equals(matrix[i][j], matrix[i + 1][j + 1]))
                    {
                        return false;
                    }
                }
            }
            return flag;
        }
    }
}
