using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SelfieSlots.Signalr
{
    public class Connection : PersistentConnection
    {
        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            // Broadcast data to all clients
            return Connection.Broadcast(data);
        }
    }
}