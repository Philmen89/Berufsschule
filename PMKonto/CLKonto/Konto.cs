using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKonto
{
    public class Konto
    {
        private string name;

        public string Name
        {
            get { return name; }
        }
        private double kontostand;

        public double Kontostand
        {
            get { return kontostand; }
        }

        public Konto()
        {
            this.name = "Mustermann";
            this.kontostand = 50;
        }

        public Konto(string name, double stand)
        {
            this.kontostand = stand;
            this.name = name;
        }
        public void raise(double value)
        {
            if (value > 0)
            this.kontostand = this.kontostand + value;   
        }
        public void decrease(double value)
        {
            if (value > 0)
                this.kontostand = this.kontostand - value;
        }
    }
}
