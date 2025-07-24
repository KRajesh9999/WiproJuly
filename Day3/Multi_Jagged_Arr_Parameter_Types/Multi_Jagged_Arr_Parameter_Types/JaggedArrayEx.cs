using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Jagged_Arr_Parameter_Types
{
    internal class JaggedArrayEx
    {
        static void Main()
        {
            int[][] jaggedArray = new int[2][];

            int[] x = new int[] { 1, 2, 3, 4 };
            int[] y = new int[] { 5, 6, 7, 8 };

            jaggedArray[0] = x;
            jaggedArray[1] = y;

            //Console.WriteLine(jaggedArray[0][0]);
            //Console.WriteLine(jaggedArray[0][1]);
            //Console.WriteLine(jaggedArray[0][2]);
            //Console.WriteLine(jaggedArray[0][3]);


            //Console.WriteLine(jaggedArray[1][0]);
            //Console.WriteLine(jaggedArray[1][1]);
            //Console.WriteLine(jaggedArray[1][2]);
            //Console.WriteLine(jaggedArray[0][3]);

            for (int i = 0; i <= jaggedArray.Length + 1; i++)
            {
                for (int j = 0; j <= jaggedArray.Length + 1; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
