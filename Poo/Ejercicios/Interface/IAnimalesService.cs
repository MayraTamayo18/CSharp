using Ejercicios.clase_interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Interface
{
 // se declara una interfaz define el conjunto de metodos que la clase debe implementar
 // aqui se describe lo que se debe hacer mas no como se debe hacer 
    public  interface IAnimalesService
    {
    //toask : operación que puede completarse en el futuro;
    //este aqui solo indica que ha terminado su trabajo 
    //el metodo recibe parametros de tipo Animal 
        Task alimentar(Animales animales);
        // este no es un metoso asincronico "se ejecuta de manera sincronica (de una vez)"
        void HacerSonido(Animales animales);
    }
}
