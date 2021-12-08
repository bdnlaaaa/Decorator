using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Coffee
    {
        public Coffee(string n)
        {
            this.Name = n;
        }
        public string Name { get; protected set; }
    }
}
