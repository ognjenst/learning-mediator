using System;
using ChatRoom.ChatApp;

namespace ChatRoom;

public class ChatRoom
{
    public static void Main(string[] args)
    {
        var teamchat = new TeamChatroom();

        var neso = new Developer("Neso");
        var stefan = new Developer("Stefan");
        var vedran = new Developer("Vedran");
        var bodo = new Tester("Bodo");
        
        teamchat.RegisterMembers(neso, stefan, vedran, bodo);
        neso.Send("Work work work!");
        Console.WriteLine();
        neso.SendTo<Developer>("Don't give Bodo the access!");
    }
}