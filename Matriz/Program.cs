﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Matriz
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmVenda());
            //Application.Run(new frmVendedor());
            //Application.Run(new frmVenda2());
            //Application.Run(new frmLogonVendedores());
        }
    }
}
