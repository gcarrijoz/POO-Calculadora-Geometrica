using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCalculadoraGeometrica2
{
    public abstract class Formas
    {
        // ATRIBUTOS -------------
        protected string nome;

        public Formas(string nome)
        {
            this.nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }

        // MÉTODOS -------------
        public abstract double Area();

        public virtual double Perimetro()
        {
            return 0;
        }
    }
}
