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
    public partial class frmPrincipal : Form
    {
        private DateTime Tempo_Atual;
        private BussinessLayer Negociacao = new BussinessLayer();
        public frmPrincipal()
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
            frmCliente frm = new frmCliente();
            frm.ShowDialog();
        }

        private void vENDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda frm = new frmVenda();
            frm.ShowDialog();
        }

        private void peçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeca frm = new frmPeca();
            frm.Show();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeiculo fmr = new frmVeiculo();
            fmr.ShowDialog();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria();
            frm.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor frm = new frmFornecedor();
            frm.ShowDialog();
        }
        
        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elaborado em C# por\n\n   Carlos A. Minafra Jr.\n   Luis Ribeiro \n   Phillipe Perdigão \n\nCopyrigths 2012", "Créditos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.ShowDialog();
        }

        private void gerenciarVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedor frm = new frmVendedor();
            frm.ShowDialog();
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            //menuStrip1.Visible = false;
            //frmLoad frm = new frmLoad();
            //frm.ShowDialog();
            //menuStrip1.Visible = true;
        }

        private void gRAVARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report frm = new Report();
            frm.ShowDialog();
        }
    }
}