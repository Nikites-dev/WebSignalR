using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace WebSignalR
{
    public class ChatHub: Hub
    {
        public async Task Send(String message, String userName, String email)
        {
            await Clients.All.SendAsync("Receive", message, userName, email);
        }
    }
}
