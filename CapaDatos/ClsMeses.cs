using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClsMeses
    {
        public double mMeses(string fechaDeNacimientoString)
        {
            
            DateTime fechaDeNacimiento = DateTime.ParseExact(fechaDeNacimientoString, "dd/MM/yyyy", null);      //convierte la fecha de nacimiento de string a DateTime

            DateTime fechaActual = DateTime.Now;    //obtiene la fecha actual

            TimeSpan diferencia = fechaActual - fechaDeNacimiento;      //operacion para saber la diferencia entre la fecha de nacimiento y la fecha actual

            double dias = diferencia.TotalDays;     //calcula la diferencia anterior en dias

            double vMeses = dias / 12;      //calcula los dias que tiene y los pasa a meses

            return vMeses;
        }


    }
}
