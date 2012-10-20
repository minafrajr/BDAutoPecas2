using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoPeçasUI;

namespace Matriz
{
    public partial class Form_Venda : Form
    {
        //philipe
        public static List<Camadas.Peca> listaPecasSelecionadas;
        //Camadas.Peca pecaSelecionada;
        //

        public Form_Venda()
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
            Tips.Dicas_Botões(bt_gravar, bt_Atualiza, bt_Deleta, Bt_busca1, bt_filtrar, bt_Sair);
        }

        private void bt_ConsultaPeca_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_PesquisarCliente_Click(object sender, EventArgs e)
        {

        }       

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            //dtg_Venda.Rows.Add("1","virabrequim","30","2,60","78,00" );

        }

       

        

        
    }
}
