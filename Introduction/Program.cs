// See https://aka.ms/new-console-template for more information

using Mediator.Structural;

namespace Mediator;

class Program
{
    private static void Main(string[] args)
    {
        var mediator = new ConcreteMediator();
        var c1 = new Colleague1();
        var c2 = new Colleague2();
        mediator.Register(c1);
        mediator.Register(c2);
        
        c1.Send("How are you?");
        c2.Send("Fine, thanks");
    }
}