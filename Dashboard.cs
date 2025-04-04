using GestionEmpresa.clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmpresa
{
    public partial class Dashboard : Form
    {
        db.dbConnection DbConnection = new db.dbConnection();
        db.dbQuerys DbQuerys = new db.dbQuerys();

        double ingresosTotales = 0;
        double gastosTotales = 0;
        double beneficio = 0;
        public Dashboard()
        {
            InitializeComponent();
            ingresosTotales = DbQuerys.GetMontosTotales(1);
            gastosTotales = DbQuerys.GetMontosTotales(2);
            beneficio = ingresosTotales - gastosTotales;

            labelIngreso.Text = ingresosTotales.ToString();
            labelGasto.Text = gastosTotales.ToString();
            labelBeneficio.Text = beneficio.ToString();
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
            ExportadorExcel exportador = new ExportadorExcel();

            string carpetaRoot = Path.Combine(@"C:\Users\Mar\Documents\", "Ingresos-Gastos");
            Directory.CreateDirectory(carpetaRoot);
            string carpetaReporteGeneral = Path.Combine(@"C:\Users\Mar\Documents\Ingresos-Gastos\", "ReporteGeneral");
            Directory.CreateDirectory(carpetaReporteGeneral);
            string ruta = Path.Combine(carpetaReporteGeneral, "reporte-general-" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".xlsx");

            exportador.ExportarBalanceGeneral(int.Parse(labelIngreso.Text), int.Parse(labelGasto.Text), ruta);
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
