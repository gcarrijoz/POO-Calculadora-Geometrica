using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCalculadoraGeometrica2
{
    class Triangulo : Formas
    {
        private double ladoTriangulo;
        private double alturaTriangulo;

        public Triangulo(string nome, double ladoTriangulo, double alturaTriangulo) : base(nome)
        {
            this.ladoTriangulo = ladoTriangulo;
            this.alturaTriangulo = alturaTriangulo;
        }

        public double LadoTriangulo { get => ladoTriangulo; set => ladoTriangulo = value; }
        public double AlturaTriangulo { get => alturaTriangulo; set => alturaTriangulo = value; }

        public override double Area()
        {
            return (ladoTriangulo * alturaTriangulo) / 2;
        }

        public override double Perimetro()
        {
            return ladoTriangulo * 3;
        }
    }
}
