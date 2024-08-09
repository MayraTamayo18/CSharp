using Ejercicios.clase_interfase;
using Ejercicios.Entity;
using Ejercicios.Interface;
using Ejercicios.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.program

    //es la entrada del proyecto la actividad inicial del proyecto 
    // es lo primero que se hace cuando se ejecuta el proyecto y de ahi derivan todas 
    // las acciones que se van a realizar 
{
    // declara un clase llamada prgrama 
    // contiene el punto de entrada de la aplicacion 
     class Program
    {
        static async Task Main(string[] args)
        {
            IAnimalesService animalesService = new AnimalesService();

            // aqui se definen e istancia (se crea vaca y gato) los objetos de tipo vaca y gato 

            Animales miVaca = new vaca("lola", 2, "Brahman"); // se crea y se asinan los valores iniciales en el constructor 

            Animales miGato = new gato("manchas", 4, "Gato esfinge");

            Console.WriteLine("el nombre de la vaca es:" + miVaca.Nombre + " " + "Edad:" + " " + miVaca.Edad); // para que muestre el nombre de el animal que deseamos

            animalesService.HacerSonido(miVaca);
            await animalesService.alimentar(miVaca);

            Console.WriteLine("el nombre de gato es:" + miGato.Nombre + " " + "Edad" + " " + miGato.Edad); // para que muestre el nombre de el animal que deseamos 

            animalesService.HacerSonido(miGato);
            await animalesService.alimentar(miGato);

            Console.WriteLine("proceso de alimentacion completdo."); 

            

        }
    }
}
