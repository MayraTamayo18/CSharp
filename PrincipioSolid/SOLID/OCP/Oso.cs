﻿using SOLID.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    //se cumple el p.Ocp ya que el Oso fue implementado para la extencion de la clase
    // animal pero no modifica la clase padre 
    public class Oso : Animal
    {
        public Oso(string nombre) : base(nombre, "mamíferos omnívoros") { }
    }
}
