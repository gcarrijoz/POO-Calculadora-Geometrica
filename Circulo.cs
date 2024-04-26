using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCalculadoraGeometrica2
{
    class Circulo : Formas
    {
        private double raio;

        public Circulo(string nome, double raio) : base(nome)
        {
            this.raio = raio;
        }

        public double Raio { get => raio; set => raio = value; }

        public override double Area()
        {
            return (raio * raio) * 3.14;
        }
    }
}
