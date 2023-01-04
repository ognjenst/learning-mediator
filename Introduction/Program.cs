// See https://aka.ms/new-console-template for more information

using Mediator.Structural;

namespace Mediator;

class Program
{
    private static void Main(string[] args)
    {
        var mediator = new ConcreteMediator();
        var c1 = mediator.CreateColleague<Colleague1>();
        var c2 = mediator.CreateColleague<Colleague2>();
        
        c1.Send("How are you?");
        c2.Send("Fine, thanks");
    }
}