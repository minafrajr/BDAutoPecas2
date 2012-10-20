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
    public partial class Form_Cliente : Form
    {
        BussinessLayer Negociacao = new BussinessLayer();
        Cliente cliente;
        public Form_Cliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// habilita a função da maskedtextbox de gerar máscara para CPF ou CNPJ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radio_PF_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_PF.Checked == false)
            {
                mask_CPFCNPJ.Text = "";
                mask_CPFCNPJ.Mask = "00,000,000/0000-00";
            }
            else
            {
                mask_CPFCNPJ.Text = "";
                mask_CPFCNPJ.Mask = "000,000,000-00";
            }
        }

        /// <summary>
        /// fecha o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Grava o objeto cliente no bando de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente = new Cliente ();

                cliente.NomeCliente = tb_NomeCliente.Text;
                
                if (radio_PF.Checked)
                {
                    cliente.CNPJ = null;
                    cliente.CPF = mask_CPFCNPJ.Text;
                }
                else
                {
                    cliente.CNPJ = mask_CPFCNPJ.Text;
                    cliente.CPF = null;
                }

                cliente.Telefone_Celular = mask_TelefoneCelular.Text;
                cliente.Telefone_Fixo = mask_TelefoneFixo.Text;
                cliente.UF = cmb_estado.SelectedItem.ToString();
                cliente.Logradouro = tb_Logradouro.Text+" nº "+tb_NumeroComplemento.Text;
                cliente.Bairro = tb_Bairro.Text;
                cliente.Cidade = tb_Cidade.Text;
                cliente.CEP = mask_CEP.Text;

                Negociacao.GravarCliente(cliente);
                Form_Cliente_Load(null, null); //força a releitura do datagridview.
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Sistema de controle de AutoPeças");
            }
        }

        private void Form_Cliente_Load(object sender, EventArgs e)
        {
            try
            {
                dtg_Cliente.DataSource = Negociacao.LerDados("Clientes");
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Resgata o id do cliente a partir do datagridview e o transfere para o textbox de código de cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtg_Cliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lb_Cod.Visible = true;
            tb_CodigoCliente.Visible = true;

            tb_CodigoCliente.Text = dtg_Cliente[0, dtg_Cliente.CurrentCellAddress.Y].Value.ToString();

        }

        private void bt_Deleta_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
