using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neoronios
{
    public class sinapse
    {
        public double value;
        public double peso;
    }
    public class Neoronio
    {
        //sinapses 
        public sinapse[] _sinapses;
        public Neoronio(sinapse[] sinapse)
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
        public double ZNegativo(sinapse[] sinapses)
        {
            double sum = 0;
            for (int i = 0; i < sinapses.Length; i++)
            {
                sum -= (sinapses[i].value * sinapses[i].peso);
            }

            return sum;
        }
        public double pesoStar(double[] Ys, sinapse[] sinapses)
        {
            double sum = 0;
            
            for (int i = 0; i < Ys.Length; i++) {
                   //Σ w0 = Yi-f(x->,w->)*2
                double erro =  (Ys[i] - Z(sinapses));
                sum += erro * erro;
            }
            return sum;
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

        /*
         * FOR PASSIENTE J = 1 (D (X,W,Y) = (Yi - F(Xi,w))*2)
         * para achar o maximo de uma funcao a derivada dela tem que ser igual a zero
         * 
         */
     

    }
}
