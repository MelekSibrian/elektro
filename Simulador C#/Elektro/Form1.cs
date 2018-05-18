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
    public partial class Form1 : Form
    {
        ElegirNodos Ventana = new ElegirNodos();
        int cable_n = 0; int cable_p = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

            private void subBateria_Click(object sender, EventArgs e)
        {
            Ventana.ShowDialog();
            Bateria(Ventana.cmbNodoI.Text, Ventana.cmbNodoF.Text);
        }
        public void Bateria(String Nodo1, String Nodo2) {
            Tabla.Rows.Add("Bateria", Nodo1, Nodo2, "Amarillo");
            btnEliminar.Enabled=true;
            Nodo1 = "lbl_" + Nodo1;
            Nodo2 = "lbl_" + Nodo2;
            Label lbl = this.Controls.Find(Nodo1, true).FirstOrDefault() as Label;
            lbl.ForeColor = Color.Yellow;
            Label lbl2 = this.Controls.Find(Nodo2, true).FirstOrDefault() as Label;
            lbl2.ForeColor = Color.Yellow;
            lbl.Font = new Font(lbl.Font, FontStyle.Bold);
            lbl2.Font = new Font(lbl.Font, FontStyle.Bold);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que quiere eliminar este elemento?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String Nodo1 = "lbl_" + Tabla.CurrentRow.Cells[1].Value.ToString();
                String Nodo2 = "lbl_" + Tabla.CurrentRow.Cells[2].Value.ToString();
                Label lbl = this.Controls.Find(Nodo1, true).FirstOrDefault() as Label;
                lbl.ForeColor = Color.Black;
                lbl.Font = new Font(lbl.Font, FontStyle.Regular);

                Label lbl2 = this.Controls.Find(Nodo2, true).FirstOrDefault() as Label;
                lbl2.ForeColor = Color.Black;
                lbl2.Font = new Font(lbl.Font, FontStyle.Regular);
                Tabla.Rows.Remove(Tabla.CurrentRow);
                if (Tabla.Rows.Count <= 0)
                    btnEliminar.Enabled = false;
            }
        }

        private void subCapacitor_Click(object sender, EventArgs e)
        {
            Ventana.ShowDialog();
            Capacitor(Ventana.cmbNodoI.Text, Ventana.cmbNodoF.Text);
        }
        public void Capacitor(String Nodo1, String Nodo2)
        {
            Tabla.Rows.Add("Capacitor", Nodo1, Nodo2, "Verde");
            btnEliminar.Enabled = true;
            Nodo1 = "lbl_" + Nodo1;
            Nodo2 = "lbl_" + Nodo2;
            Label lbl = this.Controls.Find(Nodo1, true).FirstOrDefault() as Label;
            lbl.ForeColor = Color.Green;
            Label lbl2 = this.Controls.Find(Nodo2, true).FirstOrDefault() as Label;
            lbl2.ForeColor = Color.Green;
            lbl.Font = new Font(lbl.Font, FontStyle.Bold);
            lbl2.Font = new Font(lbl.Font, FontStyle.Bold);
        }

        private void subLED_Click(object sender, EventArgs e)
        {
            Ventana.ShowDialog();
            LED(Ventana.cmbNodoI.Text, Ventana.cmbNodoF.Text);
        }
        public void LED(String Nodo1, String Nodo2)
        {
            try
            {
                if ((Nodo1.Contains("nodo")) && (Nodo2.Contains("nodo")))
                {
                    Nodo1 = "lbl_" + Nodo1;
                    Nodo2 = "lbl_" + Nodo2;
                    Label lbl = this.Controls.Find(Nodo1, true).FirstOrDefault() as Label;
                    lbl.ForeColor = Color.Blue;
                    Label lbl2 = this.Controls.Find(Nodo2, true).FirstOrDefault() as Label;
                    lbl2.ForeColor = Color.Blue;
                    Tabla.Rows.Add("LED", Nodo1.Substring(4), Nodo2.Substring(4), "Azul");
                    btnEliminar.Enabled = true;
                    lbl.Font = new Font(lbl.Font, FontStyle.Bold);
                    lbl2.Font = new Font(lbl.Font, FontStyle.Bold);
                    //Verificar si tiene corriente
                    if ((cable_n == int.Parse(Nodo1.Substring(11))) && (cable_p == int.Parse(Nodo2.Substring(11))))
                    {
                        //Colocar color a la fila
                        Tabla.Rows[Tabla.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Blue;
                        MessageBox.Show("El LED esta recibiendo correctamente carga positiva y negativa", "LED Encendido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Tabla.Rows[Tabla.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show("El LED no esta recibiendo correctamente carga positiva y negativa", "LED Apagado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("No puede conectar el LED en el panel del bus", "Nodo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch { MessageBox.Show("El nodo ingresado es invalido", "Nodo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void subResistencia_Click(object sender, EventArgs e)
        {
            Ventana.ShowDialog();
            Resistencia(Ventana.cmbNodoI.Text, Ventana.cmbNodoF.Text);
        }
        public void Resistencia(String Nodo1, String Nodo2)
        {
            Tabla.Rows.Add("Resistencia", Nodo1, Nodo2, "Marron");
            btnEliminar.Enabled = true;
            Nodo1 = "lbl_" + Nodo1;
            Nodo2 = "lbl_" + Nodo2;
            Label lbl = this.Controls.Find(Nodo1, true).FirstOrDefault() as Label;
            lbl.ForeColor = Color.Maroon;
            Label lbl2 = this.Controls.Find(Nodo2, true).FirstOrDefault() as Label;
            lbl2.ForeColor = Color.Maroon;
            lbl.Font = new Font(lbl.Font, FontStyle.Bold);
            lbl2.Font = new Font(lbl.Font, FontStyle.Bold);
        }

        private void subCable_Click(object sender, EventArgs e)
        {
            Ventana.ShowDialog();
            Cables(Ventana.cmbNodoI.Text, Ventana.cmbNodoF.Text, e);
        }
        public void Cables(String Nodo1, String Nodo2, EventArgs e)
        {
            try
            {
                if ((Nodo1.Contains("bus")) && (Nodo2.Contains("nodo")))
                {
                    if (Nodo1.Contains("neg"))
                        cable_n = int.Parse(Nodo2.Substring(7));
                    if (Nodo1.Contains("pos"))
                        cable_p = int.Parse(Nodo2.Substring(7));
                    Nodo1 = "lbl_" + Nodo1;
                    Nodo2 = "lbl_" + Nodo2;
                    Label lbl = this.Controls.Find(Nodo1, true).FirstOrDefault() as Label;
                    lbl.ForeColor = Color.Orange;
                    Label lbl2 = this.Controls.Find(Nodo2, true).FirstOrDefault() as Label;
                    lbl2.ForeColor = Color.Orange;
                    Tabla.Rows.Add("Cable", Nodo1.Substring(4), Nodo2.Substring(4), "Naranja");
                    btnEliminar.Enabled = true;
                    lbl.Font = new Font(lbl.Font, FontStyle.Bold);
                    lbl2.Font = new Font(lbl.Font, FontStyle.Bold);
                }
                else
                    MessageBox.Show("No puede conectar el LED en el panel del bus", "Nodo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch { MessageBox.Show("El nodo ingresado es invalido", "Nodo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            frmAcerca Acercade = new frmAcerca();
            Acercade.ShowDialog();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}