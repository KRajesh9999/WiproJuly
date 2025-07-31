using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_With_LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Details[] arr = new Details[]
            {
                new Rajesh(),
                new Ramesh(),
                new Rakesh()
            };

            foreach (var v in arr)
            {
                v.ShowInfo();
            }
        }
    }
}
