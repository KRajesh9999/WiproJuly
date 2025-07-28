using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using ClsReflectionLibraryExample;

namespace ReflectionConcept
{
    internal class ReflectionEx7
    {
        static void Main()
        {
            Type objStudent = typeof(Student);
            Console.WriteLine("Methods available are") ;
            foreach(MethodInfo m in objStudent.GetMethods())
            {
                Console.WriteLine(m.Name); 
            }
            Console.WriteLine("Fields available are ");
            foreach(FieldInfo f in objStudent.GetFields())
            {
                Console.WriteLine(f.Name);
            }
        }
    }
}
