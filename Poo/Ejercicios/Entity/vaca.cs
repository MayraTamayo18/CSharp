using Ejercicios.clase_interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Entity

//RSP=> clase tiene una responsabilidad- vaca->Raza y los metodos relacionados(sonido, alimentar)
//Lsp=> clase vaca hereda animal y sobrescribe metodos, objetos tipo vaca-sustituidos objetos de tipo animal
//isp=> (interfases deben ser espesificas y no debe obligar implementar clase metodo-No-necesita)
//vaca soloimplementa los metodos que necesita
//Dip => vaca depende de animal clase mayor
// por que : La clase vaca depende de la abstracción Animal a través de la herencia
// y la implementación de métodos abstractos. Esto permite que vaca pueda
// ser extendido y utilizado en conjunto con otros tipos de Animal de manera flexible.
{
    // vaca erreda de la clase Animal y debe  implemtar los metodos  abstractos definidos en animal
    public class vaca : Animales
    {
        // se crea una propiedad adiccional que  almacena  raza
        public string Raza { get; set; }

        // constructor almacena tres parametro y toma los parametros base(nombre y edad)
        //inicializando nombre edad 
        //llama el constructor base animal y inicializa raza
        public vaca(string nombre, int edad, string raza) : base(nombre, edad)
        {
            // inicializa la propiedad Raza con su valor
            Raza = raza;
        }

        //implementacion de metodos abstractos 
        //sobre escribe elmetodo hacersonido en este caso la implementacion para vaca es imprimir muu muu
        public override void HacerSonido()  // polimorfismo-> hace que el metodo sea el ismo pero tenga diferentes comportamientos
        {
            Console.WriteLine("muu! muu!");
        }

        //async: indica que el metodo es asincronico
        //override sobre escribe implementación del
        //método AlimentarAsync definido en la clase base Animal.
        //El método devuelve un Task, lo que significa que es una
        //operación asincrónica que no devuelve un valor 
        public override async Task alimentar()
        {
            Console.WriteLine("Alimentando a la vaca...");
            await Task.Delay(200);  //awaite crea un retraso

            Console.WriteLine("La vaca ha sido alimentada.");
        }


    }
}
