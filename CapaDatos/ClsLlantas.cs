using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClsLlantas
    {

        public double mDistancia()       //metodo para hacer la operacion de cuanto viaja una llanta de 50cm de diametro en 1km
        {

            double diametro = 50;    //diametro de la llanta

            double circunferencia = ((diametro * Math.PI) / 100000);    //operacion para sacar la circunferencia del circulo

            double vDistancia = 1 / circunferencia;     //distancia recorrida

            return vDistancia;      
        }


    }
}
