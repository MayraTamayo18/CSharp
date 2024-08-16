using SOLID.ISP;
using SOLID.OCP;
using SOLID.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//clase alto nivel no deben depender de clase de bajo nivel.
//Ambos deben depender de abstracciones.
namespace SOLID.DIP
{
    // esta depende de la interfaz de IAnimal en lugar de la clase animal 
    public class veterinario
    {
        public string NombreVeterinario { get; set; }// get permite obtener y el set asignar

        public veterinario(string nombreVeterinario)
        {
            NombreVeterinario = nombreVeterinario; 
        }
        // tiene el metodo de alimentar los animales no devuelve ningun valor 
        //toma argumento de tipo IAnimal
        //para que esta no dependa de Animal solo  
        public void alimentarAnimal(IAnimal animal)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            //aqui imprimimos un mensaje en consola que muetsra el nombre del veterinario 
            // indica que esta alimentando a un animal y muestra el nombre y la especie de este animal
            Console.WriteLine($" el veterinario {NombreVeterinario}  esta alimentando a {animal.Nombre} el cual corresponde a la especie de: {animal.Especie}.");
        }

        
    }
}
