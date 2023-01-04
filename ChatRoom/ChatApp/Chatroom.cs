namespace ChatRoom.ChatApp;

public abstract class Chatroom
{
    public abstract void Register(TeamMember participant);
    public abstract void Send(string from, string message);
    public abstract void SendTo<T>(string from, string message) where T : TeamMember;
}