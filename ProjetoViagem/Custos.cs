using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraViagem
{
    public class Custos
    {
    
        public double CalcularViagem(Percurso percurso) {
            double totalPercurso = (percurso.kmPercorrida * percurso.valorCombustivel) + percurso.valorPedagio;
            return totalPercurso;
        }
    }
}
