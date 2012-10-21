using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoPeçasUI;
using Camadas;

namespace Matriz
{
    public partial class Form_Vendedor : Form
    {
        Vendedor vendedor = new Vendedor();
        BussinessLayer Negociacao = new BussinessLayer();

        public Form_Vendedor()
        {
            InitializeComponent();
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                bt_filtrar.Enabled = true;
            }
            else
            {
                bt_filtrar.Enabled = false;
            }
        }

        private void Form_Vendedor_Load(object sender, EventArgs e)
        {
            Tips.Dicas_Botões(bt_gravar, bt_Atualiza, bt_Deleta, Bt_busca1, bt_filtrar, bt_Sair);
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                vendedor.NomeVendedor = tb_NomeVendedor.Text;
                vendedor.Endereco = tb_endrua.Text + " nº " + tb_numerocasa.Text + " compl. " + tb_complemento.Text+" bairro"+tb_bairrro.Text;
                vendedor.CPF = msktb_CPF.Text;
                vendedor.DataAdmissao = dtp_Admissão.Value.Date;
                vendedor.EstadoCivil = cmb_estadocivil.SelectedItem.ToString();
                vendedor.TelefoneCelular = msktb_TelCelular.Text;
                vendedor.TelefoneFixo = msktb_Telfixo.Text;

                Negociacao.GravarVendedor(vendedor);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message,"Sistema de Controle de AutoPeças"); 
            }
        }

        private void bt_Atualiza_Click(object sender, EventArgs e)
        {
            try
            {
                Negociacao.AtualizarVendedor(vendedor);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message,"Sistema de Controle de AutoPeças"); 
            }
        }

        private void bt_Deleta_Click(object sender, EventArgs e)
        {
            try
            {
                Negociacao.DeletarVendedor(vendedor);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message,"Sistema de Controle de AutoPeças"); 
            }
        }

        private void Bt_busca1_Click(object sender, EventArgs e)
        {
            try
            {
                Negociacao.PesquisarVendedor(tb_NomeVendedor.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Sistema de Controle de AutoPeças");
            }
        }

        private void bt_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_Vendedor.DataSource = Negociacao.FiltrarVendedor(tb_NomeVendedor.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Sistema de Controle de AutoPeças");
            }
        }

    }
    
} 
