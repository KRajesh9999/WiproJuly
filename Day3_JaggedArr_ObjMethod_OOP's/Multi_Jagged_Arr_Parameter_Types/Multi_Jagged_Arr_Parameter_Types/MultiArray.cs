using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Jagged_Arr_Parameter_Types
{
    internal class MultiArray
    {
        static void Main(string[] args)
        {
                int[,] x = new int[2, 3]
                {
                {1, 2, 3},
                {5,2,8 }
                };

                //x[0,0] = 1;
                //x[0,1]=2;
                //x[0,2]=3;
                //x[1, 0] = 5;
                //x[1, 1] = 2;
                //x[1, 2] = 8;

                //Console.WriteLine("--------------------------------------");
                //Console.WriteLine(x[0, 0]);
                //Console.WriteLine(x[0, 1]);
                //Console.WriteLine(x[0, 2]);
                //Console.WriteLine("--------------------------------------");

                //Console.WriteLine(x[1, 0]);
                //Console.WriteLine(x[1, 1]);
                //Console.WriteLine(x[1, 2]);

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.WriteLine("x{0}{1}  {2}", i, j, x[i, j]);
                }

            }

        }
    }
}
