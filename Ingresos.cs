﻿using GestionEmpresa.clases;
using GestionEmpresa.db;
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
    public partial class Ingresos : Form
    {

        db.dbQuerys Dbquerys = new db.dbQuerys();


        List<categoria> categoriasList = new List<categoria>();
        List<metodo_pago> metodosPagoList = new List<metodo_pago>();
        List<transaccionDetallada> transaccionesList = new List<transaccionDetallada>();
        public Ingresos()
        {
            InitializeComponent();

            categoriasList = Dbquerys.GetCategorias(1);
            transaccionesList = Dbquerys.GetTransactions();
            metodosPagoList = Dbquerys.GetMetodoPago();

            foreach (var categoria in categoriasList)
            {
               cmbCategoriaI.Items.Add(categoria.Nombre);
            }

            foreach (var metodo in metodosPagoList)
            {
                cmbPagoI.Items.Add(metodo.Nombre);
            }
            
            dgvListado.DataSource = transaccionesList;
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
            cmbCategoriaI.Enabled = lEstado;
            cmbPagoI.Enabled = lEstado;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(db.dbQuerys.user1.Id.ToString());
            int usuario_id = db.dbQuerys.user1.Id;
            int categoria_id = 0;
            int metodo_pago_id = 0;
            string concepto = txtConcepto.Text;
            string monto = txtMonto.Text;
            string descripcion = txtDescripcion.Text;
            string fecha = dpFecha.Value.ToString("yyyy-MM-dd");
            string categoria_nombre = cmbCategoriaI.Text;
            string tipo_pago = cmbPagoI.Text;

            foreach (var categoria in categoriasList)
            {
                if (categoria.Nombre.Equals(categoria_nombre))
                {
                    categoria_id = categoria.Id;                    
                }
            }

            foreach (var metodo in metodosPagoList)
            {
                if (metodo.Nombre.Equals(tipo_pago))
                {
                    metodo_pago_id = metodo.Id;
                }
            }

            MessageBox.Show(metodo_pago_id.ToString());

            Dbquerys.createTransaction(usuario_id, categoria_id, metodo_pago_id, concepto, Convert.ToDouble(monto), Convert.ToDateTime(fecha), descripcion);
        }
    }
}
