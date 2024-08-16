using EjercicioEvaluacion.Entity;
using System;
using System.Threading.Tasks;

namespace EjercicioEvaluacion
{
    public  class Program
    {
        static async Task Main(string[] args)
        {
            //Persona persona = new Persona("wilfer", 30, "neiva");
            //await persona.leerDatos();

            //Empleado empleado = new Empleado(20000, 24);
            //empleado.mostrarInformacion();
            //await empleado.leerDatos();

            Empleado empleado = new Empleado();

            // llama el metodo para poder que el ususario ingrese los datos por consola 
            empleado.ingresoDeDatos();

            //para que el ususario ingrese su salario
            //

            Console.Write("ingrese el valor de su salario:   ");
            empleado.Salario = double.Parse(Console.ReadLine());

            Console.Write("ingrese el numero de dias trabajados:   ");
            empleado.Dias = int.Parse(Console.ReadLine());

            // muestra la informacion completa 
            empleado.mostrarInformacion();

            await empleado.LeerOperacion();




        }
    }
}
