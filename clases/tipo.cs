using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa.clases
{
    class tipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public tipo(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
