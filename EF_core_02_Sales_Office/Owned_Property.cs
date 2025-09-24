using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_02_Sales_Office
{
    public class Owned_Property
    {
        public int? Property_id { get; set; }
        public  virtual Property? Property { get; set; }


        public int? Owner_id { get; set; }
        public virtual Owner ?Owner { get; set; }

        public double? Precent {  get; set; }
    }
}
