using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_With_DIP
{
    internal class TrainerUtil
    {
        private ITrainerData iTrainerData;

        public TrainerUtil(ITrainerData iTrainerData)
        {
            this.iTrainerData = iTrainerData;
        }

        public  void ShowInfo()
        {
            iTrainerData.Name();
            iTrainerData.City();
            iTrainerData.Email();
        }
    }
}
