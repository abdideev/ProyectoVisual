using System;
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
    public partial class Gastos : Form
    {
        public Gastos()
        {
            InitializeComponent();
        }

        #region "Variables"
        int vCodigo_Ingreso = 0;
        int vCodigo_ca = 0;
        int vCodigo_pg = 0;
        int nEstadoguardar = 0;
        #endregion

        #region "Metodos"
        private void LimpiarTexto()
        {
            txtConcepto.Clear();
            txtMonto.Clear();
            txtDescripcion.Clear();
        }

        private void EstadoTexto(bool lEstado)
        {
            txtConcepto.Enabled = lEstado;
            txtMonto.Enabled = lEstado;
            dpFecha.Enabled = lEstado;
            cmbCategoria.Enabled = lEstado;
            cmbPago.Enabled = lEstado;
            txtDescripcion.Enabled = lEstado;
        }

        private void EstadoBotonesProcesos(bool lEstado)
        {
            btnCancelar.Visible = lEstado;
            btnGuardar.Visible = lEstado;
        }

        private void EstadoBotonesPrincipales(bool lEstado)
        {
            btnNuevo.Enabled = lEstado;
            btnActualizar.Enabled = lEstado;
            btnEliminar.Enabled = lEstado;
            btnReporte.Enabled = lEstado;
            btnRegresar.Enabled = lEstado;
        }
        #endregion

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelHora.Text = DateTime.Now.ToString("hh:mm:ss");
            this.labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nEstadoguardar = 1;
            this.LimpiarTexto();
            this.EstadoTexto(true);
            this.EstadoBotonesProcesos(true);
            this.EstadoBotonesPrincipales(false);
            txtConcepto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nEstadoguardar = 0;
            this.LimpiarTexto();
            this.EstadoTexto(false);
            this.EstadoBotonesProcesos(false);
            this.EstadoBotonesPrincipales(true);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nEstadoguardar = 2;
            this.LimpiarTexto();
            this.EstadoTexto(true);
            this.EstadoBotonesProcesos(true);
            this.EstadoBotonesPrincipales(false);
            txtConcepto.Focus();
        }
    }
}
