using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuronios
{
    public class sinapse
    {
        public double value;
        public double peso;
    }
    public class Neuronio
    {
        //sinapses 
        public sinapse[] _sinapses;
        public Neuronio(sinapse[] sinapse)
        {
            _sinapses = sinapse;
        }
        //integtracao
        public double Z(sinapse[] sinapses)
        {
            double sum = 0;
            for (int i = 0; i < sinapses.Length; i++)
            {
                sum += (sinapses[i].value * sinapses[i].peso);
            }

            return sum;
        }
        public double pesoStar(double[] Ys, sinapse[] sinapses)
        {
            double sum = 0;
            for (int i = 0; i < Ys.Length; i++)
            {
                double error = (Ys[i] - Z(sinapses));
                sum += error * error;
            }
            return sum;
        }
        public double[] CalcularDerivadas(double[] Ys, sinapse[] sinapses)
        {
            double[] derivadas = new double[sinapses.Length];

            for (int j = 0; j < sinapses.Length; j++)
            {
                double derivada = 0;
                for (int i = 0; i < Ys.Length; i++)
                {
                    double error = (Ys[i] - Z(sinapses));
                    derivada += -2 * error * sinapses[j].value;
                }
                derivadas[j] = derivada;
            }

            return derivadas;
        }
        //funcoes de transferencia
        public double Fsimples(double x)
        {
            return x;
        }
        //signoide
        public double Fz(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }
        //gauss
        public double fzGauss(double x)
        {
            return 1 / (Math.Sqrt(2 * Math.PI)) * Math.Exp(-0.5 * x * x);
        }

        
     

    }
}
