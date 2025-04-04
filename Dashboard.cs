using GestionEmpresa.clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmpresa
{
    public partial class Dashboard : Form
    {
        db.dbConnection DbConnection = new db.dbConnection();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("hh:mm:ss");
            this.label2.Text = DateTime.Now.ToLongDateString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingresos f3 = new Ingresos();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void GastosBtn_Click(object sender, EventArgs e)
        {
            Gastos f4 = new Gastos();
            this.Hide();
            f4.ShowDialog();
            this.Show();
        }

        private void ReporteBtn_Click(object sender, EventArgs e)
        {
            //Reporte f5 = new Reporte();
            //this.Hide();
            //f5.ShowDialog();
            //this.Show();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DbConnection.Disconnect();
                Application.Exit(); 
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
