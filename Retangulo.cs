using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCalculadoraGeometrica2
{
    class Retangulo : Formas
    {
        private double ladoRetangulo;
        private double alturaRetangulo;

        public Retangulo(string nome, double ladoRetangulo, double alturaRetangulo) : base(nome)
        {
            this.ladoRetangulo = ladoRetangulo;
            this.alturaRetangulo = alturaRetangulo;
        }

        public double LadoRetangulo { get => ladoRetangulo; set => ladoRetangulo = value; }
        public double AlturaRetangulo { get => alturaRetangulo; set => alturaRetangulo = value; }

        public override double Area()
        {
            return ladoRetangulo * alturaRetangulo;
        }

        public override double Perimetro()
        {
            return 2 * ladoRetangulo + 2 * alturaRetangulo;
        }
    }
}
