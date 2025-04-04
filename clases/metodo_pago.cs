using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa.clases
{
    class metodo_pago
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public metodo_pago(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
