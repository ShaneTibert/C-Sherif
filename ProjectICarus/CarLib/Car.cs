using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CarLib
{
    [Table]
    [InheritanceMapping(Code = "T", Type = typeof(Truck))]
    [InheritanceMapping(Code = "P", Type = typeof(Passenger))]
    [InheritanceMapping(Code = "C", Type = typeof(Car), IsDefault = true)]

    public class Car
    {
        [Column(IsPrimaryKey = true)]
        public int vIN;
        [Column]
        public string model;
        [Column]
        public string make;
        [Column]
        public string year;
        [Column(IsDiscriminator = true)]
        public string type;
    }
}
