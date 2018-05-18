using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Elektro
{
    public partial class frmAcerca : Form
    {
        public frmAcerca()
        {
            InitializeComponent();
        }

        private void Enlace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MelekSibrian/elektro");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAcerca_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "v"+ Application.ProductVersion;
        }
    }
}
