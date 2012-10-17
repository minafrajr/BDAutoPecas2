using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Web;



namespace AutoPeçasUI
{
    
    
    /// <summary>
    /// Inicializa as dicas dos botões
    /// </summary>
    public static class Tips 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="adicionar">Atualizar</param>
        /// <param name="Atualizar"></param>
        /// <param name="Excluir"></param>
        /// <param name="Localizar"></param>
        /// <param name="FiltrarPeca"></param>
        /// <param name="Sair"></param>
        public static void Dicas_Botões(Control adicionar,Control Atualizar,Control Excluir,Control Localizar,Control Filtrar,Control Sair)
        {
            ToolTip Tip_btn = new ToolTip();

            Tip_btn.UseFading = true;
            Tip_btn.IsBalloon = true;

            Tip_btn.BackColor = Color.Yellow;
            Tip_btn.ForeColor = Color.Red;

            Tip_btn.AutoPopDelay = 5000;
            Tip_btn.InitialDelay = 500;
            Tip_btn.ReshowDelay = 500;

            Tip_btn.SetToolTip(adicionar, "Adcionar");
            Tip_btn.SetToolTip(Atualizar, "Atualizar");
            Tip_btn.SetToolTip(Excluir, "Excluir");
            Tip_btn.SetToolTip(Localizar, "Localizar");
            Tip_btn.SetToolTip(Filtrar, "Filtrar");
            Tip_btn.SetToolTip(Sair, "Sair");
        }

        public static void Dicas_Botões(Control Adicionar, Control Atualizar, Control Excluir, Control Sair)
        {
            ToolTip Tip_btn = new ToolTip();

            Tip_btn.UseFading = true;
            Tip_btn.IsBalloon = true;

            Tip_btn.BackColor = Color.Yellow;
            Tip_btn.ForeColor = Color.Red;

            Tip_btn.AutoPopDelay = 5000;
            Tip_btn.InitialDelay = 500;
            Tip_btn.ReshowDelay = 500;

            Tip_btn.SetToolTip(Adicionar, "Adcionar");
            Tip_btn.SetToolTip(Atualizar, "Atualizar");
            Tip_btn.SetToolTip(Excluir, "Excluir");
            Tip_btn.SetToolTip(Sair, "Sair");
        }
    }
}
