using Microsoft.AspNetCore.SignalR;
namespace BlazorSignalR.Hubs

{
    public class ChatHub : Hub
    {
        public Task sendMessage(string user,string message)
        {
            return Clients.All.SendAsync("ReceiveMessage",user, message);
        }

        public Task sendIsTyping(string user, bool istyping)
        {
            return Clients.Others.SendAsync("ReceiveIsTyping",user, istyping);
        }
    }
}
