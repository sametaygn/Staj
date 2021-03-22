using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staj.Hubs
{
    public class MonitorHub:Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReciveMessage", message);
        }
    }
}
