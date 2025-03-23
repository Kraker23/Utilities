using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities.Clases.TCPStringTransferAsinc;

namespace Utilities.Controls.TCP
{
    public partial class frmTCPServer : Form
    {
        TcpStringTransferAsinc transfer;

        public frmTCPServer()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (transfer != null)
            {
                transfer.StopListening();
                transfer.Dispose();
                transfer = null;
            }


            try
            {
                transfer = new TcpStringTransferAsinc(string.Empty, string.Empty, 0, txtIp.Text, int.Parse(txtPort.Text));
                transfer.ClientChange += transfer_CambioCliente;
                transfer.DataReaded += transfer_DataReaded;
                transfer.StartListening();

                lblLastClient.Text = "---";
                txtRecibido.Text = string.Empty;

                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        void transfer_DataReaded(object sender, EventArgs e)
        {
            cambioTextoRecibido(transfer.RawRecivedData);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (transfer != null)
            {
                transfer.StopListening();

                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void btnSendToCli_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtEnvio.Text))
            {
                try
                {
                    transfer.SendDataToLastServerClient(txtEnvio.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void transfer_CambioCliente(object sender, EventArgs e)
        {
            if (transfer.LastServerClient == null)
            {
                cambioLastCliText("---");
            }
            else
            {
                cambioLastCliText(transfer.LastServerClient.Client.RemoteEndPoint.ToString());
            }
        }

        delegate void cambioLastCliTextCallBack(string text);
        void cambioLastCliText(string text)
        {
            if (lblLastClient.InvokeRequired)
            {
                var inv = new cambioLastCliTextCallBack(cambioLastCliText);
                lblLastClient.Invoke(inv,new object[] {text});
            }
            else
            {
                lblLastClient.Text = text;
            }
        }

        delegate void cambioTextoRecibidoCallBack(string text);
        void cambioTextoRecibido(string text)
        {
            if (txtRecibido.InvokeRequired)
            {
                var inv = new cambioTextoRecibidoCallBack(cambioTextoRecibido);
                txtRecibido.Invoke(inv, new object[] { text });
            }
            else
            {
                txtRecibido.Text = txtRecibido.Text + text + Environment.NewLine;
            }
        }

    }
}
