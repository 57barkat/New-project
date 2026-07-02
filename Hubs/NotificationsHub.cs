using Microsoft.AspNetCore.SignalR;

namespace CrmScreeningTasks.Hubs;

public class NotificationsHub : Hub
{
    public async Task SendMessage(string message)
    {
        if (string.IsNullOrWhiteSpace(message))
        {
            return;
        }

        await Clients.All.SendAsync("ReceiveMessage", message.Trim());
    }
}
