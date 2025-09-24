using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_02_Sales_Office
{
    public class Owner
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public  virtual ICollection<Owned_Property>? Owned_Properties { get; set; }= new HashSet<Owned_Property>();
    }
}
