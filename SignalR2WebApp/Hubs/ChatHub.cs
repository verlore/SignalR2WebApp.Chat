using Microsoft.AspNetCore.SignalR;

namespace SignalR2WebApp.Hubs
{
    public class ChatHub : Hub
    {
        public async void SendMessage(string name, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", name, message);
        }
    }
}
