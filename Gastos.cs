using GestionEmpresa.clases;
using GestionEmpresa.db;
using System;
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
    public partial class Gastos : Form
    {
        db.dbQuerys Dbquerys = new db.dbQuerys();

        List<categoria> categoriasList = new List<categoria>();
        List<metodo_pago> metodosPagoList = new List<metodo_pago>();
        List<transaccionDetallada> transaccionesList = new List<transaccionDetallada>();


        int id_transaccion;
        public Gastos()
        {
            InitializeComponent();

            categoriasList = Dbquerys.GetCategorias(2);
            transaccionesList = Dbquerys.GetTransactions("Gasto");
            metodosPagoList = Dbquerys.GetMetodoPago();


            foreach (var categoria in categoriasList)
            {
                cmbCategoria.Items.Add(categoria.Nombre);
            }

            foreach (var metodo in metodosPagoList)
            {
                cmbPago.Items.Add(metodo.Nombre);
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

            if (dgvListado.Rows.Count > 0 && dgvListado.CurrentRow != null)
            {
                id_transaccion = Convert.ToInt32(dgvListado.CurrentRow.Cells["IdTransaccion"].Value);
                txtConcepto.Text = dgvListado.CurrentRow.Cells["Concepto"].Value.ToString();
                txtMonto.Text = dgvListado.CurrentRow.Cells["Monto"].Value.ToString();
                txtDescripcion.Text = dgvListado.CurrentRow.Cells["Descripcion"].Value.ToString();
                dpFecha.Value = Convert.ToDateTime(dgvListado.CurrentRow.Cells["Fecha"].Value);
                cmbCategoria.Text = dgvListado.CurrentRow.Cells["Categoria"].Value.ToString();
                cmbPago.Text = dgvListado.CurrentRow.Cells["MetodoPago"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una transacción para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.EstadoTexto(true);
            this.EstadoBotonesProcesos(true);
            this.EstadoBotonesPrincipales(false);
            txtConcepto.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.labelHora.Text = DateTime.Now.ToString("hh:mm:ss");
            this.labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (nEstadoguardar == 1)
            {
                CrearTransaccionGasto();
            }
            if (nEstadoguardar == 2)
            {
                ActualizarTransaccionGasto();
            }
        }

        private void Gastos_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count > 0 && dgvListado.CurrentRow != null)
            {
                int id_transaccion = Convert.ToInt32(dgvListado.CurrentRow.Cells["IdTransaccion"].Value);

                dbQuerys db = new dbQuerys();
                string resultado = db.DeleteTransaction(id_transaccion);

                MessageBox.Show(resultado, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvListado.DataSource = db.GetTransactions("Gasto");
            }
            else
            {
                MessageBox.Show("Seleccione una transacción para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CrearTransaccionGasto()
        {
            int usuario_id = db.dbQuerys.user1.Id;
            int categoria_id = 0;
            int metodo_pago_id = 0;
            string concepto = txtConcepto.Text;
            string monto = txtMonto.Text;
            string descripcion = txtDescripcion.Text;
            string fecha = dpFecha.Value.ToString("yyyy-MM-dd");
            string categoria_nombre = cmbCategoria.Text;
            string tipo_pago = cmbPago.Text;

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


            Dbquerys.createTransaction(usuario_id, categoria_id, metodo_pago_id, concepto, Convert.ToDouble(monto), Convert.ToDateTime(fecha), descripcion);
            this.LimpiarTexto();
            this.EstadoTexto(false);
            this.EstadoBotonesProcesos(false);
            this.EstadoBotonesPrincipales(true);
            dgvListado.DataSource = Dbquerys.GetTransactions("Gasto");
        }

        public void ActualizarTransaccionGasto()
        {
            if (dgvListado.Rows.Count > 0 && dgvListado.CurrentRow != null)
            {
                int id_transaccion = Convert.ToInt32(dgvListado.CurrentRow.Cells["IdTransaccion"].Value);
                int usuario_id = db.dbQuerys.user1.Id;
                int categoria_id = 0;
                int metodo_pago_id = 0;
                string concepto = txtConcepto.Text;
                double monto;
                if (!double.TryParse(txtMonto.Text, out monto))
                {
                    MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime fecha = dpFecha.Value;
                string descripcion = txtDescripcion.Text;
                string categoria_nombre = cmbCategoria.Text;
                string tipo_pago = cmbPago.Text;

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

                Dbquerys.UpdateTransaction(id_transaccion, usuario_id, categoria_id, metodo_pago_id, concepto, monto, fecha, descripcion);

                dgvListado.DataSource = Dbquerys.GetTransactions("Gasto");
            }
            else
            {
                MessageBox.Show("Seleccione una transacción para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            string carpetaRoot = Path.Combine(@"C:\Users\Mar\Documents\", "Ingresos-Gastos");
            Directory.CreateDirectory(carpetaRoot);
            string carpetaGastos = Path.Combine(@"C:\Users\Mar\Documents\Ingresos-Gastos\", "Gastos");
            Directory.CreateDirectory(carpetaGastos);
            string ruta = Path.Combine(carpetaGastos, "reporte-gastos-" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".xlsx");

            ExportadorExcel exportador = new ExportadorExcel();
            exportador.ExportarConInterop(transaccionesList, ruta);
        }
    }
}
