using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_02_Sales_Office
{
    public class Property
    {
        [Key]
        public int Id { get; set; }

        public string? Location { get; set; }    
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int? Code { get; set; }

        public  virtual  ICollection<Owned_Property>? Owned_Properties { get; set; } = new HashSet<Owned_Property>();
        public int? SalesOfficeId { get; set; }
        public  virtual Sales_Office? SalesOffice { get; set; }
    }
}
