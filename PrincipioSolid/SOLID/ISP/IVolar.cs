using SOLID.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    // se crea un interfaz que es el contrato que la clase debe cumplir
    
    public interface IVolar
    {
        // define el metodo volar 
        //cualquier clase q implemente IVolar debe implementar este metodo
        void Volar(); 
    }
}
