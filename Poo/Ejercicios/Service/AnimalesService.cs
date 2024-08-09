using Ejercicios.clase_interfase;
using Ejercicios.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Service

    //conecta los objetos con el cliente 

{
    // AnimalesService implementa la interfaz  IAnimalesService
    public class AnimalesService : IAnimalesService
    {
        // declara un metoso publico asincronico llamado  alimentarAnimales y toma 
        // parametros tipo Animal, devuelve un task 
        public async Task alimentar(Animales animales)
        {
            await animales.alimentar();  // llama el metodo de la clase animal
        }

        // define un metodo publico no devuleve ningun valor
        public void HacerSonido(Animales animales)
        {
            animales.HacerSonido();
        }

    }
}
