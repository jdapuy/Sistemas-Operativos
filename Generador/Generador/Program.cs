using System;
using System.Net;
using System.Net.Sockets;

namespace Generador
{
    class Program
    {
        static void Main(string[] args)
        {
            conectar();
            
        }

        public static void conectar() {
            Socket miPrimerSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            IPEndPoint miDireccion = new IPEndPoint(IPAddress.Any,20000);

            try {
                miPrimerSocket.Bind(miDireccion);
                miPrimerSocket.Listen(1);
                System.Console.WriteLine(" ______________________");
                System.Console.WriteLine("| ***** GENERADOR *****|");
                System.Console.WriteLine("|______________________|");
                System.Console.WriteLine("");
                System.Console.WriteLine("Iniciando Generador...");
                System.Console.WriteLine("Escuchando...");
                Socket escuchar = miPrimerSocket.Accept();
                System.Console.WriteLine("Conectado con exito...");
                miPrimerSocket.Dispose();

            }
            catch (Exception e) {
                Console.WriteLine("Error: {0}", e.ToString());
            }
            Console.WriteLine("Presione cualquier tecla para terminar");
            Console.ReadLine();
        }
    }
}