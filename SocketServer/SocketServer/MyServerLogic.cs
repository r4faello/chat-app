using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace SocketServer
{
    public enum NotifyType
    {
        Error,
        Userexists,
        Message,
        Quit,
        GetUsers,
        NewUser
    }

    internal class MyServerLogic : WebSocketBehavior
    {
        protected override void OnClose(CloseEventArgs e)
        {
            Console.WriteLine(e.Reason);
            base.OnClose(e);
        }

        protected override void OnError(ErrorEventArgs e)
        {
            Console.WriteLine(e.Message);
            base.OnError(e);
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            //get mssage type and content
            var data = e.Data.Split("|");
            //get type
            var msgType = (NotifyType)Enum.Parse(typeof(NotifyType), data[0]);
            //get message content
            var msgText = data[1];
            if(msgType == NotifyType.Message)
            {
                Sessions.Broadcast($"{NotifyType.Message}|{data[2]}: {msgText}");
            }
            else if(msgType == NotifyType.Quit)
            {
                Program.allusers.Remove(msgText);
                Sessions.Broadcast($"{NotifyType.Quit}|{msgText}");
                Sessions.CloseSession(ID);
            }
        }

        protected override void OnOpen()
        {
            if (!Context.QueryString.Contains("name"))
            {
                Send($"{NotifyType.Error}|Please specify name property");
                Console.WriteLine("no name property");
                return;
            }
            //get user name and check if user exists
            string name = Context.QueryString["name"];
            if (Program.allusers.Contains(name))
            {
                Send($"{NotifyType.Userexists}|Please choose another username");
                Console.WriteLine("user exists");
                return;
            }
            //add user to list
            Program.allusers.Add(name);
            //send usr list to connected user
            Send($"{NotifyType.GetUsers}|{GetAllUsers()}");
            //send message to everyone
            Sessions.Broadcast($"{NotifyType.NewUser}|{name}");
        }

        private string GetAllUsers()
        {
            string temp = "";
            foreach (var item in Program.allusers)
            {
                temp += item + "\n";
            }
            return temp;
        }
    }
}