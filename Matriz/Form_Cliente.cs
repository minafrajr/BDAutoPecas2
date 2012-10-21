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
                cliente = new Cliente();

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
                cliente.Logradouro = tb_Logradouro.Text;
                cliente.N_Residencia = tb_NumeroComplemento.Text;
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
        /// Resgata informações do cliente a partir do datagridview e o transfere para os textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtg_Cliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lb_Cod.Visible = true;
            tb_CodigoCliente.Visible = true;
            cmb_estado.ResetText();

            tb_Bairro.Text = dtg_Cliente[5, dtg_Cliente.CurrentCellAddress.Y].Value.ToString();
            tb_Cidade.Text = dtg_Cliente[9, dtg_Cliente.CurrentCellAddress.Y].Value.ToString();
            tb_Logradouro.Text = dtg_Cliente[4, dtg_Cliente.CurrentCellAddress.Y].Value.ToString();
            tb_NomeCliente.Text = dtg_Cliente[1, dtg_Cliente.CurrentCellAddress.Y].Value.ToString();
            tb_NumeroComplemento.Text = dtg_Cliente[0, dtg_Cliente.CurrentCellAddress.Y].Value.ToString();
            mask_TelefoneCelular.Text = dtg_Cliente[8, dtg_Cliente.CurrentCellAddress.Y].Value.ToString();
            mask_TelefoneFixo.Text = dtg_Cliente[7, dtg_Cliente.CurrentCellAddress.Y].Value.ToString();
            mask_CEP.Text = dtg_Cliente[6, dtg_Cliente.CurrentCellAddress.Y].Value.ToString();
            cmb_estado.SelectedText = dtg_Cliente[10, dtg_Cliente.CurrentCellAddress.Y].Value.ToString();
            tb_CodigoCliente.Text = dtg_Cliente[0, dtg_Cliente.CurrentCellAddress.Y].Value.ToString();
            tb_NumeroComplemento.Text = dtg_Cliente[11, dtg_Cliente.CurrentCellAddress.Y].Value.ToString();

            if (dtg_Cliente[2, dtg_Cliente.CurrentCellAddress.Y].Value.ToString() == "-")
                mask_CPFCNPJ.Text = dtg_Cliente[3, dtg_Cliente.CurrentCellAddress.Y].Value.ToString();
            else
                mask_CPFCNPJ.Text = dtg_Cliente[2, dtg_Cliente.CurrentCellAddress.Y].Value.ToString();
        }

        private void bt_Deleta_Click(object sender, EventArgs e)
        {
            try
            {
                cliente = new Cliente();

                if (MessageBox.Show("Deseja deletar o cliente" + tb_NomeCliente.Text + " ?", "Confirmação", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                {
                    cliente.ID_Cliente = Convert.ToInt16(tb_CodigoCliente.Text);


                    Negociacao.DeletarCliente(cliente);
                }

                Form_Cliente_Load(null, null);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bt_Atualiza_Click(object sender, EventArgs e)
        {
            try
            {
                cliente = new Cliente();

                cliente.ID_Cliente = Convert.ToInt16( dtg_Cliente[0, dtg_Cliente.CurrentCellAddress.Y].Value.ToString());
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
                cliente.UF = cmb_estado.Text;
                cliente.Logradouro = tb_Logradouro.Text;
                cliente.N_Residencia = tb_NumeroComplemento.Text;
                cliente.Bairro = tb_Bairro.Text;
                cliente.Cidade = tb_Cidade.Text;
                cliente.CEP = mask_CEP.Text;

                Negociacao.AtualizarCliente(cliente);
                Form_Cliente_Load(null, null);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Sistema de controle de AutoPeças");
            }
        }

        private void Bt_busca1_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_Cliente.DataSource = Negociacao.PocurarCliente(tb_NomeCliente.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Sistema de controle de AutoPeças");
            }
        }

        private void bt_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_Cliente.DataSource = Negociacao.FiltrarCliente(tb_NomeCliente.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Sistema de controle de AutoPeças");

            }
        }


    }
}
