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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Retiros retiros = new Retiros();
            retiros.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Transferencias transferencias = new Transferencias();
            transferencias.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Deposito deposito = new Deposito(); 
            deposito.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            ENTRADA_SALIDA entrada_salida = new ENTRADA_SALIDA();
            entrada_salida.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Prestamo prestamo = new Prestamo();
            prestamo.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Historial_de__transacciones historial_De__Transacciones = new Historial_de__transacciones();
            historial_De__Transacciones.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
