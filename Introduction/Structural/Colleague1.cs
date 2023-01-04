namespace Mediator.Structural;

public class Colleague1 : Colleague
{
    

    public override void HandleNotification(string message)
    {
        Console.WriteLine($"Colleague1 gets message: {message}");
    }
}