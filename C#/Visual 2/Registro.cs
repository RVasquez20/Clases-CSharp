using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_2
{
    public partial class Registro : Form
    {
        Clientes[] clientesRegistrados = new Clientes[100];
        int i = 0;
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            Clientes cli = new Clientes();
            cli.Nombre = txt_Nombre.Text;
            cli.Apellido = txt_Apellido.Text;
            cli.Edad = int.Parse(txt_Edad.Text);
            clientesRegistrados[i] = cli;
            Mostrar v2 = new Mostrar(clientesRegistrados,i);
        }
    }
}
