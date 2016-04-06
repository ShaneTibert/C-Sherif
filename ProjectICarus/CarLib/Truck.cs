using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;


namespace CarLib
{
    public class Truck : Car
    {
        [Column()]
        public int axels;
        [Column()]
        public int tonnage;
    }
}
