using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoPeçasUI;
using System.Data.SqlClient;
using System.Data.Sql;

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
            //consultaTabelaCliente();


        }

        private void bt_ConsultaPeca_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_PesquisarCliente_Click(object sender, EventArgs e)
        {
            Form_Cliente cliente = new Form_Cliente();
            cliente.ShowDialog();


        }       

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            //dtg_Venda.Rows.Add("1","virabrequim","30","2,60","78,00" );

        }

        /// <summary>
        /// Consulta na tabela cliente para autocompletesource ????????????
        /// </summary>
        private void consultaTabelaCliente()
        {
            string conexao = "Data Source = CASA; Initial Catalog = AUTOPECAS; Integrated Security = True;";
            tb_Cliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_Cliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb_Cliente.AutoCompleteCustomSource = ColecaodeNomes;
            SqlDataReader Leitor_dados;
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand comando = new SqlCommand();
            comando.Connection = con;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select DISTINCT (NOMECLIENTE) as NOMECLIENTE from CLIENTES";
            con.Open();
            Leitor_dados = comando.ExecuteReader();
            if (Leitor_dados.HasRows == true)
            {
                while (Leitor_dados.Read())
                {
                    ColecaodeNomes.Add(Leitor_dados["NOMECLIENTE"].ToString());
                }
            }
 
        }
        private AutoCompleteStringCollection ColecaodeNomes { get; set; }

        private void tb_Cliente_TextChanged(object sender, EventArgs e)
        {
            //patiente
        }
        

       

        

        
    }
}
