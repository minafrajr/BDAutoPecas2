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
    public partial class frmFornecedor : Form
    {
        BussinessLayer Negociacao = new BussinessLayer();
        Fornecedor fornecedor;
        public frmFornecedor()
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
                                
                fornecedor.NomeFornecedor = tb_NomeFornecedor.Text;
                fornecedor.CNPJFornecedor = msktb_CNPJ.Text;
                fornecedor.CEPFornecedor = msktb_CEP.Text;
                fornecedor.EnderecoFornecedor = tb_endrua.Text + tb_numendereco.Text + tb_complemento.Text ;
                fornecedor.BairroFornecedor = tb_bairro.Text;
                fornecedor.DataContrato = dtp_Fornecedor.Value.Date;
                fornecedor.TelefoneFixo = msk_telfixo.Text;
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
                    fornecedor.NomeFornecedor = tb_NomeFornecedor.Text;
                    fornecedor.CNPJFornecedor = msktb_CNPJ.Text;
                    fornecedor.CEPFornecedor = msktb_CEP.Text;
                    fornecedor.EnderecoFornecedor = tb_endrua.Text;

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
                lb_codigofornecedor.Visible = true;
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

        private void dtgv_fornecedores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_IDFornecedor.Visible = true;
            lb_codigofornecedor.Visible = true;

            tb_IDFornecedor.Text = dtgv_fornecedores[0, dtgv_fornecedores.CurrentCellAddress.Y].Value.ToString();
            tb_NomeFornecedor.Text = dtgv_fornecedores[1, dtgv_fornecedores.CurrentCellAddress.Y].Value.ToString();
            //msktb_CNPJ.Mask = "00,000,000/0000-00";
            msktb_CNPJ.Text = dtgv_fornecedores[2, dtgv_fornecedores.CurrentCellAddress.Y].Value.ToString();
            tb_endrua.Text = dtgv_fornecedores[3, dtgv_fornecedores.CurrentCellAddress.Y].Value.ToString();
            tb_bairro.Text = dtgv_fornecedores[4, dtgv_fornecedores.CurrentCellAddress.Y].Value.ToString();
            msktb_CEP.Mask = "00000-000";
            msktb_CEP.Text = dtgv_fornecedores[5, dtgv_fornecedores.CurrentCellAddress.Y].Value.ToString();
            msk_telfixo.Text = dtgv_fornecedores[6, dtgv_fornecedores.CurrentCellAddress.Y].Value.ToString();
            mskt_telcel.Text = dtgv_fornecedores[7, dtgv_fornecedores.CurrentCellAddress.Y].Value.ToString();            
            
            ///ainda nao há coluna na tabela
            //tb_numendereco.Text = dtgv_fornecedores[x, dtgv_fornecedores.CurrentCellAddress.Y].Value.ToString();
            //tb_complemento.Text = dtgv_fornecedores[x, dtgv_fornecedores.CurrentCellAddress.Y].Value.ToString();
            
            
            
    


        }



    }
}
