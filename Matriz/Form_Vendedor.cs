﻿using System;
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
            
            //ocutando o label e o textbox 
            tb_CodigoVendedor.Visible = false;
            lb_codigovendedor.Visible = false;
            dtg_Vendedor.Visible = true;
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

        private void dtg_Vendedor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lb_codigovendedor.Visible = true;
            tb_CodigoVendedor.Visible = true;            
            
            tb_CodigoVendedor.Text = dtg_Vendedor[0, dtg_Vendedor.CurrentCellAddress.Y].Value.ToString();
            tb_NomeVendedor.Text = dtg_Vendedor[1, dtg_Vendedor.CurrentCellAddress.Y].Value.ToString();
            DateTime data = (DateTime)dtg_Vendedor[2, dtg_Vendedor.CurrentCellAddress.Y].Value;
            dtp_Admissão.Value = data;
            tb_endrua.Text = dtg_Vendedor[3, dtg_Vendedor.CurrentCellAddress.Y].Value.ToString();
            msktb_TelCelular.Text = dtg_Vendedor[5, dtg_Vendedor.CurrentCellAddress.Y].Value.ToString();
            msktb_Telfixo.Text = dtg_Vendedor[4, dtg_Vendedor.CurrentCellAddress.Y].Value.ToString();
            msktb_CPF.Text = dtg_Vendedor[6, dtg_Vendedor.CurrentCellAddress.Y].Value.ToString();
            cmb_estadocivil.SelectedText = dtg_Vendedor[7, dtg_Vendedor.CurrentCellAddress.Y].Value.ToString();

        }

    }
    
} 
