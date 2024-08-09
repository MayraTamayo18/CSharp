using Ejercicios.clase_interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Entity


//RSP=> clase tiene una responsabilidad- gato->Color y los metodos relacionados(sonido, alimentar)
//Lsp=> clase gato hereda animal y sobrescribe metodos, objetos tipo gato-sustituidos objetos de tipo animal
//isp=> (interfases deben ser espesificas y no debe obligar implementar clase metodo-No-necesita)
//gato soloimplementa los metodos que necesita
//Dip => gato depende de animal clase mayor
// por que : La clase gato depende de la abstracción Animal a través de la herencia
// y la implementación de métodos abstractos. Esto permite que gato pueda ser extendido
// y utilizado en conjunto con otros tipos de Animal de manera flexible.
{
    // gato herreda de la clase Animal y debe  implemtar los metodos  abstractos definidos en animal
    public class gato: Animales
    {
        // se crea una propiedad adiccional que  almacena color
        public string Color { get; set; }

        // constructor almacena tres parametro y toma los parametros base(nombre y edad)
        //inicializando nombre edad 
        //llama el constructor base animal y inicializa color
        public gato(string nombre, int edad, string color) : base(nombre, edad)
        {
            Color = color; 
        }


        //implementacion de metodos abstractos 
        //sobre escribe elmetodo hacersonido en este caso la implementacion para vaca es imprimir miau miau
        public override void HacerSonido() // polimorfismo-> hace que el metodo sea el ismo pero tenga diferentes comportamientos
        {                                
            Console.WriteLine("Miau! Miau!"); 
        }

        //async: indica que el metodo es asincronico
        //override sobre escribe implementación del
        //método AlimentarAsync definido en la clase base Animal.
        //El método devuelve un Task, lo que significa que es una
        //operación asincrónica que no devuelve un valor
        public override async Task alimentar()
        {
            Console.WriteLine("Alimentando a el gato....");
            await Task.Delay(200);  //awaite crea un retraso 

            Console.WriteLine("el gato ha sido alimentado.");
        }

       
    }
}
