using GestionEmpresa.clases;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const string saludo = "Hola Mundo";
            const string saludo2 = "Comprobar cambio de cuenta";
            String ivan = "hola gays";
        }

        private async void EntrarBtn_Click(object sender, EventArgs e)
        {
            string noCuenta = NoCuentaTxt.Text;
            string nip = NIPTxt.Text;

            db.dbQuerys dbquerys = new db.dbQuerys();

            usuario usuarioAutenticado = await dbquerys.Login(noCuenta, nip);

                if (usuarioAutenticado != null)
                {

                    MessageBox.Show("Bienvenido");
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Error de usuario o contraseña");
                    return;
                }

        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
