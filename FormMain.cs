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
using CartolaDesktop.Cartola;

namespace CartolaDesktop
{
    public partial class FormMain : Form
    {
        Mercado mercado;
        Atletas atletas;
        private BindingSource _bindingSource;

        public FormMain(Mercado mercado)
        {            
            Atletas atletas = new Atletas();
            atletas.atletas = mercado.atletas;
            atletas.posicoes = mercado.posicoes; 
            atletas.clubes = mercado.clubes;
            atletas.dictStatus = mercado.status;

            _bindingSource = new BindingSource();
            _bindingSource.DataSource = atletas.getAtletas();
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bindingSource.DataSource;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
