using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Security
{
    public class RoleView
    {
        public int id { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public int ViewId { get; set; }

        public View View { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool State { get; set; }
    }
}
