using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;

namespace ChatClient;

public class Client {
    public void startSendingMessage() {
        using TcpClient client = new TcpClient("127.0.0.1", 5000);

        using NetworkStream stream = client.GetStream();
        Console.WriteLine("Enter your name ");
        string? name = Console.ReadLine();
        while (true) {
            Console.WriteLine("Enter any message you want to send to other clients...");
            string? input = Console.ReadLine();
            string dataToSend = $"{name} >>> {input}";
            byte[] dataToServer = Encoding.ASCII.GetBytes(dataToSend);
            stream.Write(dataToServer, 0, dataToServer.Length);
            if (input.ToLower().Equals("exit")) {
                break;
            }
        }
    }

    public void StartClient() {
         TcpClient client = new TcpClient("127.0.0.1", 5000);
         new Thread(() => keepListeningToServer(client)).Start();
    }

    public void keepListeningToServer(TcpClient client) {
        using NetworkStream stream = client.GetStream();
        while (true) {
            byte[] dataFromServer = new byte[1024];
            int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
            string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
            Console.WriteLine(response);
        }
    }
}