using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraViagem
{
    public class Percurso
    {
        public double kmPercorrida;
        public double valorCombustivel;
        public double valorPedagio;

        public Percurso() { }
        public Percurso(double kmPercorrida, double valorCombustivel, double valorPedagio) {
            this.kmPercorrida = kmPercorrida;
            this.valorCombustivel = valorCombustivel;
            this.valorPedagio = valorPedagio;
        }


    }
}
