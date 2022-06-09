using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClsSombra
    {

        public double mSombra()     //metodo para hacer la operacion de la longitud de la sombra de un edificio
        {
            double grados = 22;     //los grados del sol con el suelo

            double radianes = (Math.PI / 180) * grados;     //operacion para pasar de grados a radianes

            double h = 20;      //altura del edicifio en metros

            double vSombra = h / Math.Tan(radianes);    //calculo de la distancia de la sombra con los grados transformados a radianes

            return vSombra;
    
        }


    }
}
