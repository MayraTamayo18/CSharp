using SOLID.DIP;
using SOLID.LSP;
using SOLID.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // se crea una instancia de la clase AnimalService
            // que se utilizara para mostrar-detalle-animal
            var animalService = new AnimalService();


            //crean los objetos de animal
            var Leon = new Leon("manchitas agresivas");// clase derivada de Animal
            var Oso = new Oso("el tiernito peludo");
            var Oveja = new Oveja("la oveja negra de la famila");
            var Pajaro = new Pajaro("arturo el cucu");

            // muestra la informacion de pajaro y hace que vuele 
            Pajaro.Volar();

            //llama el metodo animalDetalle de la clase animalService
            // pasa el objeto leon como argumento(imprimira en consola el nombre, especie)
            animalService.animalDetalle(Leon);
            animalService.animalDetalle(Oveja);
            animalService.animalDetalle(Oso);
            animalService.animalDetalle(Pajaro);

            

            var veterinario1 = new veterinario("Calos Montero");
            veterinario1.alimentarAnimal(Leon);

            var veterinario2 = new veterinario("Marcos Perdomo");
            veterinario2.alimentarAnimal(Oveja);

            var veterinario3 = new veterinario("Wilfer Castro");
            veterinario3.alimentarAnimal(Oso);

            


        }
    }
}
