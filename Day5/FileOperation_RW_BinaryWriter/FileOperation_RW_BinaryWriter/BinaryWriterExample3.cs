using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation_RW_BinaryWriter
{
    internal class BinaryWriterExample3
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"C:\Users\kethi\FileOperationOutput\data.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(12);
            bw.Write("Wipro");
            bw.Write(28832.33);
            bw.Write(true);
            bw.Close();
            fs.Close();
            Console.WriteLine("Primitive Data Stored in files...");
        }
    }
}
