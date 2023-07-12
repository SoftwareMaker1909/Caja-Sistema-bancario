using Caja_Sistema_bancario.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja_Sistema_bancario.FORMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            LoginCommand login = new LoginCommand();
            login.UserName = NombreUsuario.Text;
            Menu menu = new Menu(); 
       login.Password = ClaveUsuario.Text   ;

            if (login.comprobar() == false)
            {
                MessageBox.Show("Error, dato incorrectos");
            }
            else
            {
                Program.con.Open();
                this.Visible = false;
                menu.Show();
            }
        }
    }
}
