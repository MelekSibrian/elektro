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
    public partial class Launcher : Form
    {
        int seg = 0;
        public Launcher()
        {
            InitializeComponent();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion;
            timer1.Enabled = true;            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 30)
            {
                Form1 Lanzar = new Form1();
                Lanzar.Show();
                this.Visible = false;
            }
        }
    }
}
