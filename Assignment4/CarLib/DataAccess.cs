using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;



namespace CarLib
{
    public class DataAccess : DataContext
    {
        public Table<Car> car;
        public DataAccess()
            : base(@"Data Source=(localdb)\Projects;Initial Catalog=Car;Integrated Security=True;")
        {

        }
    }
}
