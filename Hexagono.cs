using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCalculadoraGeometrica2
{
    internal class Hexagono : Formas
    {
        private double ladoHexagono;

        public Hexagono(string nome, double ladoHexagono) : base(nome)
        {
            this.ladoHexagono = ladoHexagono;
        }

        public double LadoHexagono { get => ladoHexagono; set => ladoHexagono = value; }

        public override double Area()
        {
            return (3 * ladoHexagono * ladoHexagono * 1.73) / 2;
        }
        public override double Perimetro()
        {
            return ladoHexagono * 6;
        }
    }
}
