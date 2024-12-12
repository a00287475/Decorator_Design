using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decor;

class Program
{
    static void Main(string[] args)
    {
        IComponent<string> component = new ConcreteComponent();
        IComponent<string> plainDecorator = new PlainDecorator(component);
        IComponent<string> boldDecorator = new BoldDecorator(component);
        IComponent<string> colorDecorator = new ColorDecorator(component);

        Console.WriteLine(component.GetText());
        Console.WriteLine(boldDecorator.GetText());
        Console.WriteLine(colorDecorator.GetText());
        Console.WriteLine(plainDecorator.GetText());
       
    }
}