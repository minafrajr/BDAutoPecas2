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
    public partial class Form_Fornecedor : Form
    {
        BussinessLayer Negociacao = new BussinessLayer();
        Fornecedor fornecedor;
        public Form_Fornecedor()
        {
            InitializeComponent();
            Tips.Dicas_Botões(bt_gravar, bt_Atualiza, bt_Deleta, Bt_busca1, bt_filtrar, bt_Sair);
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Fornecedor_Load(object sender, EventArgs e)
        {
            verdados();
        }

        private void verdados()
        {
            try
            {
                dtgv_fornecedores.DataSource = Negociacao.LerDados("Fornecedores");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro", "Ocorreu um erro: " + erro.Message);
            }
        }

        private void ckb_Filtrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Filtrar.Checked)
            {
                tb_filtro.Visible = true;
                bt_filtrar.Enabled = true;
            }
            else
            {
                tb_filtro.Visible = false;
                bt_filtrar.Enabled = false;
            }
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                fornecedor = new Fornecedor();
                                
                fornecedor.RazaoSocial = tb_NomeFornecedor.Text;
                fornecedor.CNPJ = msktb_CNPJ.Text;
                fornecedor.CEP = msktb_CEP.Text;
                fornecedor.Endereco = tb_endrua.Text + tb_numendereco.Text + tb_complemento.Text ;
                fornecedor.Bairro = tb_bairro.Text;
                fornecedor.DataContrato = dtp_Fornecedor.Value.ToString(); ;
                fornecedor.Telefone = msk_telfixo.Text;
                fornecedor.TelefoneCelular = mskt_telcel.Text;


                Negociacao.GravarFornecedor(fornecedor);

                limpatb();
                Form_Fornecedor_Load(null, null);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message,"Erro");
            }
        }

        private void bt_Atualiza_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja alterar o cadastro do fornecedor " + tb_NomeFornecedor.Text + " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    fornecedor = new Fornecedor();

                    fornecedor.IDFornecedor = Convert.ToInt32(tb_IDFornecedor.Text);
                    fornecedor.RazaoSocial = tb_NomeFornecedor.Text;
                    fornecedor.CNPJ = msktb_CNPJ.Text;
                    fornecedor.CEP = msktb_CEP.Text;
                    fornecedor.Endereco = tb_endrua.Text;

                    Negociacao.AutalizarFornecedor(fornecedor);

                    limpatb();
                    Form_Fornecedor_Load(null, null);

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro");
            }
        }

        private void bt_Deleta_Click(object sender, EventArgs e)
        {
            try
            {
                fornecedor = new Fornecedor();

                fornecedor.IDFornecedor = Convert.ToInt32(tb_IDFornecedor.Text);

                Negociacao.DeletarFornecedor(fornecedor);

                limpatb();
                Form_Fornecedor_Load(null, null);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void limpatb()
        {
            tb_NomeFornecedor.Clear();
            tb_IDFornecedor.Clear();
            tb_endrua.Clear();
            tb_bairro.Clear();
            tb_complemento.Clear();
            tb_numendereco.Clear();
            msktb_CEP.Clear();
            msktb_CNPJ.Clear();
        }

        private void Bt_busca1_Click(object sender, EventArgs e)
        {
            try
            {
                dtgv_fornecedores.DataSource = Negociacao.PesquisarFornecedor(tb_NomeFornecedor.Text);
                tb_IDFornecedor.Visible = true;
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
                dtgv_fornecedores.DataSource = Negociacao.FiltrarFornecedor(tb_filtro.Text);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Sistema de Controle de AutoPeças");
            }
        }



    }
}
