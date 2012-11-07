﻿using System;
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
        bool statusCelulaClicada = false;

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
            Tips.Dicas_Botões(bt_gravar, bt_Atualiza, bt_Deleta, bt_Sair);
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
                num_quantidadePecas.ReadOnly = false;
                num_quantidadePecas.Enabled = true;
                DataTable _pecaEncontrata = negocio.pesquisa_ID_Peca(tb_codPeca.Text);
                dtgw_auxiliarPecas.DataSource = _pecaEncontrata;
                if (dtgw_auxiliarPecas.CurrentRow != null)
                {
                    tb_descricaoPeca.Text = dtgw_auxiliarPecas.CurrentRow.Cells[1].Value.ToString();
                    tb_quantidadePecaEstoque.Text = dtgw_auxiliarPecas.CurrentRow.Cells[4].Value.ToString();

                    double valor = Convert.ToDouble(dtgw_auxiliarPecas.CurrentRow.Cells[5].Value); //) / 100;
                    tb_preco.Text = valor.ToString();
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
                _ItemdeVenda.PrecoUnitario = double.Parse(tb_preco.Text);
                _ItemdeVenda.Quantidade = (int)num_quantidadePecas.Value;
                _ItemdeVenda.Subtotal = ((double)num_quantidadePecas.Value * (double.Parse(tb_preco.Text)));
                obj_controle.ControleInserir(_ItemdeVenda);

                Peca obj_peca = new Peca();
                obj_peca.IDPeca = int.Parse(tb_codPeca.Text);
                obj_peca.NomePeca = tb_descricaoPeca.Text;
                obj_peca.IDFornecedor = (int)dtgw_auxiliarPecas.CurrentRow.Cells[2].Value;
                obj_peca.IDVeiculo = (int)dtgw_auxiliarPecas.CurrentRow.Cells[3].Value;
                obj_peca.Quantidade = (int.Parse(tb_quantidadePecaEstoque.Text)) - ((int)num_quantidadePecas.Value);
                obj_peca.PrecoPeca = double.Parse(tb_preco.Text);
                obj_peca.IDCategoria = (int)dtgw_auxiliarPecas.CurrentRow.Cells[6].Value;
                obj_controle.ControleAtualizar(obj_peca);
                CarregaTabelaItensdeVenda();
                tb_codPeca.Clear();
                tb_descricaoPeca.Clear();
                tb_preco.Clear();
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
                double total = 0;
                for (int i = 0; i < dtg_Venda.RowCount; i++)
                {
                    string d = dtg_Venda[4, i].Value.ToString();
                    total += double.Parse(d);
                    //total = total + (double)dtg_Venda[4, i].Value;
                }
                tb_total.Text = total.ToString();
            }
            catch (Exception erro)
            {
                
                throw erro;
            }
        }
        private void num_desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    decimal total = decimal.Parse(tb_total.Text);
                    decimal desc = total * (num_desconto.Value/100);
                    total -= desc;
                    tb_total.Text = total.ToString();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.ToString()); ;
                }

            }
        }

        private void bt_Atualiza_Click(object sender, EventArgs e)
        {
            CarregaTabelaItensdeVenda();

        }

        private void dtg_Venda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            statusCelulaClicada = true;
            tb_codPeca.Text = dtg_Venda[0,dtg_Venda.CurrentCellAddress.Y].Value.ToString();
            tb_descricaoPeca.Text = dtg_Venda[1, dtg_Venda.CurrentCellAddress.Y].Value.ToString();
            tb_preco.Text = dtg_Venda[2, dtg_Venda.CurrentCellAddress.Y].Value.ToString();
            num_quantidadePecas.Value = Convert.ToDecimal(dtg_Venda[3, dtg_Venda.CurrentCellAddress.Y].Value);
            tb_IDItensVenda.Text = dtg_Venda[5, dtg_Venda.CurrentCellAddress.Y].Value.ToString();

            num_quantidadePecas.ReadOnly = true;
            num_quantidadePecas.Enabled = false;
        }

        private void bt_Deleta_Click(object sender, EventArgs e)
        {
            if (statusCelulaClicada)
            {
                try
                {
                    ItensVenda obj_Itemvenda = new ItensVenda();
                    obj_Itemvenda.IDItensVenda = int.Parse(tb_IDItensVenda.Text);
                    obj_controle.ControleDeletar(obj_Itemvenda);

                    DataTable _pecaEncontrata = negocio.pesquisa_ID_Peca(tb_codPeca.Text);

                    dtgw_auxiliarPecas.DataSource = _pecaEncontrata;

                    if (dtgw_auxiliarPecas.CurrentRow != null)
                    {
                        Peca obj_peca = new Peca();
                        obj_peca.IDPeca = int.Parse(tb_codPeca.Text);
                        obj_peca.NomePeca = tb_descricaoPeca.Text;
                        obj_peca.IDFornecedor = (int)dtgw_auxiliarPecas.CurrentRow.Cells[2].Value;
                        obj_peca.IDVeiculo = (int)dtgw_auxiliarPecas.CurrentRow.Cells[3].Value;
                        obj_peca.Quantidade = (int.Parse(tb_quantidadePecaEstoque.Text)) + ((int)num_quantidadePecas.Value);
                        obj_peca.PrecoPeca = double.Parse(tb_preco.Text);
                        obj_peca.IDCategoria = (int)dtgw_auxiliarPecas.CurrentRow.Cells[6].Value;
                        obj_controle.ControleAtualizar(obj_peca);
                    }
                    bt_Atualiza_Click(sender, e);
                    statusCelulaClicada = false;
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.ToString());
                }
            }
            else
                MessageBox.Show("Selecione uma linha na tabela");
        }

        private void bt_Concluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar a compra?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Information).Equals(DialogResult.Yes))
            {
                obj_venda.IDVenda = int.Parse(tb_IDVenda.Text);
                obj_venda.IDVendedor = int.Parse(tb_CondVendedor.Text);
                obj_venda.DataVenda = DateTime.Now;
                obj_venda.IDCliente = int.Parse(tb_codCliente.Text);
                obj_venda.PrecoTotal = float.Parse(tb_total.Text);
                float total = 0;
                for (int i = 0; i < dtg_Venda.RowCount; i++)
                {
                    string d = dtg_Venda[4, i].Value.ToString();
                    total += float.Parse(d);
                    //total = total + (double)dtg_Venda[4, i].Value;
                }

                obj_venda.Desconto = total - obj_venda.PrecoTotal;
                obj_controle.ControleAtualizar(obj_venda);
                this.Close();
 
            }
        }     
    }
}
