using Microsoft.AspNetCore.SignalR;

namespace BtkAkademi.Services.ChatAPI.Hubs
{
    public class ChatHub : Hub
    {
        public override Task OnConnectedAsync()
        {

            return base.OnConnectedAsync();
        }

        public async Task SendTypingStatus(string userName, bool isTyping)
        {
            await Clients.Others.SendAsync("ReceiveTypingStatus", userName, isTyping);
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
