using System;
using System.Threading.Tasks;

namespace EjercicioEvaluacion.Entity
{
    // 1. crea una clase persona con atributos nombre edad
    // y direccion incluye un constructor que inicialice estos atributos
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }


        // constructor que inicializa los atributos 
        public Persona(string nombre, int edad, string direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;

        }

        // 2. añade a la clase persona un constructor sin
        //parametro que asigne valores predeterminados a los atributos
        public Persona()
        { 
            Nombre = "Carlos Martines";
            Edad = 23;
            Direccion = "Calle 6 # 10-39";

        }

        public void ingresoDeDatos()
        {
            Console.WriteLine($"Ingrese su nombre: ");
            Nombre = Console.ReadLine(); //ReadLine es para resivir los valores que dijita el ususario

            Console.WriteLine("Ingrese su edad: ");
            Edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su direccion: ");
            Direccion = Console.ReadLine();
        }


        // 3. metodo en la clase persona que muestre la informacion de la persona en consola 

        // Virtual : estás indicando que las clases derivadas pueden
        // proporcionar su propia implementación de este método.

        // en si el  virtual permite que al sobre escribir el metodo en otra clase
        // esta clase le defina el  comportamiento a este metodo en ella (Polimorfismo)
        

        // virtual la prepara para que pueda ser utilizada en otras clases 

        public void mostrarInformacion()
        {
            Console.WriteLine("Nombre:   " + Nombre);
            Console.WriteLine("Edad:     "+ Edad);
            Console.WriteLine("Direccion:  "+ Direccion);
        }

        /*public async Task leerDatos()
        {
            Console.WriteLine("Estamos leyendo los datos....");
            await Task.Delay(3000);  // el retraso de 3 min 

            Console.WriteLine("datos leidos.");
            mostrarInformacion(); 
        }*/
    }


}
