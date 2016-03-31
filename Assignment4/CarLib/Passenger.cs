using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;


namespace CarLib
{
    public class Passenger:Car
    {
        // Stuff exclusive to passenger!!
            [Column()]
            public int trimCode;
    }
}
