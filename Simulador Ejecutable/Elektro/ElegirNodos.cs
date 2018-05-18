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
    public partial class ElegirNodos : Form
    {
        public String Objeto = "";
        public ElegirNodos()
        {
            InitializeComponent();
        }

        private void ElegirNodos_Load(object sender, EventArgs e)
        {
            for (int x = 1; x <= 30; x++)
            {
                cmbNodoI.Items.Add("busT_neg_"+x);
                cmbNodoF.Items.Add("busT_neg_" + x);
            }
            for (int x = 1; x <= 30; x++)
            {
                cmbNodoI.Items.Add("busT_pos_" + x);
                cmbNodoF.Items.Add("busT_pos_" + x);
            }
            for (int x = 1; x <= 30; x++)
            {
                cmbNodoI.Items.Add("nodo_a_" + x);
                cmbNodoF.Items.Add("nodo_a_" + x);
            }
            for (int x = 1; x <= 30; x++)
            {
                cmbNodoI.Items.Add("nodo_b_" + x);
                cmbNodoF.Items.Add("nodo_b_" + x);
            }
            for (int x = 1; x <= 30; x++)
            {
                cmbNodoI.Items.Add("nodo_c_" + x);
                cmbNodoF.Items.Add("nodo_c_" + x);
            }
            for (int x = 1; x <= 30; x++)
            {
                cmbNodoI.Items.Add("nodo_d_" + x);
                cmbNodoF.Items.Add("nodo_d_" + x);
            }
            for (int x = 1; x <= 30; x++)
            {
                cmbNodoI.Items.Add("nodo_e_" + x);
                cmbNodoF.Items.Add("nodo_e_" + x);
            }
            for (int x = 1; x <= 30; x++)
            {
                cmbNodoI.Items.Add("nodo_f_" + x);
                cmbNodoF.Items.Add("nodo_f_" + x);
            }
            for (int x = 1; x <= 30; x++)
            {
                cmbNodoI.Items.Add("nodo_g_" + x);
                cmbNodoF.Items.Add("nodo_g_" + x);
            }
            for (int x = 1; x <= 30; x++)
            {
                cmbNodoI.Items.Add("nodo_h_" + x);
                cmbNodoF.Items.Add("nodo_h_" + x);
            }
            for (int x = 1; x <= 30; x++)
            {
                cmbNodoI.Items.Add("nodo_i_" + x);
                cmbNodoF.Items.Add("nodo_i_" + x);
            }
            for (int x = 1; x <= 30; x++)
            {
                cmbNodoI.Items.Add("nodo_j_" + x);
                cmbNodoF.Items.Add("nodo_j_" + x);
            }
            cmbNodoI.SelectedIndex = 0;
            cmbNodoF.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AutoCompletar() { }
    }
}
