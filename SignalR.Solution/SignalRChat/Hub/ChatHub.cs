using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat
{
    public class ChatHub : Hub
    {
        /*
         * 派生自Hub类提供方法来构建SignalR应用程序
         * 在Hub派生类中创建公共方法，然后通过JS访问这些方法。
         * 在js中引用服务器类及成员应当使用小驼峰式拼写。
         * **/
        public void Send(string name ,string message)
        {
            //调用 addNewMessageToPage 方法更新客户端
            Clients.All.addNewMessageToPage(name,message);
        }
    }
}