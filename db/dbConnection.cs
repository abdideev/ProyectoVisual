using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmpresa.db
{
    public class dbConnection
    {
        NpgsqlConnection conn = new NpgsqlConnection();

        static String servidor;
        static String usuario;
        static String password;
        static String puerto;
        static String db;
        private static dbConnection Conn = null;

        String connectionString = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + db + ";";


        public dbConnection()
        {
            servidor = "localhost";
            usuario = "postgres";
            password = "Avilaneri29";
            puerto = "6000";
            db = "Example_db";

        }

        public NpgsqlConnection CreaeConexion()
        {
            NpgsqlConnection Cadena = new NpgsqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + servidor + ";Port=" + puerto + ";User Id=" + usuario + ";Password=" + password + ";Database=" + db + ";";
                Cadena.Open();

            }
            catch (Exception ex)
            {
                Cadena = null;
                MessageBox.Show("Error en la cadena de conexión: " + ex.Message);
            }
            return Cadena;
        }

        public static dbConnection getInstancia()
        {
            if (Conn == null)
            {
                Conn = new dbConnection();
            }
            return Conn;
        }
        public void Disconnect()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
