using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Entities
{
    public class EmployeeLocation
    {
        [Key, Column(Order = 1)]
        public int EmployeeID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int LocationID { get; set; }
        

        //Navigation Properties Should be declared as virtual
        public virtual Employee Employee { get; set; }
        public virtual Location Location { get; set; }
        // prop
        //then, [Tab][Tab]

    }
}
