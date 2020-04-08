using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace TESOAR_MARK2.SERVER
{
    public partial class Server : Form
    {
        public static TcpClient client;
        private static TcpListener listener;
        private static string ipString;

        private static string spName = "spPais";

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load( object sender, EventArgs e )
        {
            StoreProcedure.InitializeSql("ROG_STRIX_GAMIN\\SQLEXPRESS", "TESOAR");

            IPAddress [ ] localIp = Dns.GetHostAddresses(Dns.GetHostName());
            foreach ( IPAddress address in localIp )
            {
                if ( address.AddressFamily == AddressFamily.InterNetwork )
                {
                    ipString = address.ToString();
                }
            }
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ipString), 1234);
            listener = new TcpListener(ep);
            listener.Start();
            Console.WriteLine(@"  
            ===================================================  
                   Started listening requests at: {0}:{1}  
            ===================================================",
            ep.Address, ep.Port);
            client = listener.AcceptTcpClient();
            Console.WriteLine("Connected to client!" + " \n");
            while ( client.Connected )
            {
                try
                {
                    const int bytesize = 1024 * 1024;
                    byte [ ] buffer = new byte [ bytesize ];
                    string x = client.GetStream().Read(buffer, 0, bytesize).ToString();
                    var data = ASCIIEncoding.ASCII.GetString(buffer);

                    if ( data.ToUpper().Contains("SAVEDATA") )
                    {
                        int sepIndex = data.IndexOf(":", StringComparison.Ordinal);
                        var data1 = data.Substring(0, sepIndex);

                        int sepIndex1 = data.IndexOf("-", StringComparison.Ordinal) - sepIndex;
                        var data2 = data.Substring(sepIndex + 1, sepIndex1 - 1);

                        int sepIndex2 = ( data.IndexOf("-", StringComparison.Ordinal) + 1 );
                        int sepIndex3 = ( data.IndexOf("_", StringComparison.Ordinal) + 1 );
                        var data3 = data.Substring(sepIndex2, sepIndex3 - sepIndex2 - 1);

                        Console.WriteLine("Save Data!" + " \n" + "ID: " + data2 + " \n" + "Text: " + data3 + " \n");

                        List<string> txtVar = new List<string> { data2, data3 };
                        List<string> spVar = new List<string> { "@Id", "@Nombre_Pais" };


                        Console.WriteLine(txtVar [ 0 ]);
                        Console.WriteLine(txtVar [ 1 ]);
                        Console.WriteLine(spVar [ 0 ]);
                        Console.WriteLine(spVar [ 1 ]);

                        StoreProcedure.SaveData(spName, spVar, txtVar);
                    }
                    else if ( data.ToUpper().Contains("DATATABLEFETCHDATA") )
                    {
                        Console.WriteLine("DataTable Fetch!" + " \n");

                        var details = StoreProcedure.FetchDetails(spName);
                        sendData(DataFormatter.SerializeData(details), client.GetStream());
                    }
                    else if ( data.ToUpper().Contains("DELETEDATA") )
                    {
                        int sepIndex = data.IndexOf(":", StringComparison.Ordinal);
                        var data1 = data.Substring(0, sepIndex);

                        int sepIndex1 = data.IndexOf("-", StringComparison.Ordinal) - sepIndex;
                        var data2 = data.Substring(sepIndex + 1, sepIndex1 - 1);

                        int sepIndex2 = ( data.IndexOf("-", StringComparison.Ordinal) + 1 );
                        int sepIndex3 = ( data.IndexOf("_", StringComparison.Ordinal) + 1 );
                        var data3 = data.Substring(sepIndex2, sepIndex3 - sepIndex2 - 1);

                        Console.WriteLine("Eliminado" + " \n" + "ID: " + data2 + " \n" + "Text: " + data3 + " \n");

                        StoreProcedure.DeleteData(spName, data2);

                    }
                    else if ( data.ToUpper().Contains("CBOFETCHDATA") )
                    {
                        int sepIndex = data.IndexOf(":", StringComparison.Ordinal);
                        var data1 = data.Substring(0, sepIndex);

                        int sepIndex1 = data.IndexOf("-", StringComparison.Ordinal) - sepIndex;
                        var data2 = data.Substring(sepIndex + 1, sepIndex1 - 1);

                        int sepIndex2 = ( data.IndexOf("-", StringComparison.Ordinal) + 1 );
                        int sepIndex3 = ( data.IndexOf("_", StringComparison.Ordinal) + 1 );
                        var data3 = data.Substring(sepIndex2, sepIndex3 - sepIndex2 - 1);

                        Console.WriteLine("ComboBox Fetch!" + " \n" + "Command: " + data2 + " \n" + "SpName: " + data3 + " \n");

                        var details = StoreProcedure.FetchDetailsCBO(data3, data2);
                        sendData(DataFormatter.SerializeData(details), client.GetStream());

                    }
                }
                catch ( Exception exc )
                {
                    client.Dispose();
                    client.Close();
                }
            }
        }

        void sendData( byte [ ] data, NetworkStream stream )
        {
            int bufferSize = 1024;

            byte [ ] dataLength = BitConverter.GetBytes(data.Length);

            stream.Write(dataLength, 0, 4);

            int bytesSent = 0;
            int bytesLeft = data.Length;

            while ( bytesLeft > 0 )
            {
                int curDataSize = Math.Min(bufferSize, bytesLeft);

                stream.Write(data, bytesSent, curDataSize);

                bytesSent += curDataSize;
                bytesLeft -= curDataSize;
            }
        }

        private void manualMenu_Click( object sender, EventArgs e )
        {
            string filename = "manual.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void helpMenu_Click( object sender, EventArgs e )
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void optionsMenu_Click( object sender, EventArgs e )
        {
            Options options = new Options();
            options.ShowDialog();
        }

        private void settingsMenu_Click( object sender, EventArgs e )
        {
            Options options = new Options();
            options.ShowDialog();
        }
    }
}
