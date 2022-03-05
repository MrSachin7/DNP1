namespace ChatServer; 

public class ConnectionPool {
    private List<ServerHandler> _serverHandlers;

    public ConnectionPool() {
        _serverHandlers = new List<ServerHandler>();
    }

    public void AddConnection(ServerHandler serverHandler) {
        _serverHandlers.Add(serverHandler);
    }

    public void RemoveConnection(ServerHandler serverHandler) {
        _serverHandlers.Remove(serverHandler);
    }

    public void BroadcastToAll(byte[] dataToClient) {
        _serverHandlers.ForEach(handler => handler.SendMessageToClient(dataToClient));
    }
}