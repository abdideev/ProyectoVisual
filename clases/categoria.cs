using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa.clases
{
    class categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int Id_tipo { get; set; }

        public categoria(int id, string nombre, int id_tipo)
        {
            Id = id;
            Nombre = nombre;
            Id_tipo = id_tipo;
        }
    }
}
