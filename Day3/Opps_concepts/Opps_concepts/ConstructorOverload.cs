using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_concepts
{
    
    internal class ConstructorOverload
    {
        int a, b;
        public ConstructorOverload()
        {
            a  = 5;
            b = 7;
        }
        public ConstructorOverload(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Show()
        {
            Console.WriteLine("A value is " +a+" B value is"+b);
        }
        static void Main()
        {
            ConstructorOverload obj = new ConstructorOverload();
            obj.Show();
            ConstructorOverload obj2 = new ConstructorOverload(10, 15); 
            obj2.Show();
        }
    }
}
