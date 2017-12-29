using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name ,string message)
        {
            //调用 addNewMessageToPage 方法更新客户端
            Clients.All.addNewMessageToPage(name,message);
        }
    }
}