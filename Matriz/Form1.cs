using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Matriz
{


    public partial class Form1 : Form
    {
        Operacoes O = new Operacoes();

        private string File = "estoque.xml";
        DateTime Tempo_Atual;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void padrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void códigoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeXML L = new LeXML(File);
            label1.Text = O.Retorna_Pos_Ult_Prodt().ToString();
            Tempo_Atual = DateTime.Now;
            DataHora.Text = Tempo_Atual.ToLongDateString()+"  -  " + Tempo_Atual.ToLongTimeString();

        }


    }

}