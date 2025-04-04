using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa.clases
{
    class usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cuenta { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        public usuario(int id, string nombre, string apellidos, string cuenta, string contraseña, string rol)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Cuenta = cuenta;
            Contraseña = contraseña;
            Rol = rol;
        }
    }
}
