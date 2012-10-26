using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoPeçasUI;
using System.Data.SqlClient;
using System.Data.Sql;
using Camadas;

namespace Matriz
{
    public partial class Form_Venda : Form
    {

        BussinessLayer negocio = new BussinessLayer();
        
        //philipe
        public static List<Camadas.Peca> listaPecasSelecionadas;
        //Camadas.Peca pecaSelecionada;
        //
        public Form_Venda()
        {
            InitializeComponent();
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Cliente_Click(object sender, EventArgs e)
        {           


        }

        private void Form_Venda_Load(object sender, EventArgs e)
        {
            Tips.Dicas_Botões(bt_gravar, bt_Atualiza, bt_Deleta, Bt_busca1, bt_filtrar, bt_Sair);
            //consultaTabelaCliente();

        }

        private void bt_ConsultaPeca_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_PesquisarCliente_Click(object sender, EventArgs e)
        {
            Form_Cliente cliente = new Form_Cliente();
            cliente.ShowDialog();
        }

        /// <summary>
        /// Médoto para pesquisar o codigo do cliente, uma gridview é utilizada como auxiliar
        /// para receber a datatable. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"> se pressionado enter ele procura</param>
        private void tb_codCliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                DataTable _clienteEncontrado = negocio.pesquisaCliente(tb_codCliente.Text);
                dtgw_auxiliar.DataSource = _clienteEncontrado;
                if (dtgw_auxiliar.CurrentRow != null)
                {
                    tb_Cliente.Text = dtgw_auxiliar.CurrentRow.Cells[1].Value.ToString();
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                }
                else
                    MessageBox.Show("Cliente não localizado");
            }
        }
    }
}
