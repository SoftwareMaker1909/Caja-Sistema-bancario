using Caja_Sistema_bancario.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja_Sistema_bancario
{
    public partial class Historial_de__transacciones : Form
    {
        public Historial_de__transacciones()
        {
            InitializeComponent();
        }

        private void Historial_de__transacciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.transactions' Puede moverla o quitarla según sea necesario.
            this.transactionsTableAdapter.Fill(this.dataSet1.transactions);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.users' Puede moverla o quitarla según sea necesario.
            this.usersTableAdapter.Fill(this.dataSet1.users);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            FORMS.Menu menu = new FORMS.Menu();  
                this.Close();
            menu.Show();
        }
    }
}
