using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLKonto;

namespace ConKonto
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto k = new Konto("Karsten",1337);
            Console.WriteLine(k.Name + " hat einen Kontostand von " + k.Kontostand +" Euro");
            Console.ReadLine();
        }
    }
}
