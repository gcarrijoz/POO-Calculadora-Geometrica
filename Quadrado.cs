using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCalculadoraGeometrica2
{
    class Quadrado : Formas
    {
        private double ladoQuadrado;

        public Quadrado(string nome, double ladoQuadrado) : base(nome)
        {
            this.ladoQuadrado = ladoQuadrado;
        }

        public double LadoQuadrado { get => ladoQuadrado; set => ladoQuadrado = value; }

        public override double Area()
        {
            return ladoQuadrado * ladoQuadrado;
        }

        public override double Perimetro()
        {
            return ladoQuadrado * 4;
        }
    }
}
