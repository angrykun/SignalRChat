using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;
using Owin;
using Microsoft.Owin.Cors;//解决跨域访问

namespace SignalRSelfHost
{
    /*
     * SignalR服务器通常在IIS的ASP.NET应用程序上承载，但它也可以使用自托管库来作为自托管的主机（就像控制台应用或者Windows服务那样）。
     * 与SignalR 2.0一样，自托管库是基于.Net开放式Web接口(OWIN)来构建的。
     * OWIN定义了.Net Web服务器和Web应用程序之间的抽象接口，将Web应用程序从服务器上解耦，使得OWIN可以在IIS之外建立自托管主机。
     * **/
    class Program
    {
        static void Main(string[] args)
        {
            //System.Reflection.TargetInvocationException 错误
            //1.用管理员权限打开VS 2.端口被占用，换一个端口
            string url = "http://localhost:8888";
            using (WebApp.Start(url))
            {
                Console.WriteLine("Server running on {0}",url);
                Console.ReadLine();
            }
        }
    }
}
