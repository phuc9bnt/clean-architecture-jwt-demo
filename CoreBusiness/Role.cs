using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    [Table("Roles")]
    public class Role
    {
        public Guid RoleId {  get; set; }
        public string Rolecode { get; set; }
        public string RoleName { get; set; }
    }
}
