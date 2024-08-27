using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class UserRoleDto
    {
       public int Id {get; set;}
       public int UserId{ get; set;}
       public User User { get; set; }
       public int RoleId{ get; set; }
       public Role Role { get; set; }
       public bool State{ get; set; }
    }
}
