using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargA
{
    class Operaciones
    {


      

        
        
        public  double Multiplicacion(double a, double b, double c) 
        {
            double res;

            res = a * b * c;
           
            return res;
 
        }
       
        public  double Multiplicacion(double a, double b)
        {
            double res;
            res = a * b;
            return res;

        }

        public  double Multiplicacion(double a)
        {
            double res;
            res = a * 5;
            return res;

        }


    }
}
