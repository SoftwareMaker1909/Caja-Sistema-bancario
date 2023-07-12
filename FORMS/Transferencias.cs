using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja_Sistema_bancario.FORMS
{
    public partial class Transferencias : Form
    {
        public Transferencias()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            this.Close();
            mainMenu.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float monto_origen, monto_beneficiario;
                string nombre_origen, nombre_beneficiario;
                int id_cuenta_origen, id_cuenta_beneficiario;
                int cuenta = int.Parse(textBox1.Text);

                using (SqlCommand command = new SqlCommand("ppGetdataclient", Program.con))
                {
                    command.Parameters.AddWithValue("@id_cuenta", cuenta);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        id_cuenta_origen = reader.GetInt32(0);
                        nombre_origen = reader.GetString(1);
                        monto_origen = reader.GetFloat(2);
                    }
                    else
                    {
                        MessageBox.Show("La cuenta no existe");
                    }
                }
            }
            catch (Exception ex)
            {
                textBox1.Clear();
                MessageBox.Show("entrada incorrecta" + ex.Message);
            }

            

            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
