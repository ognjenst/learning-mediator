namespace ChatRoom.ChatApp;

public class Tester : TeamMember
{
    public Tester(string name) : base(name)
    {
    }
    
    public override void Receive(string from, string message)
    {
        Console.WriteLine($"{Name} ({nameof(Tester)}) received: {message}");
        base.Receive(from, message);
    }
}