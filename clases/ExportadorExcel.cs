using GestionEmpresa.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GestionEmpresa.clases
{
    class ExportadorExcel
    {
        public void ExportarConInterop(List<transaccionDetallada> transaccionesDetalladas, string rutaArchivo)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = false;

            Excel.Workbook libro = excelApp.Workbooks.Add();
            Excel.Worksheet hoja = (Excel.Worksheet)libro.Sheets[1];
            hoja.Name = "Transacciones";

            hoja.Cells[1, 1] = "ID";
            hoja.Cells[1, 2] = "Concepto";
            hoja.Cells[1, 3] = "Monto";
            hoja.Cells[1, 4] = "Fecha";
            hoja.Cells[1, 5] = "Descripción";
            hoja.Cells[1, 6] = "Usuario";
            hoja.Cells[1, 7] = "Categoría";
            hoja.Cells[1, 8] = "Método Pago";

            int fila = 2;
            foreach (var t in transaccionesDetalladas)
            {
                hoja.Cells[fila, 1] = t.IdTransaccion;
                hoja.Cells[fila, 2] = t.Concepto;
                hoja.Cells[fila, 3] = t.Monto;
                hoja.Cells[fila, 4] = t.Fecha.ToShortDateString();
                hoja.Cells[fila, 5] = t.Descripcion;
                hoja.Cells[fila, 6] = t.Usuario;
                hoja.Cells[fila, 7] = t.Categoria;
                hoja.Cells[fila, 8] = t.MetodoPago;
                fila++;
            }

            hoja.Cells[fila, 1] = "Total";
            hoja.Cells[fila, 3] = "=SUM(C2:C" + (fila - 1) + ")"; 

            libro.SaveAs(rutaArchivo);
            libro.Close();
            excelApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(hoja);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(libro);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            MessageBox.Show("Archivo Excel guardado correctamente en: " + rutaArchivo);
        }

        public void ExportarBalanceGeneral(int ingresos, int gastos, string rutaArchivo)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = false;

            Excel.Workbook libro = excelApp.Workbooks.Add();
            Excel.Worksheet hoja = (Excel.Worksheet)libro.Sheets[1];
            hoja.Name = "BalanceGeneral";

            hoja.Cells[1, 1] = "Ingresos";
            hoja.Cells[1, 2] = "Gastos";

            hoja.Cells[1, 3] = "Beneficios";

            hoja.Cells[2, 1] = ingresos;
            hoja.Cells[2, 2] = gastos;
            hoja.Cells[2, 3] = "=A2-B2";

            libro.SaveAs(rutaArchivo);
            libro.Close();
            excelApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(hoja);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(libro);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            MessageBox.Show("Archivo Excel guardado correctamente en: " + rutaArchivo);
        }
    }
}
