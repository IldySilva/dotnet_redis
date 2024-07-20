using System.Net;
using System.Net.Sockets;
using System.Text;

Console.WriteLine("Logs from your program will appear here!");

 TcpListener server = new TcpListener(IPAddress.Any, 6379);
 server.Start();
 server.AcceptSocket(); // wait for client

var clientSocket=server.AcceptSocket();
clientSocket.Send(Encoding.UTF8.GetBytes("+PONG\r\n"),SocketFlags.None);
