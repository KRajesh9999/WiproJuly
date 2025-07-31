using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_With_DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITrainerData trainer1 = new DotNetInfo();
            ITrainerData trainer2 = new JavaInfo();

            TrainerUtil util1 = new TrainerUtil(trainer1);
            TrainerUtil util2 = new TrainerUtil(trainer2);

            util1.ShowInfo();
            util2.ShowInfo();
        }
    }
}
