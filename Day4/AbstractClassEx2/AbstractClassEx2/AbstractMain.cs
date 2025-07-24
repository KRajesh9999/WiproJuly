using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEx2
{
    internal class AbstractMain
    {
        static void Main(string[] args)
        {
            Animal[] arrAnimals = new Animal[]
            {
                new Lion(),
                new Crocodile(),
                new Cow()
            };

            foreach (Animal animal in arrAnimals)
            {
                animal.Name();
                animal.Type();
                Console.WriteLine("--------------------");
            }
        }
    }
}
