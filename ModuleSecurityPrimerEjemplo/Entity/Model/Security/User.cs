using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Security
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set;  }
        public string Password { get; set; }
        public int personaId { get; set; }
        public Person Person { get; set;  }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool State { get; set; }

    }
}
