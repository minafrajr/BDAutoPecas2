using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Matriz
{
    public partial class frmLoad : Form
    {
        int valor = 0;
        
        public frmLoad()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            valor += 10;//variavel auxiliar para saida da barra de leitura

            if (progessbar_Inicial.Value != 50 && progessbar_Inicial.Value < 50)
            {
                progessbar_Inicial.PerformStep();
            }//fim do processo de carregamento da barra de leitura

            //condicionais para escrita na label
            if (progessbar_Inicial.Value <= 10)
                lb_prgrssbar.Text = "Iniciando ...";
            else if (progessbar_Inicial.Value <= 20)
                lb_prgrssbar.Text = "Carregando componentes ...";
            else if (progessbar_Inicial.Value <= 30)
                lb_prgrssbar.Text = "Verificando Banco de Dados ...";
            else if (progessbar_Inicial.Value > 40)
                lb_prgrssbar.Text = "Pronto!!!";

            //condicional para descarte do timer e fechamento do form
            if (valor >= 70)
            {
                timer1.Dispose();
                this.Close();
            }
        }
        

    }
}
