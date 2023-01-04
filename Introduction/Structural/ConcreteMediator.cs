namespace Mediator.Structural;

public class ConcreteMediator : Mediator
{
    
    private List<Colleague> _colleagues = new List<Colleague>();
    
    public void Register(Colleague colleague)
    {
        colleague.SetMediator(this);
        _colleagues.Add(colleague);
    }
    public override void Send(string message, Colleague colleague)
    {
        _colleagues.Where(c => c != colleague).ToList().ForEach(c => c.HandleNotification(message));
    }
}