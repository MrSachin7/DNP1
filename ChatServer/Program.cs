// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Net.Sockets;
using ChatServer;

TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"),5000);
listener.Start();
Console.WriteLine("Server started...");
 ConnectionPool connectionPool = new ConnectionPool();
while (true) {
    TcpClient client = listener.AcceptTcpClient();
    ServerHandler serverHandler = new ServerHandler(client, connectionPool);
    connectionPool.AddConnection(serverHandler);
    Thread thread = new Thread(serverHandler.run);
    thread.Start();
}