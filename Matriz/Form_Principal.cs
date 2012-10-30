using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Camadas;

namespace Matriz
{
    public partial class Form_Principal : Form
    {
        private DateTime Tempo_Atual;
        private BussinessLayer Negociacao = new BussinessLayer();
        public Form_Principal()
        {
            InitializeComponent();
        }

             
        private void timer1_Tick(object sender, EventArgs e)
        {
            Tempo_Atual = DateTime.Now;
            lb_status_time.Text = Tempo_Atual.ToLongDateString() + "  -  " + Tempo_Atual.ToLongTimeString();
            //lb_status_numpeca.Text = Negociacao.contapeca().ToString();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cliente frm = new Form_Cliente();
            frm.ShowDialog();
        }

        private void vENDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Venda frm = new Form_Venda();
            frm.ShowDialog();
        }

        private void peçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Pecas frm = new Form_Pecas();
            frm.Show();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Veiculos fmr = new Form_Veiculos();
            fmr.ShowDialog();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Categorias frm = new Form_Categorias();
            frm.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Fornecedor frm = new Form_Fornecedor();
            frm.ShowDialog();
        }
        
        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elaborado em C# por\n\n   Carlos A. Minafra Jr.\n   Luis Ribeiro \n   Phillipe Perdigão \n\nCopyrigths 2012", "Créditos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Cliente frm = new Form_Cliente();
            frm.ShowDialog();
        }

        private void gerenciarVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Vendedor frm = new Form_Vendedor();
            frm.ShowDialog();
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            Form_Load frm = new Form_Load();
            frm.ShowDialog();
            menuStrip1.Visible = true;
        }

        private void gRAVARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report frm = new Report();
            frm.ShowDialog();
        }
    }
}