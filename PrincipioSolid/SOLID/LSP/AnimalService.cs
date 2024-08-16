using SOLID.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
  
    public class AnimalService
    {
        // la clase deribada puede sustituir pueden sustituir a la clase base sin alterar el comportamiento del programa
        // cualquier  instancia de animal pueda sustituir a la clase base 
        public void animalDetalle(Animal animal)//se espera que este parametrosea un objeto de la clase Animal o cualquier clase deribada de ella
        {
            //imprime una cadena de texto muestra nombre y la especie de animal
            Console.WriteLine($"Nombre del Animal: {animal.Nombre}, Especie: {animal.Especie}");
        }
    }
}
