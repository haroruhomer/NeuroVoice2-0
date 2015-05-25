using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuro.Neurona
{
    public class Neuronas
    {
        public double net { get; set; }
        public TipoNeurona tipo { get; set; }
        public double salida { get; set; }
        public double[] pesos { get; set; }
        public double error { get; set; }
    }
}
