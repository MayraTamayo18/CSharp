using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.clase_interfase
{

    // cumpliendo asi el primer principio Rsp solid de responsavilidad unica
    // y el de abierto y cerrado crp, abstraccion 

    //se declara una clase publica abstracta
    // abstract indica que la clase no puede ser instanciada directamente desde esta clase
    //ni se puede crear objetos directamente de esta clase
    public abstract class Animales
    {
        // atributos

        // se declara los atribustos una propiedad publica 
        public string Nombre { get; set; }
        public int Edad { get; set; }



        //constructor
        // se declara un costructor protegido  que inicializa los atributos de la clase usando los parametros creados-constructor
        //para que solo pueda ser llamado desde la clase animales o sus subclases 

        protected Animales(string nombre, int edad )
        {
            Nombre = nombre;
            Edad = edad;

        }

        //metodos
        // se declara metodo abstracto, puede ser implementado por cualquier subclase 

        //este metodo define una accion que cada subclase de animal debe realizar
        //
        public abstract void HacerSonido(); //metodos-abstractos-obliga a vaca gato a implementar 


        // Task tipo de retorno del metodo que se puede ejecutar de manera asincronica 
        public abstract Task alimentar(); 

    }
}
