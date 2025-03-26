using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UtilitiesNet.Controls.FileProgress
{
    internal partial class FtpUIFileProgress : UserControl
    {
        private string _file;

        string file
        {
            get { return _file; }
            set { 
                _file = value;
                lblText.Text = _file;
            }
        }


        internal enum UploadState
        {
            Waiting,
            Uploading,
            Compleate,
            Error
        }

        public FtpUIFileProgress()
        {
            InitializeComponent();
            _file = string.Empty;
        }


        internal void setState(UploadState state, int uplProgres = 0, string error = null)
        {
            switch (state)
            {
                case UploadState.Waiting:
                    pktState.Visible = false;
                    prgb.Value = 0;
                    break;

                case UploadState.Uploading:
                    pktState.Visible = true;
                    pktState.Image = global::UtilitiesNet.Controls.Properties.Resources.ajax_loader;
                    prgb.Value = uplProgres;
                    break;

                case UploadState.Compleate:
                    pktState.Visible = true;
                    pktState.Image = global::UtilitiesNet.Controls.Properties.Resources.check2;
                    prgb.Value = 100;
                    break;

                case UploadState.Error:
                    pktState.Visible = true;
                    pktState.Image = global::UtilitiesNet.Controls.Properties.Resources.delete2;
                    prgb.Value = 100;
                    lblText.Text += String.Format(": Error({0})", error);
                    break;
            }
        }
    }
}
