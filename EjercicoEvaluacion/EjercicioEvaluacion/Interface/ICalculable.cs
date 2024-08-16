using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEvaluacion.Interface
{
    // 5. define una interfaz ICaculable  con un metodo calcularSalario 
    // implementa esta interfaz en la clase empleado 
    public interface ICalculable
    {
        //
        double calcularSalario(double salario, int dias); 

    }
}
