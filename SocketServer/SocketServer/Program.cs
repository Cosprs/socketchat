using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocketServer
{
    class Program
    {
        public static Hashtable clientsList = new Hashtable(); //Liste des clients

        static void Main(string[] args)
        {
            Int32 port = 8888;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            TcpListener serverSocket = new TcpListener(localAddr, port); //Ecoute de connexion clients sur l'ip/port
            TcpClient clientSocket = default(TcpClient); //Client
            int counter = 0;

            serverSocket.Start(); //On lance l'écoute serveur
            Console.WriteLine("-------Le serveur de Chat est lancé-------");
            counter = 0;
            while ((true))
            {
                counter += 1;
                clientSocket = serverSocket.AcceptTcpClient(); //Accept les requêtes de connexion

                byte[] bytesFrom = new byte[10025];
                string dataFromClient = null;

                NetworkStream networkStream = clientSocket.GetStream(); //On récupère le flux du client
                networkStream.Read(bytesFrom, 0, bytesFrom.Length); //(int)clientSocket.ReceiveBufferSize
                dataFromClient = System.Text.Encoding.UTF8.GetString(bytesFrom);//On convertit le flux en string UTF8
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                clientsList.Add(dataFromClient, clientSocket);

                broadcast(dataFromClient + " s'est connecté ", dataFromClient, false); //On envoie à tout le monde le message "s'est connecté"

                Console.WriteLine(dataFromClient + " s'est connecté ");
                handleClinet client = new handleClinet();
                client.startClient(clientSocket, dataFromClient, clientsList);
            }

            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine("exit");
            Console.ReadLine();
        }

        public static void broadcast(string msg, string uName, bool flag)
        {
            foreach (DictionaryEntry Item in clientsList)
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)Item.Value;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                Byte[] broadcastBytes = null;

                if (flag == true)
                {
                    broadcastBytes = Encoding.UTF8.GetBytes(uName + ": " + msg);
                }
                else
                {
                    broadcastBytes = Encoding.UTF8.GetBytes(msg);
                }

                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                broadcastStream.Flush();
            }
        }  //end broadcast function

        public class handleClinet
        {
            TcpClient clientSocket;
            string clNo;
            Hashtable clientsList;

            public void startClient(TcpClient inClientSocket, string clineNo, Hashtable cList)
            {
                this.clientSocket = inClientSocket;
                this.clNo = clineNo;
                this.clientsList = cList;
                Thread ctThread = new Thread(doChat);
                ctThread.Start();
            }

            private void doChat()
            {
                int requestCount = 0;
                byte[] bytesFrom = new byte[10025];
                string dataFromClient = null;
                Byte[] sendBytes = null;
                string serverResponse = null;
                string rCount = null;
                requestCount = 0;

                while ((true))
                {
                    try
                    {
                        requestCount = requestCount + 1;
                        NetworkStream networkStream = clientSocket.GetStream(); //Recup le flux du client
                        networkStream.Read(bytesFrom, 0, bytesFrom.Length); //read
                        dataFromClient = System.Text.Encoding.UTF8.GetString(bytesFrom); //Convertit UTF8
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                        Console.WriteLine("From chatclient - " + clNo + " : " + dataFromClient);
                        rCount = Convert.ToString(requestCount);

                        Program.broadcast(dataFromClient, clNo, true);//On envoie le message du flux à tout le monde
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }//end while
            }//end doChat
        } //end class handleClinet
    }
}
