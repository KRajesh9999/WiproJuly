using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_With_OCP_Ex2
{
    internal class Program
    {
        public static void ShowBillInfo(int meterId, string personName, IElectricity iElectricity)
        {
            Console.WriteLine("Meter Id: " + meterId) ;
            Console.WriteLine("Payment from Mr/Miss/Mrs " + personName);
            Console.WriteLine("Paymode is  " + iElectricity.Payment(2000));
        }
        static void Main(string[] args)
        {
            IElectricity billsource;

            billsource = new NetBanking();
            ShowBillInfo(6624, "Rajesh", billsource);

            billsource = new CreditCard();
            ShowBillInfo(8832, "Venkata", billsource);

            billsource = new DebitCard();
            ShowBillInfo(8812, "Uday", billsource);

            billsource = new Phonepe();
            ShowBillInfo(8897, "Ganesh", billsource);
        }
    }
}
