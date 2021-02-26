using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Clases.TCPStringTransferAsinc
{
    /// <summary> Conector TCP para el envío de datos, y recepción asincrona </summary>
    public class TcpStringTransferAsinc : IDisposable
    {

        #region · Variables

            /// <summary> Evento lanzado cuando se han recivido datos </summary>
            public event EventHandler DataReaded;

            string uid;

            int listenerPort;
            IPAddress listenerAddress;
            TcpListener listener;

            int endPort;
            IPAddress endAddress;

            /// <summary> Últimos datos recividos </summary>
            public String RawRecivedData { get; set; }


            string remoteEndPoint;

        #endregion


        #region · Constructores

        /// <summary>
        /// Conector TCP para el envío de datos, y recepción asincrona
        /// </summary>
        /// <param name="UId">Identificador único para la validación de la conexión</param>
        /// <param name="EndAddress">IP destino</param>
        /// <param name="EndPort">Puerto destino</param>
        /// <param name="ListenerAddress">IP de escucha</param>
        /// <param name="ListenerPort">Puerto de escucha</param>
        public TcpStringTransferAsinc(string UId, string EndAddress, int EndPort, string ListenerAddress, int ListenerPort)
        {
            uid = UId;
            endPort = EndPort;
            endAddress = IPAddress.Parse(EndAddress);
            listenerPort = ListenerPort;
            listenerAddress = IPAddress.Parse(ListenerAddress);
        }

        #endregion


        #region · Funciones

            /// <summary> Inicia la escucha </summary>
            public void StartListening()
            {
                if (listener != null) { StopListening(); }

                listener = new TcpListener(listenerAddress, listenerPort);
                listener.Start();
                AcceptClient(listener);
            }


            /// <summary> Finaliza la escucha </summary>
            public void StopListening()
            {
                listener.Stop();
                listener = null;
            }


            /// <summary>
            /// Envia una cadena a la ruta configurada
            /// </summary>
            /// <param name="message">Mensaje a enviar</param>
            public void SendString(string message)
            {
                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                SendData(data);
            }


            /// <summary>
            /// Envia los bytes a la ruta configurada
            /// </summary>
            /// <param name="message">Mensaje a enviar</param>
            public void SendData(Byte[] data)
            {
                TcpClient client = new TcpClient();
                try
                {
                    client.Connect(endAddress, endPort);

                    NetworkStream stream = client.GetStream();

                    // Send the message to the connected TcpServer. 
                    stream.Write(data, 0, data.Length);
                    stream.Close();
                    stream.Dispose();

                }
                finally
                {
                    client.Close();
                }
            }



            /// <summary>
            /// aceptación del cliente
            /// </summary>
            /// <param name="tcpListener"></param>
            private void AcceptClient(TcpListener tcpListener)
            {
                try
                {
                    Task<TcpClient> acceptTcpClientTask = Task.Factory.FromAsync<TcpClient>(tcpListener.BeginAcceptTcpClient, tcpListener.EndAcceptTcpClient, tcpListener);

                    // This allows us to accept another connection without a loop.
                    // Because we are within the ThreadPool, this does not cause a stack overflow.
                    acceptTcpClientTask.ContinueWith(task => { OnAcceptConnection(task.Result); AcceptClient(tcpListener); }, TaskContinuationOptions.OnlyOnRanToCompletion);
                }
                catch { }
            }


            /// <summary>
            /// Lectura del cliente
            /// </summary>
            /// <param name="tcpClient"></param>
            private void OnAcceptConnection(TcpClient tcpClient)
            {
                try
                {
                    remoteEndPoint = tcpClient.Client.RemoteEndPoint.ToString();
                    NetworkStream ns = tcpClient.GetStream();

                    byte[] bytes = new byte[tcpClient.Client.ReceiveBufferSize];
                    ns.Read(bytes, 0, bytes.Length);
                    RawRecivedData = Encoding.ASCII.GetString(bytes).Trim('\0');

                    ns.Close();
                    ns.Dispose();
                    tcpClient.Close();

                    if (DataReaded != null)
                    {
                        DataReaded(this, EventArgs.Empty);
                    }
                }
                catch { }
            }


            public void Dispose()
        {
            this.StopListening();
        }

        #endregion


    }
}
