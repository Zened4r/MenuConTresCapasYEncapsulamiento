using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocios;

namespace EjerciciosTresCapasS4M
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ClsEntidades ObjDistanciaN = new ClsEntidades();    //instancias Negocios
            ClsEntidades ObjSombraN = new ClsEntidades();
            

            double respuestaDistancia = ObjDistanciaN.mObtenerDistancia();      //permite llamar metodos instanciados en CapaNegocios
            double respuestaSombra = ObjSombraN.mObtenerSombra();

            String s1 = "0";     //string de seleccion de opciones para el usuario

            do                                              //Ciclo Do-While para crear un menu de seleccion y que el usuario eliga la opcion que quiere
            {                                                   

                Console.Clear();        //limpia la pantalla despues de que el usuario presione una tecla despues de finalizar la opcion que el usuario escogio

                Console.WriteLine("Elige lo que quieres realizar\n" +
                "\n1.- Distancia recorrida por la llanta" +
                "\n2.- Longitud de la sombra" +
                "\n3.- Meses transcurridos" +
                "\n4.- Promedio de alumnos" +
                "\n5.- Salir\n");

                Program p = new Program();      //permite llamar metodos dentro de la misma clase

                s1 = Console.ReadLine();        

                switch (s1)             //switch con las opciones disponibles para el usuario
                {
                    case "1":
                        Console.WriteLine(respuestaDistancia);          //llama a las variable que se encuentran en la linea 19 que viene del metodo de la CapaNegocios
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine(respuestaSombra);         //llama a las variable que se encuentran en la linea 20 que viene del metodo de la CapaNegocios
                        Console.ReadKey();
                        break;
                    case "3":
                        p.preguntarMeses();             //metodo llamado de la linea 70
                        Console.ReadKey();
                        break;
                    case "4":
                        p.preguntarPromedios();         //metodo llamado de la linea 94
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Presione de nuevo para Salir");      //permite al usuario salir del sistema
                        break;
                    default:           
                        break;

                }

            } while (s1 != "5");                //Ciclo Do-While si el usuario preciona otro numero que no sea el 5 se seguira repitiendo el menu hasta que el usuario eliga el numero 5
        }

        public void preguntarMeses()        //metodo para preguntarle al usuario la fecha de nacimiento
        {

            try                 //try-chatch para que cuando el usuario coloque un dato incorrecto detecte el error e imprima un mensaje indicandole al usuario
            {

                ClsEntidades ObjMesesN = new ClsEntidades();        //instancia de CapaNegocios

                Console.WriteLine("Meses desde tu nacimiento");

                Console.WriteLine("Ingresa tu fecha de nacimiento en formato dd/MM/yyyy");      //se le da un formato al usuario para el ingreso de datos
                string fechaDeNacimientoString = Console.ReadLine();

                double vContar = ObjMesesN.mObtenerMeses(fechaDeNacimientoString);      //variable que guarda los datos que vienen desde la CapaDatos y pasan por la encapsulacion de la CapaNegocios

                Console.WriteLine("La cantidad de meses que hay desde su fecha de nacimiento es de {0}", vContar);      //muestra el resultado de cuantos meses hay desde que nacio

            } catch (SystemException)
            {
                Console.WriteLine("Error de sintaxis. Intente de nuevo");       //mensaje de error para cuando el usuario se equivoque al escribir una fecha
            }

        }

        public void preguntarPromedios()
        {
            ClsEntidades ObjPromedioN = new ClsEntidades();     //instancia de CapaNegocios
            
            double espanol, matematicas, economia, programacion, ingles;

            Console.WriteLine("Promedio de notas del estudiante");          //se le pregunta al usuario el promedio de sus notas

            Console.WriteLine("Ingrese la nota de Español");
            espanol = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de Matemáticas");
            matematicas = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de Economía");
            economia = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de Programación");
            programacion = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de Ingles");
            ingles = double.Parse(Console.ReadLine());
            
            double vAnalizar = ObjPromedioN.mObtenerPromedio(espanol, matematicas, economia, programacion, ingles);         //variable que guarda los datos que vienen desde la CapaDatos y pasan por la encapsulacion de la CapaNegocios

            Console.WriteLine("El promedio es de {0}", vAnalizar);          //muestra el promedio de las notas del usuario
        }
    }
}
