using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    [Table("Teacher")]
    public class Teacher
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Subject {  get; set; }
        public string Description { get; set; }
    }
}
