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
    public partial class Mostrar : Form
    {
        int j = 0;
        Clientes[] clientesRegistrados = new Clientes[100];
        public Mostrar(Clientes [] cliente, int i)
        {
            InitializeComponent();
            j = i;
            clientesRegistrados = cliente;
        }
    }
}
