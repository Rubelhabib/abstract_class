using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    abstract class Car_Model
    {

        public void Model(int id, string name, float price)
        {
            Console.WriteLine($"Id: {id}\n Name is: {name}\n Price: {price}");
        }
        public abstract void Sp();
    }

    class Audi : Car_Model
    {
        public override void Sp()
        {
            Console.WriteLine("This is brand! ");
        }
    }
        
}
