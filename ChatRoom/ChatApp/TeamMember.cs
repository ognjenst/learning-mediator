namespace ChatRoom.ChatApp;

public class TeamMember
{
    public string Name { get; }
    private Chatroom _chatRoom;

    public TeamMember(string name)
    {
        this.Name = name;
    }
    
    internal void SetChatRoom(Chatroom chatRoom)
    {
        this._chatRoom = chatRoom;
    }
    
    public void Send(string message)
    {
        _chatRoom.Send(Name, message);
    }
    
    public virtual void Receive(string from, string message)
    {
        // Console.WriteLine("{0}: '{1}'", from, message);
    }
    
    public void SendTo<T>(string message) where T: TeamMember
    {
       _chatRoom.SendTo<T>(Name, message);
    }
}