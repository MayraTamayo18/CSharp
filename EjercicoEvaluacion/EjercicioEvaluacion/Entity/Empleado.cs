﻿using EjercicioEvaluacion.Interface;
using System;
using System.Threading.Tasks;

namespace EjercicioEvaluacion.Entity
{
    // 4. crear una clase empleado que herede de persona e incluya un atributo adicional 
    //   salario, sobre escribe el metodo para mostrar la informacion incluyendo el salario 
    public  class Empleado: Persona, ICalculable //(herencia)-Persona  (Implementacion Interfaz)-ICalculable
    {

        public int Salario { get; set;  }
        public int Dias { get; set;  }

        //llama el constructor base llamado que se encuentra en persona 
        // se inicializa nombre edad direccion al igual que el nuvo atributo salario 
        public Empleado(int salario, int dias)
        {
            Salario = salario;
            Dias = dias; 
        }
        public Empleado() { }
       

        // aqui se sobre escribe el metodo de mostrar informacion el cual se encuentra en la clase persona 

        public void mostrarInformacion() //(polimofismo)
        {
            base.mostrarInformacion();
            Console.WriteLine("salario:    " + Salario);
            Console.WriteLine("Dias Trabajados:   " + Dias);
            //Console.WriteLine("Valor a pagar:      " + calcularSalario(Salario, Dias));

        }

        public int calcularSalario(int Salario, int Dias)
        {
            int Valor = (Salario / 30) * Dias; 
            return Valor;
        }

        public async Task LeerOperacion()
        {
            Console.WriteLine("Estamos realizando su operacion....");
            await Task.Delay(5000);

            Console.WriteLine("operacion realizada.");
            Console.WriteLine("Valor a pagar:    " + calcularSalario(Salario, Dias));
        }

    }
}
