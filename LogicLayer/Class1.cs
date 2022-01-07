using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class MainHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
