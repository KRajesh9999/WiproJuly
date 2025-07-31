using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_With_OCP
{
    internal class Program
    {
        public static void Show(ITraining iTraining)
        {
            iTraining.Info();
            iTraining.Timing();
        }

        static void Main(string[] args)
        {
            DotNetTraining dotNetTraining = new DotNetTraining();
            Show(dotNetTraining);

            JavaTraining javaTraining = new JavaTraining();
            Show(javaTraining);

            DataScienceTraining dataScienceTraining = new DataScienceTraining();
            Show(dataScienceTraining);

            PythonTraining pythonTraining = new PythonTraining();
            Show(pythonTraining);
        }
    }
}
