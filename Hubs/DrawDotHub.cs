using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalrChat2.Hubs
{
    public class DrawDotHub: Hub {
        // It calls the fuction updateDot in the draw.js file.
        public async Task UpdateCanvas(int x, int y,string color) {
            await Clients.All.SendAsync("updateDot",x, y,color);
        }

        public async Task ClearCanvas() {
            await Clients.All.SendAsync("clearCanvas");
        }
    }

}