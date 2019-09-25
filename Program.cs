using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargA
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones Op = new Operaciones();
            
            var res1 = Op.Multiplicacion(2, 3, 4);
            var res2 = Op.Multiplicacion(2,4);
            var res3 = Op.Multiplicacion(2);
            Console.ReadKey();
            Datos d = new Datos();
            d.obtenerDatos();
            Console.ReadKey();




        }
    }
}
