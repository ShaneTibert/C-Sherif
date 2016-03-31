using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomControl
{
    public class LengthLimit
    {
        public delegate void LengthLimiter(String txt);
        public LengthLimiter lengthLimiter; 

    }
}
