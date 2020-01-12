using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatClient
{
    public class ChatHub : Hub
    {
        public void Send(string userName, string msg)
        {
            Clients.All.addNewMessageToPage(userName, msg);
        }
    }
}