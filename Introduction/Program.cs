// See https://aka.ms/new-console-template for more information

using Mediator.Structural;

namespace Mediator;

class Program
{
    private static void Main(string[] args)
    {
        var mediator = new ConcreteMediator();
        var c1 = new Colleague1(mediator);
        var c2 = new Colleague2(mediator);
        mediator.Colleague1 = c1;
        mediator.Colleague2 = c2;
        
        c1.Send("How are you?");
        c2.Send("Fine, thanks");
    }
}