using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;

namespace ChatServer; 

public class ServerHandler {
    private TcpClient client;
    private ConnectionPool pool;
    private NetworkStream _stream;

    public ServerHandler(TcpClient client,ConnectionPool pool) {
        this.pool = pool;
        this.client = client;
        _stream = this.client.GetStream();
    }

    public void run() {
        Console.WriteLine("Client connected..");
        while (true) {
            byte[] dataFromClient = new byte[1024];
            int bytesRead = _stream.Read(dataFromClient, 0, dataFromClient.Length);
            string messageFromClient = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
            if (messageFromClient.ToLower().Equals("Exit")) {
                break;
            }

            byte[] dataToClient = Encoding.ASCII.GetBytes(messageFromClient);
            pool.BroadcastToAll(dataToClient);
        }
        client.Dispose();

    }

    public void SendMessageToClient(byte[] dataToClient) {
        _stream.Write(dataToClient,0,dataToClient.Length);   
    }
}