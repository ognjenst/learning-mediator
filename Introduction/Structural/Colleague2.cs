namespace Mediator.Structural;

public class Colleague2 : Colleague
{
  

    public override void HandleNotification(string message)
    {
        Console.WriteLine($"Colleague2 gets message: {message}");
    }
}