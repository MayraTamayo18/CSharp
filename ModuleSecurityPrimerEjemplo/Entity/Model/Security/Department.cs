﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Security
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        //nombre que hace la relacion
        public int CountryId { get; set; }

        //la referencia de la relacion
        public Country Country { get; set; }
        public bool State { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? UpdatedAt { get; set; }
        public DateTime ? DeletedAt { get; set; }
    }
}
