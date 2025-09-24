using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_02_Sales_Office
{
    public class Employee
    {
        [Key]
        public  int Id { get; set; }

        public string? Name { get; set; }


        public int? SalesOfficeId { get; set; }
        public virtual Sales_Office? SalesOffice { get; set; }




        public  virtual Sales_Office? ManagedOffice { get; set; }
    }
}
