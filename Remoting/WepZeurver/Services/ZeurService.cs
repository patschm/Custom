using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepZeurver.Services
{
    public class ZeurService : Hub
    {
        public async Task RoeptUMaar(string data)
        {
            await Clients.All.SendAsync("toeter", data);
        }
    }
}
