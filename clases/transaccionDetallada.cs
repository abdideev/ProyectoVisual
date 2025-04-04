using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa.db
{
    class transaccionDetallada
    {
        public int IdTransaccion { get; set; }
        public string Concepto { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public string Categoria { get; set; }
        public string MetodoPago { get; set; }

        // Constructor que inicializa todos los atributos
        public transaccionDetallada(int idTransaccion, string concepto, decimal monto, DateTime fecha, string descripcion, string usuario, string categoria, string metodoPago)
        {
            IdTransaccion = idTransaccion;
            Concepto = concepto;
            Monto = monto;
            Fecha = fecha;
            Descripcion = descripcion;
            Usuario = usuario;
            Categoria = categoria;
            MetodoPago = metodoPago;
        }
    }
}
