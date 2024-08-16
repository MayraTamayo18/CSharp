using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    // se crea la interfaz de animal 
    public interface IAnimal
    {
        string Nombre { get; } // solo lectura 
        string Especie { get; } 

    }
}
