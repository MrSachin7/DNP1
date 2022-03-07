// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using MultiThreadedServer;


Console.WriteLine("Starting server..");

IPAddress ip = IPAddress.Parse("127.0.0.1");
TcpListener listener = new TcpListener(ip, 5000);
listener.Start();

Console.WriteLine("Server started..");

while (true) {
    Console.WriteLine("While loop..");
    TcpClient client = listener.AcceptTcpClient();
    new Thread(() => HandleProvidedClient(client)).Start();
    // HandleProvidedClient(client);
}

static void HandleProvidedClient(TcpClient client) {
    Console.WriteLine("Client connected..");
    using NetworkStream stream = client.GetStream();

    // read
    while (true) {
        byte[] dataFromClient = new byte[1024];
        int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
        string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
        Console.WriteLine(s);
        Message? deserialize = JsonSerializer.Deserialize<Message>(s);
        if (deserialize.MessageBody.ToLower().Equals("exit")) {
            // client.Dispose();
            break;
        }

        Console.WriteLine($"Message >> {deserialize.MessageBody} at {deserialize.TimeStamp}");

        Console.WriteLine("Please write a reply for that client..");
        string? reply = Console.ReadLine();
        Message message = new Message {
            MessageBody = reply,
            TimeStamp = DateTime.Now
        };
        string messageToSend = JsonSerializer.Serialize(message);
        // respond
        byte[] dataToClient = Encoding.ASCII.GetBytes(messageToSend);
        stream.Write(dataToClient, 0, dataToClient.Length);
    }

    client.Dispose();
    //client.Close();
}