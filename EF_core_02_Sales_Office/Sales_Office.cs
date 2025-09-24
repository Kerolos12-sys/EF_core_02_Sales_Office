using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_02_Sales_Office
{
    public class Sales_Office
    {
        [Key]
        public int Number {  get; set; }
        public string? Location { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; } = new HashSet<Employee>();
        public virtual ICollection<Property>? Properties { get; set; } = new HashSet<Property>();

        public int? ManagerId { get; set; }
        public virtual Employee? Manager { get; set; }

    }
}
