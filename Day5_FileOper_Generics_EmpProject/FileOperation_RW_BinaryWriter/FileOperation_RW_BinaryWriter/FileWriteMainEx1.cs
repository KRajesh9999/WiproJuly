using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace FileOperation_RW_BinaryWriter
{
    internal class FileWriteMainEx1
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\kethi\FileOperationOutput\Demo1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This program belongs to wipro chohert-4...");
            sw.WriteLine("Thank you all...");
            sw.WriteLine("Trainer is Prasanna Pappula..");
            sw.Flush();
            sw.Close();
            fs.Close();
            Console.WriteLine("File created Successfully....");
        }
    }
}
