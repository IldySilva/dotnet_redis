using System.Net;
using System.Net.Sockets;
using System.Text;


TcpListener server = new TcpListener(IPAddress.Any, 6379);
server.Start();
Console.WriteLine(server.LocalEndpoint.Serialize());
var clientSocket=server.AcceptSocket();
await clientSocket.SendAsync(Encoding.UTF8.GetBytes("+PONG\r\n" ),SocketFlags.None);
