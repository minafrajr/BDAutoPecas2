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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'AUTOPECASDataSet.Pecas'. Você pode movê-la ou removê-la conforme necessário.
            this.PecasTableAdapter.Fill(this.AUTOPECASDataSet.Pecas);

            this.reportViewer1.RefreshReport();
        }
    }
}
