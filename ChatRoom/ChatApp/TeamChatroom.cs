using System.Collections.Generic;
using System.Linq;

namespace ChatRoom.ChatApp;

public class TeamChatroom : Chatroom
{
    
    private List<TeamMember> _teamMembers = new List<TeamMember>();


    public override void Register(TeamMember member)
    {
        member.SetChatRoom(this);
        _teamMembers.Add(member);
    }

    public override void Send(string from, string message)
    {
        _teamMembers.ForEach(m => m.Receive(from, message));
    }

    public override void SendTo<T>(string from, string message)
    {
        _teamMembers.OfType<T>().ToList().ForEach(m => m.Receive(from, message));
    }


    public void RegisterMembers(params TeamMember[] teamMembers)
    {
        foreach (var teamMember in teamMembers)
        {
             Register(teamMember);
        }
    }
}