using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class AbstractDecorator : Coffee
    {
        protected Coffee coffee;
        public AbstractDecorator(string n, Coffee coffee) : base(n)
        {
            this.coffee = coffee;
        }
    }
}
