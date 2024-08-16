using SOLID.ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    // se crea la clase animal que contien el principio RSP
    // animal es la clase base y cada nuevo animal tiene
    // una responsabilidad espesifica
    public class Animal: IAnimal // implementamos la interfaz de animal 
    {
        // la clase animal tiene la responsabilidad de respresentar (alamcenar y gestionar)la identidad 
        public string Nombre { get; set; } 
        public string Especie { get; set; }

  

        public Animal(string nombre, string especie)
        {
            Nombre = nombre;
            Especie = especie; 
        }
    }
}
