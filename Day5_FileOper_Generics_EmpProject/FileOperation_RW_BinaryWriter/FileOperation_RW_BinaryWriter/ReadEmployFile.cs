using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation_RW_BinaryWriter
{
    internal class ReadEmployFile
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"C:\Users\kethi\FileOperationOutput\Employ.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Employ employ = (Employ)binaryFormatter.Deserialize(fs);
            Console.WriteLine(employ);
        }
    }
}
