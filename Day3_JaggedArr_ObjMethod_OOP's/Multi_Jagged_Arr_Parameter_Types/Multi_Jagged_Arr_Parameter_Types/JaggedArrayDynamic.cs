using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Jagged_Arr_Parameter_Types
{
    internal class JaggedArrayDynamic
    {
        static void Main()
        {
            int n, m;
            Console.WriteLine("ENter no of Jagged arrays and Size of elements of each row: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());

            int[][] JaggedArray = new int[n][];

            int[] x = new int[m];  // m - size of array
            int[] y = new int[m];

            Console.WriteLine("Enter elements for array X: ");
            {
                for(int i = 0; i < m; i++)
                {
                    x[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter Elements for Array Y ");
            for (int i = 0; i < m; i++)
            {
                y[i] = Convert.ToInt32(Console.ReadLine());
            }
            JaggedArray[0] = x;
            JaggedArray[1] = y;

            Console.WriteLine("Printing Jagged Array elements: ");
            for(int i = 0; i < JaggedArray.Length; i++)
            {
                for(int j = 0;  j < JaggedArray[i].Length; j++)
                {
                    Console.Write(JaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
