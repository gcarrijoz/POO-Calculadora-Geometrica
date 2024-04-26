using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCalculadoraGeometrica2
{
    internal class Pentagono : Formas
    {
        private double ladoPentagono;

        public Pentagono(string nome, double ladoPentagono) : base(nome)
        {
            this.ladoPentagono = ladoPentagono;
        }

        public double LadoPentagono { get => ladoPentagono; set => ladoPentagono = value; }

        public override double Area()
        {
            return (5 * ladoPentagono / 2) * (((ladoPentagono) / 2) * Math.Tan(0.942478));
        }

        public override double Perimetro()
        {
            return ladoPentagono * 5;
        }

    }
}
