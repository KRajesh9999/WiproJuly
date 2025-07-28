using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionConcept
{
    internal class ReflectionEx1
    {
        static void Main(string[] args)
        {
            Type typeObj = typeof(Test);
            Console.WriteLine("Method available in Test class\n");
            foreach(MethodInfo mi in  typeObj.GetMethods())
            {
                Console.WriteLine(mi.Name);
            }
            Console.WriteLine("Variables Available in the class are ");
            foreach(FieldInfo fi in typeObj.GetFields())
            {
                Console.WriteLine(fi.Name);
            }
        }
    }
}
