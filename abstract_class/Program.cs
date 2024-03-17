using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();
            bus.Speed();
            bus.highway(12,"Sara",'R');
            Console.WriteLine();
            Audi audi = new Audi();
            audi.Sp();
            audi.Model(1,"Hebi",12.50f);
            Console.ReadKey();

        }
    }

    abstract class Car
    {
        public void highway(int rade, string name, char a)
        {
            Console.WriteLine($"This is simplemethod in abstactor! \n Rade is: {rade} \n Name is: {name}\n Charachter is: {a}");
        }

        public abstract void Speed();

    }
    class Bus : Car
    {
        public override void Speed()
        {
            Console.WriteLine("Car speed is 80km/h!");
        }
    }
}
