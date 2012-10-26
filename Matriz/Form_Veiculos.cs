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
    public partial class Form_Veiculos : Form
    {
        private Veiculo veiculo;
        private BussinessLayer Negociacao = new BussinessLayer();

        public Form_Veiculos()
        {
            InitializeComponent();
        }

        private void bt_Atualiza_Click(object sender, EventArgs e)
        {
            veiculo = new Veiculo();

            try
            {
                veiculo.NomeVeiculo = tb_NomeVeiculo.Text;
                veiculo.Fabricante = cb_fabricante.SelectedItem.ToString();
                veiculo.AnoInicial = dtp_Inicial.Value;
                veiculo.AnoFinal = dtp_Final.Value;

                Negociacao.AtualizarVeiculo(veiculo);
            }
            catch (Exception erro)
            {
                MessageBox.Show(string.Format("Erro ao salvar novo veiculo. Erro: {0}", erro), "Sistema de Controle de AutoPecas");
            }
        }

        private void Bt_busca1_Click(object sender, EventArgs e)
        {
            tb_IDVeiculo.Visible = true;
        }

        private void bt_Deleta_Click(object sender, EventArgs e)
        {

            try
            {
                veiculo = new Veiculo();

                veiculo.IDVeiculo = Convert.ToInt16(tb_IDVeiculo.Text);

                if (MessageBox.Show("Deseja excluir o veículo " + dtg_Veiculos[1,dtg_Veiculos.CurrentCellAddress.Y].Value.ToString() + "?", "Sistema de Controle de AutoPecas", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    Negociacao.DeletarVeiculo(veiculo);

                    Form_Veiculos_Load(null, null);
                    Limpatextbox();
                }

                veiculo = null;
            }
            catch (Exception erro)
            {
                MessageBox.Show(string.Format("Erro ao salvar novo veiculo. Erro: {0}", erro), "Sistema de Controle de AutoPecas");
            }
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                veiculo = new Veiculo();

                veiculo.AnoInicial = dtp_Inicial.Value.Date;
                veiculo.AnoFinal= dtp_Final.Value.Date;
                veiculo.NomeVeiculo = tb_NomeVeiculo.Text;
                veiculo.Fabricante = cb_fabricante.SelectedItem.ToString();

                Negociacao.GravarVeiculos(veiculo);
            }
            catch (Exception erro)
            {
                MessageBox.Show(string.Format("Erro ao salvar novo veiculo. Erro: {0}", erro), "Sistema de Controle de AutoPecas");
            }
            finally
            {
                Form_Veiculos_Load(null, null);
                Limpatextbox();
            }
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckb_FiltrarVeiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_FiltrarVeiculo.Checked)
            {
                tb_filtrarveiculo.Visible = true;
                bt_filtrar.Enabled = true;
            }
            else
            {
                this.bt_filtrar.Enabled = false;
                this.tb_filtrarveiculo.Visible = false;
            }
        }

        private void Form_Veiculos_Load(object sender, EventArgs e)
        {
            Tips.Dicas_Botões(bt_gravar, bt_Atualiza, bt_Deleta, Bt_busca1, bt_filtrar, bt_Sair);
            dtg_Veiculos.DataSource = Negociacao.LerDados("Veiculos");
        }

        private void Limpatextbox()
        {
            tb_filtrarveiculo.Clear();
            tb_IDVeiculo.Clear();
            tb_NomeVeiculo.Clear();
        }

        private void dtg_Veiculos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lb_codigoveiculo.Visible = true;
            tb_IDVeiculo.Visible = true;
            cb_fabricante.ResetText();


            tb_IDVeiculo.Text = dtg_Veiculos[0, dtg_Veiculos.CurrentCellAddress.Y].Value.ToString();
            tb_NomeVeiculo.Text = dtg_Veiculos[1, dtg_Veiculos.CurrentCellAddress.Y].Value.ToString();            
            cb_fabricante.SelectedText = dtg_Veiculos[2, dtg_Veiculos.CurrentCellAddress.Y].Value.ToString();
        }
    }
}