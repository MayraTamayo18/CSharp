using SOLID.LSP;
using SOLID.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    // aqui se evidencia el principio ISP 
    // se implementa la interfaz volar 
    public class Pajaro : Animal, IVolar
    {
        public Pajaro(string nombre) : base(nombre, "vertebrado"){ }//llama el constructor de la clase animal pasando el nombre que se recibe y estableciendo la especie a Pajaro

        public void Volar() // metodo  publico no devuelve ningu valor implementa interfaz IVolar
        {
            Console.WriteLine($"Nombre del animal: {Nombre}, Especie: {Especie}, Puede volar."); //imprime en consola que el pajaro con el nombre que le pongamos esta volando
        }
    }
}
