using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCalculadoraGeometrica2
{
    internal class Trapezio : Formas
    {
        private double baseMenor;
        private double baseMaior;
        private double alturaTrapezio;

        public Trapezio(string nome, double baseMenor, double baseMaior, double alturaTrapezio) : base(nome)
        {
            this.baseMenor = baseMenor;
            this.baseMaior = baseMaior;
            this.alturaTrapezio = alturaTrapezio;
        }

        public double BaseMenor { get => baseMenor; set => baseMenor = value; }
        public double BaseMaior { get => baseMaior; set => baseMaior = value; }
        public double AlturaTrapezio { get => alturaTrapezio; set => alturaTrapezio = value; }

        public override double Area()
        {
            return ((baseMaior + baseMenor) * alturaTrapezio) / 2;
        }

        public override double Perimetro()
        {
            return (baseMaior + baseMenor) + 2 * Math.Sqrt(Math.Pow((baseMaior - baseMenor) / 2, 2) + alturaTrapezio * alturaTrapezio);
        }

    }
}
