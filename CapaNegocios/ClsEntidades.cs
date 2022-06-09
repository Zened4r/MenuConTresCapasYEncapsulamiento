using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class ClsEntidades
    {

        ClsLlantas ObjDistancia = new ClsLlantas();     //instancias Datos
        ClsSombra ObjSombra = new ClsSombra();
        ClsPromedio ObjPromedio = new ClsPromedio();
        ClsMeses ObjMeses = new ClsMeses();

        private double vDistancia;                  //encapsulamientos lineas 18-43
        private double vSombra;
        private double vPromedio;
        private double vMeses;

        public double _vDistancia                   
        {
            get => vDistancia;
            set => vDistancia = value;
        }

        public double _vSombra 
        {
            get => vSombra;
            set => vSombra = value;
        }
        public double _vPromedio 
        { 
            get => vPromedio;
            set => vPromedio = value; 
        }
        public double _vMeses 
        { 
            get => vMeses; 
            set => vMeses = value; 
        }

        public double mObtenerDistancia()                               //metodos que activan las capas de datos
        {
            double vObtener = ObjDistancia.mDistancia();

            return vObtener;
        }

        public double mObtenerSombra()
        {
            double vRealizar = ObjSombra.mSombra();

            return vRealizar;
        }

        public double mObtenerPromedio(double espanol, double matematicas, double economia, double programacion, double ingles)
        {
            double vAnaliza = ObjPromedio.mPromedio(espanol, matematicas, economia, programacion, ingles);

            return vAnaliza;
        }

        public double mObtenerMeses(string fechaDeNacimientoString)
        {
            double vContar = ObjMeses.mMeses(fechaDeNacimientoString);

            return vContar;
        }
    }
}
