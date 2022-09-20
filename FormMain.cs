using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Cartola
{
    public partial class FormMain : Form
    {
        Mercado mercado;

        public FormMain(Mercado mercado)
        {
            InitializeComponent();
            this.mercado = mercado;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
