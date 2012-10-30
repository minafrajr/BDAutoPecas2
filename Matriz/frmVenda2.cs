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
    public partial class frmVenda2 : Form
    {
        Camadas.BussinessLayer negocio;

        public frmVenda2()
        {
            InitializeComponent();
        }

        private void CarregaCmbVendedor()
        {
            negocio = new Camadas.BussinessLayer();
            cmbVendedor.DataSource = negocio.getVendedores();
        }

        private void frmVenda2_Load(object sender, EventArgs e)
        {
            CarregaCmbVendedor();
        }
    }
}
