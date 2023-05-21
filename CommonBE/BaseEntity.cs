using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBE
{
    public class BaseEntity
    {
        protected static Random random;
        public BaseEntity()
        {
            random = new Random();
        }
    }
}
