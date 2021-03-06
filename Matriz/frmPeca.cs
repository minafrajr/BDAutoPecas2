﻿using System;
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
    public partial class frmPeca : Form
    {
     
        
        private Peca peca = new Peca();
        private BussinessLayer Negociacao = new BussinessLayer();
        

        public frmPeca()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
       
        private void Form_Pecas_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'aUTOPECASDataSet11.FORNECEDORES'. Você pode movê-la ou removê-la conforme necessário.
                this.fORNECEDORESTableAdapter.Fill(this.aUTOPECASDataSet11.FORNECEDORES);
                // TODO: esta linha de código carrega dados na tabela 'autopecasDataSet1.Veiculos'. Você pode movê-la ou removê-la conforme necessário.
                this.veiculosTableAdapter.Fill(this.autopecasDataSet1.Veiculos);
                // TODO: esta linha de código carrega dados na tabela 'autopecasDataSet1.Veiculos'. Você pode movê-la ou removê-la conforme necessário.
                this.veiculosTableAdapter.Fill(this.autopecasDataSet1.Veiculos);
                // TODO: esta linha de código carrega dados na tabela 'autopecasDataSet1.Categorias'. Você pode movê-la ou removê-la conforme necessário.
                this.categoriasTableAdapter.Fill(this.autopecasDataSet1.Categorias);

                dtg_Produtos.DataSource = Negociacao.LerDados("Pecas");
                //cmb_fornecedor_peças.DataSource = função que repassa um datatable com as chaves dos fornecedores;
                Dicas_Botões();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
            
        }

        private void bt_Atualiza_Click(object sender, EventArgs e)
        {
            try
            {
                peca.IDPeca = Convert.ToInt32(tb_IDpeca.Text);
                peca.NomePeca = tb_nomepeca.Text;

                Negociacao.Atualizar(peca);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                limpatb();
                Form_Pecas_Load(null, null);
            }
        }

        private void Bt_busca1_Click(object sender, EventArgs e)
        {
            tb_IDpeca.Visible = true;
            dtg_Produtos.DataSource = Negociacao.Procurar(tb_nomepeca.Text);

            tb_nomepeca.Text = peca.NomePeca;
            tb_IDpeca.Text = peca.IDPeca.ToString();
        }

        private void bt_Deleta_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Deseja deletar a peça de código " + tb_IDpeca.Text + "?", "Confirmação", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                {
                    peca.IDPeca = Convert.ToInt32(tb_IDpeca.Text);
                    Negociacao.DeletarPeca(peca);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            limpatb();

            Form_Pecas_Load(null, null);
        }

        private void bt_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_Produtos.DataSource = Negociacao.FiltrarPeca(tb_IDpeca.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                limpatb();
            }
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                Peca pecas = new Peca();

                peca.NomePeca = tb_nomepeca.Text;
                peca.IDVeiculo = Convert.ToInt32(cmb_IDVeiculo.SelectedValue);
                peca.IDFornecedor = Convert.ToInt32(cmb_codigofornecedor_peças.SelectedValue);
                peca.IDCategoria = Convert.ToInt32(cmb_idCategoria.SelectedValue);
                peca.Quantidade = Convert.ToInt32( mskt_quantidade.Text);
                peca.PrecoPeca = Convert.ToDouble(mskt_preco.Text);

                
                Negociacao.GravarPeca(peca);
                
                limpatb();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            Form_Pecas_Load(null, null);
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckb_Filtrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Filtrar.Checked)
            {   
                bt_filtrar.Enabled = true;
            }
            else
            {   
                bt_filtrar.Enabled = false;
            }
        }

        private void Dicas_Botões()
        {
            ToolTip Tip_btn = new ToolTip();

            Tip_btn.UseFading = true;
            Tip_btn.IsBalloon = true;

            Tip_btn.BackColor = Color.Yellow;
            Tip_btn.ForeColor = Color.Red;

            Tip_btn.AutoPopDelay = 5000;
            Tip_btn.InitialDelay = 500;
            Tip_btn.ReshowDelay = 500;

            Tip_btn.SetToolTip(bt_Atualiza, "Atualizar uma nova peça");
            Tip_btn.SetToolTip(Bt_busca1, "Procurar uma peça");
            Tip_btn.SetToolTip(bt_Deleta, "Excluir uma peça");
            Tip_btn.SetToolTip(bt_filtrar, "Filtrar uma peça");
            Tip_btn.SetToolTip(bt_gravar, "Adicionar uma nova peça");
            Tip_btn.SetToolTip(bt_Sair, "Sair");
        }

        private void limpatb()
        {
            cmb_IDVeiculo.ResetText();
            tb_IDpeca.Clear();
            tb_nomepeca.Clear();
        }

        private void dtg_Produtos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_IDpeca.Visible = true;
            label5.Visible = true;

            tb_IDpeca.Text = dtg_Produtos[0,dtg_Produtos.CurrentCellAddress.Y].Value.ToString();
            tb_nomepeca.Text = dtg_Produtos[1, dtg_Produtos.CurrentCellAddress.Y].Value.ToString();
            cmb_codigofornecedor_peças.SelectedText = dtg_Produtos[2, dtg_Produtos.CurrentCellAddress.Y].Value.ToString();
            cmb_IDVeiculo.SelectedText = dtg_Produtos[3, dtg_Produtos.CurrentCellAddress.Y].Value.ToString();            
            mskt_quantidade.Text = dtg_Produtos[4, dtg_Produtos.CurrentCellAddress.Y].Value.ToString();
            mskt_preco.Text = dtg_Produtos[5, dtg_Produtos.CurrentCellAddress.Y].Value.ToString();
            cmb_idCategoria.SelectedText = dtg_Produtos[6, dtg_Produtos.CurrentCellAddress.Y].Value.ToString();
        }

        
        
    }
}