using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;


namespace LogicLayer.Hubs
{
    public class MainHub
    {
        public async Task SendMessage(string user, string msg)
        {
            await Clients.All.SendAsync("ReceiveMEssage", user, msg);
        }
    }
}
