using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Camadas;
using AutoPeçasUI;

namespace Matriz
{
    public partial class Form_Categorias : Form
    {
        BussinessLayer Negociacao = new BussinessLayer();
        Categoria categoria = new Categoria();

        public Form_Categorias()
        {
            InitializeComponent();
        }

        /// <summary>
        /// inicializa o formulario de categorias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Categorias_Load(object sender, EventArgs e)
        {
            try
            {
                Tips.Dicas_Botões(bt_gravar,bt_Atualiza, bt_Deleta,bt_Sair); //repassa as dicas para os botões
                CarregaTabela();                                             //faz a leitura dos dados da tabela categorias do banco de dados
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message,"Erro"); ;
            }
        }

        /// <summary>
        /// faz a leitura dos dados da tabela categorias do banco de dados
        /// </summary>
        private void CarregaTabela()
        {
            dtg_Categorias.DataSource = Negociacao.LerDados("Categorias");
        }

        /// <summary>
        /// Grava um novo objeto categoria no bando de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                categoria.NomeCategoria = tb_NomeCategoria.Text;
                categoria.Descricao = tb_DescriCatg.Text;

                Negociacao.GravarCategorias(categoria);
                
                CarregaTabela();
                limpatb();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message,"Sistema de Controle de AutoPeças");
            }
        }

        /// <summary>
        /// Atualiza uma categoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Atualiza_Click(object sender, EventArgs e)
        {
            try
            {
                categoria.NomeCategoria = tb_NomeCategoria.Text;
                categoria.Descricao = tb_DescriCatg.Text;

                Negociacao.AtualizarCategoria(categoria);
                CarregaTabela();
                limpatb();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Sistema de Controle de AutoPeças");
            }
        }

        /// <summary>
        /// Deleta uma categoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Deleta_Click(object sender, EventArgs e)
        {
            try
            {
                categoria.NomeCategoria = tb_NomeCategoria.Text;
                if (MessageBox.Show("Deseja excluir a categoria" + tb_NomeCategoria.Text + " de código ???", "Test", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                {
                    Negociacao.DeletarCategoria(categoria);

                    CarregaTabela();
                    limpatb();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Sistema de Controle de AutoPeças"); 
            }
        }

        /// <summary>
        /// Fecha o formulario de categoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        /// <summary>
        /// faz a limpeza dos textbox do formulário
        /// </summary>
        private void limpatb()
        {
            tb_DescriCatg.Clear();
            tb_NomeCategoria.Clear();
        }

        /// <summary>
        /// Habilita o textbox e o botão  de filtrar uma categoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckb_filtrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_filtrar.Checked)
            {
                tb_filtrar.Visible = true;
                bt_filtrar.Enabled = true;
            }
            else 
            {
                tb_filtrar.Visible = false;
                bt_filtrar.Enabled = false;
            }
        }

        
        /// <summary>
        /// Faz a busca de categorias entre os dados da tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bt_busca1_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_Categorias.DataSource = Negociacao.PesquisarCategoria(tb_NomeCategoria.Text);
                limpatb();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Sistema de Controle de AutoPeças"); 
            }
        }

        /// <summary>
        /// Filtra uma categoria específica entre os dados da tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_Categorias.DataSource = Negociacao.FiltrarCategoria(tb_filtrar.Text);
                limpatb();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Sistema de Controle de AutoPeças"); 
            }
        }

    
    }
}
