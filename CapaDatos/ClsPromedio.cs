using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClsPromedio
    {
        public double mPromedio(double espanol, double matematicas, double economia, double programacion, double ingles)        //metodo para calcular el promedio de las materias ingresadas
        {

            double vPromedio = espanol + matematicas + economia + programacion + ingles / 5;        //calculo de el promedio de las materias

            return vPromedio;

        }

    }
}
