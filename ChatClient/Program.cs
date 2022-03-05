// See https://aka.ms/new-console-template for more information

using System.Net.Sockets;
using System.Text;
using ChatClient;

Client client = new Client();
client.StartClient();
client.startSendingMessage();
