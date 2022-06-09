using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosExtra
{
    public class ClsDatosExtra
    {
        public double mPromedio(double espanol, double matematicas, double economia, double programacion, double ingles)
        {

            double vPromedio = espanol + matematicas + economia + programacion + ingles / 5;

            return vPromedio;

        }

    }
}
