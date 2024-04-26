using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCalculadoraGeometrica2
{
    internal class Losango : Formas
    {
        private double diagonalMaior;
        private double diagonalMenor;

        public Losango(string nome, double diagonalMaior, double diagonalMenor) : base(nome)
        {
            this.diagonalMaior = diagonalMaior;
            this.diagonalMenor = diagonalMenor;
        }

        public double DiagonalMaior { get => diagonalMaior; set => diagonalMaior = value; }
        public double DiagonalMenor { get => diagonalMenor; set => diagonalMenor = value; }

        public override double Area()
        {
            return (diagonalMaior * diagonalMenor) / 2;
        }

        public override double Perimetro()
        {
            return (Math.Sqrt(Math.Pow((diagonalMaior / 2), 2) + Math.Pow((diagonalMenor / 2), 2))) * 4;
        }
    }
}
