using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decor
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Create the Decorator Design Pattern";
        }
    }
}
