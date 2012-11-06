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
    public partial class frmVenda : Form
    {
        ItensVenda _ItemdeVenda;
        Controle obj_controle = new Controle();
        BussinessLayer negocio = new BussinessLayer();
        Venda obj_venda = new Venda();
        private string id_Vendedor;

        public string ID_vendedor
        {
            get { return id_Vendedor; }
            set { id_Vendedor = value; }
        }
        
        
        //philipe
        public static List<Camadas.Peca> listaPecasSelecionadas;
        //Camadas.Peca pecaSelecionada;
        //


        private void GravaVendaTemp()
        {
            try
            {
                obj_venda.IDVendedor = int.Parse(tb_CondVendedor.Text);
                obj_venda.DataVenda = DateTime.Now;
                obj_venda.IDCliente = int.Parse(tb_codCliente.Text);
                obj_venda.PrecoTotal = 0.00F;
                obj_venda.Desconto = 0.00F;
                obj_controle.ControleInserir(obj_venda);
            }
            catch (Exception)
            {

                throw;
            } 
        }        
        public frmVenda()
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
            ID_vendedor = "2";
            tb_CondVendedor.Text = id_Vendedor;
            int Proximavenda;
            string ultimavenda;
            Tips.Dicas_Botões(bt_gravar, bt_Atualiza, bt_Deleta, Bt_busca1, bt_filtrar, bt_Sair);
            //consultaTabelaCliente();
            tb_IDVenda.Text = negocio.ID_UltimaVenda();
            if (tb_IDVenda.Text == "")
            {
                tb_IDVenda.Text = "1";
            }
            else
            {
                ultimavenda = negocio.ID_UltimaVenda();
                Proximavenda = (int.Parse(ultimavenda)) + 1;
                tb_IDVenda.Text = Proximavenda.ToString();
            }
        }
        private void bt_ConsultaPeca_Click(object sender, EventArgs e)
        {
            frmPeca _obj_peca = new frmPeca();
            _obj_peca.ShowDialog();
        }
        private void bt_PesquisarCliente_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
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
            //dtgw_auxiliar.Rows.Clear();
            if (e.KeyChar == 13)
            {                
                DataTable _clienteEncontrado = negocio.pesquisa_ID_Cliente(tb_codCliente.Text);
                dtgw_auxiliarCliente.DataSource = _clienteEncontrado;
                if (dtgw_auxiliarCliente.CurrentRow != null)
                {
                    tb_Cliente.Text = dtgw_auxiliarCliente.CurrentRow.Cells[1].Value.ToString();
                    GravaVendaTemp();
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                }
                else
                    MessageBox.Show("Cliente não localizado");
            }
        }
        private void tb_codPeca_KeyPress(object sender, KeyPressEventArgs e)
        {
            //dtgw_auxiliar.Rows.Clear();
            if (e.KeyChar == 13)
            {
                DataTable _pecaEncontrata = negocio.pesquisa_ID_Peca(tb_codPeca.Text);
                dtgw_auxiliarPecas.DataSource = _pecaEncontrata;
                if (dtgw_auxiliarPecas.CurrentRow != null)
                {
                    tb_descricaoPeca.Text = dtgw_auxiliarPecas.CurrentRow.Cells[1].Value.ToString();
                    tb_quantidadePecaEstoque.Text = dtgw_auxiliarPecas.CurrentRow.Cells[4].Value.ToString();

                    double valor = Convert.ToDouble(dtgw_auxiliarPecas.CurrentRow.Cells[5].Value)/10; //) / 100;
                    tb_PrecoPecaUnita.Text = valor.ToString();
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);

                }
                else
                {
                    MessageBox.Show("Peça não encontrada!");
                }

            }

        }
        private void bt_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                _ItemdeVenda = new ItensVenda();
                _ItemdeVenda.IDVenda = int.Parse(tb_IDVenda.Text);
                _ItemdeVenda.IDPeca = int.Parse(tb_codPeca.Text);
                _ItemdeVenda.PrecoUnitario = double.Parse(tb_PrecoPecaUnita.Text);
                _ItemdeVenda.Quantidade = (int)num_quantidadePecas.Value;
                _ItemdeVenda.Subtotal = ((double)num_quantidadePecas.Value * (double.Parse(tb_PrecoPecaUnita.Text)));
                obj_controle.ControleInserir(_ItemdeVenda);

                Peca obj_peca = new Peca();
                obj_peca.IDPeca = int.Parse(tb_codPeca.Text);
                obj_peca.NomePeca = tb_descricaoPeca.Text;
                obj_peca.IDFornecedor = (int)dtgw_auxiliarPecas.CurrentRow.Cells[2].Value;
                obj_peca.IDVeiculo = (int)dtgw_auxiliarPecas.CurrentRow.Cells[3].Value;
                obj_peca.Quantidade = (int.Parse(tb_quantidadePecaEstoque.Text)) - ((int)num_quantidadePecas.Value);
                obj_peca.PrecoPeca = double.Parse(tb_PrecoPecaUnita.Text);
                obj_peca.IDCategoria = (int)dtgw_auxiliarPecas.CurrentRow.Cells[6].Value;
                obj_controle.ControleAtualizar(obj_peca);
                CarregaTabelaItensdeVenda();                
                
                MessageBox.Show("Test");
                tb_codPeca.Clear();
                tb_descricaoPeca.Clear();
                tb_PrecoPecaUnita.Clear();
                tb_quantidadePecaEstoque.Clear();
                num_quantidadePecas.Value = 1;
            }
            catch (Exception erro)
            {
                
                throw erro;
            }
            

        }

        private void num_quantidadePecas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (num_quantidadePecas.Value > int.Parse(tb_quantidadePecaEstoque.Text))
                {
                    MessageBox.Show("Quantidade superior ao estoque");
                }
                else
                {
                    bt_gravar_Click(sender, e);
                    this.SelectNextControl(this.ActiveControl,false,true,true,true);
                    
                }
            }
        }

        private void CarregaTabelaItensdeVenda()
        {
            try
            {
                dtg_Venda.DataSource = negocio.LerTabelaItensVenda(tb_IDVenda.Text);
            }
            catch (Exception erro)
            {
                
                throw erro;
            }
        }

        

        
    }
}
