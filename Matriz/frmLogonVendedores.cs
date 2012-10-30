using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Camadas;

namespace Matriz
{
    public partial class frmLogonVendedores : Form
    {
        BussinessLayer negocio = new BussinessLayer();        
        private bool statusLogon;
        public bool StatusLogon
        {
            get { return statusLogon; }
        }
        
        
        public frmLogonVendedores()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            pn_AlterarSenha.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pn_AlterarSenha.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senha = "";
            dtg_Auxiliar.DataSource = negocio.ConsultaLogon(tb_login.Text);
            if (dtg_Auxiliar.CurrentRow != null)
            {
                    senha = dtg_Auxiliar.CurrentRow.Cells[2].Value.ToString();
               if (senha.Equals(tb_senha.Text))
                {
                    frmVenda venda = new frmVenda();
                    venda.ID_vendedor = negocio.ConsultaIdVendedor(tb_login.Text);
                    venda.ShowDialog();
                    this.Close();
                }
               else
               {
                   MessageBox.Show("Senha incorreta, por favor verifique!");
               }
            }
            else
            {
                MessageBox.Show("Senha incorreta, por favor verifique!");
            }

        }
    }
}
