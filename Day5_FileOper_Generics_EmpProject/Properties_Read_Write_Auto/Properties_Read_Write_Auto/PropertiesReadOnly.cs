using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Read_Write_Auto
{
    class Bank
    {
        public int AccountNo { get; } = 12;
        public string BranchName { get; } = "Banglore";
        public string BankName { get; } = "Union";
    }
        internal class PropertiesReadOnly
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Console.WriteLine("Account No :" + bank.AccountNo);
            Console.WriteLine("Bank Name:  " + bank.BankName);
            Console.WriteLine("Branch Name: " + bank.BranchName);
        }
    }
}
