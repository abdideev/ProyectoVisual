using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa.clases
{
    class transaccion
    {
        public int IdTransaccion { get; set; }
        public string Concepto { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int IdUsuario { get; set; }
        public int IdCategoria { get; set; }
        public int IdMetodoPago { get; set; }

        // Constructor que inicializa todos los atributos
        public transaccion(int idTransaccion, string concepto, decimal monto, DateTime fecha, string descripcion, int idUsuario, int idCategoria, int idMetodoPago)
        {
            IdTransaccion = idTransaccion;
            Concepto = concepto;
            Monto = monto;
            Fecha = fecha;
            Descripcion = descripcion;
            IdUsuario = idUsuario;
            IdCategoria = idCategoria;
            IdMetodoPago = idMetodoPago;
        }
    }
}
