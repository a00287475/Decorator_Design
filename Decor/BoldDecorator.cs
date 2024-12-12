using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decor
{

    public class BoldDecorator : Decorator<string>
    {
        public BoldDecorator(IComponent<string> component) : base(component) { }

        public override string GetText()
        {
            return $"\u001b[1m{base.GetText()}\u001b[0m";
        }
    }
}
