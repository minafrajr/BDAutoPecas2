namespace Matriz
{
    partial class Form_Vendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Vendedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_filtrar = new System.Windows.Forms.Button();
            this.Bt_busca1 = new System.Windows.Forms.Button();
            this.bt_Atualiza = new System.Windows.Forms.Button();
            this.bt_Deleta = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.Titulo_Form_pecas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Admissão = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msktb_CEP = new Matriz.Msktextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_bairrro = new AutoPeçasUI.MyTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_complemento = new AutoPeçasUI.MyTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_numerocasa = new AutoPeçasUI.MyTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_endrua = new AutoPeçasUI.MyTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_estadocivil = new Matriz.MyComboBox();
            this.msktb_TelCelular = new Matriz.Msktextbox();
            this.msktb_Telfixo = new Matriz.Msktextbox();
            this.msktb_CPF = new Matriz.Msktextbox();
            this.tb_CodigoVendedor = new AutoPeçasUI.MyTextBox();
            this.tb_NomeVendedor = new AutoPeçasUI.MyTextBox();
            this.dtg_Vendedor = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Vendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Sair);
            this.panel1.Controls.Add(this.bt_filtrar);
            this.panel1.Controls.Add(this.Bt_busca1);
            this.panel1.Controls.Add(this.bt_Atualiza);
            this.panel1.Controls.Add(this.bt_Deleta);
            this.panel1.Controls.Add(this.bt_gravar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.bt_Sair, "bt_Sair");
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_filtrar
            // 
            this.bt_filtrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.bt_filtrar, "bt_filtrar");
            this.bt_filtrar.Name = "bt_filtrar";
            this.bt_filtrar.UseVisualStyleBackColor = false;
            this.bt_filtrar.Click += new System.EventHandler(this.bt_filtrar_Click);
            // 
            // Bt_busca1
            // 
            this.Bt_busca1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.Bt_busca1, "Bt_busca1");
            this.Bt_busca1.Name = "Bt_busca1";
            this.Bt_busca1.UseVisualStyleBackColor = false;
            this.Bt_busca1.Click += new System.EventHandler(this.Bt_busca1_Click);
            // 
            // bt_Atualiza
            // 
            this.bt_Atualiza.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.bt_Atualiza, "bt_Atualiza");
            this.bt_Atualiza.Name = "bt_Atualiza";
            this.bt_Atualiza.UseVisualStyleBackColor = false;
            this.bt_Atualiza.Click += new System.EventHandler(this.bt_Atualiza_Click);
            // 
            // bt_Deleta
            // 
            this.bt_Deleta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.bt_Deleta, "bt_Deleta");
            this.bt_Deleta.Name = "bt_Deleta";
            this.bt_Deleta.UseVisualStyleBackColor = false;
            this.bt_Deleta.Click += new System.EventHandler(this.bt_Deleta_Click);
            // 
            // bt_gravar
            // 
            this.bt_gravar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.bt_gravar, "bt_gravar");
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.UseVisualStyleBackColor = false;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // Titulo_Form_pecas
            // 
            resources.ApplyResources(this.Titulo_Form_pecas, "Titulo_Form_pecas");
            this.Titulo_Form_pecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo_Form_pecas.Name = "Titulo_Form_pecas";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // dtp_Admissão
            // 
            this.dtp_Admissão.Checked = false;
            this.dtp_Admissão.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtp_Admissão, "dtp_Admissão");
            this.dtp_Admissão.Name = "dtp_Admissão";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.msktb_CEP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_bairrro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_complemento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_numerocasa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_endrua);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // msktb_CEP
            // 
            resources.ApplyResources(this.msktb_CEP, "msktb_CEP");
            this.msktb_CEP.Name = "msktb_CEP";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // tb_bairrro
            // 
            resources.ApplyResources(this.tb_bairrro, "tb_bairrro");
            this.tb_bairrro.Name = "tb_bairrro";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // tb_complemento
            // 
            resources.ApplyResources(this.tb_complemento, "tb_complemento");
            this.tb_complemento.Name = "tb_complemento";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tb_numerocasa
            // 
            resources.ApplyResources(this.tb_numerocasa, "tb_numerocasa");
            this.tb_numerocasa.Name = "tb_numerocasa";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tb_endrua
            // 
            resources.ApplyResources(this.tb_endrua, "tb_endrua");
            this.tb_endrua.Name = "tb_endrua";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // cmb_estadocivil
            // 
            this.cmb_estadocivil.FormattingEnabled = true;
            this.cmb_estadocivil.Items.AddRange(new object[] {
            resources.GetString("cmb_estadocivil.Items"),
            resources.GetString("cmb_estadocivil.Items1"),
            resources.GetString("cmb_estadocivil.Items2"),
            resources.GetString("cmb_estadocivil.Items3")});
            resources.ApplyResources(this.cmb_estadocivil, "cmb_estadocivil");
            this.cmb_estadocivil.Name = "cmb_estadocivil";
            // 
            // msktb_TelCelular
            // 
            resources.ApplyResources(this.msktb_TelCelular, "msktb_TelCelular");
            this.msktb_TelCelular.Name = "msktb_TelCelular";
            // 
            // msktb_Telfixo
            // 
            resources.ApplyResources(this.msktb_Telfixo, "msktb_Telfixo");
            this.msktb_Telfixo.Name = "msktb_Telfixo";
            // 
            // msktb_CPF
            // 
            resources.ApplyResources(this.msktb_CPF, "msktb_CPF");
            this.msktb_CPF.Name = "msktb_CPF";
            // 
            // tb_CodigoVendedor
            // 
            resources.ApplyResources(this.tb_CodigoVendedor, "tb_CodigoVendedor");
            this.tb_CodigoVendedor.Name = "tb_CodigoVendedor";
            // 
            // tb_NomeVendedor
            // 
            resources.ApplyResources(this.tb_NomeVendedor, "tb_NomeVendedor");
            this.tb_NomeVendedor.Name = "tb_NomeVendedor";
            // 
            // dtg_Vendedor
            // 
            this.dtg_Vendedor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtg_Vendedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Vendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtg_Vendedor, "dtg_Vendedor");
            this.dtg_Vendedor.Name = "dtg_Vendedor";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form_Vendedor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dtg_Vendedor);
            this.Controls.Add(this.cmb_estadocivil);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.msktb_TelCelular);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.msktb_Telfixo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.msktb_CPF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_Admissão);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_CodigoVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_NomeVendedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Titulo_Form_pecas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Vendedor";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form_Vendedor_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Vendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_filtrar;
        private System.Windows.Forms.Button Bt_busca1;
        private System.Windows.Forms.Button bt_Atualiza;
        private System.Windows.Forms.Button bt_Deleta;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.Label Titulo_Form_pecas;
        private System.Windows.Forms.Label label1;
        private AutoPeçasUI.MyTextBox tb_NomeVendedor;
        private AutoPeçasUI.MyTextBox tb_CodigoVendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Admissão;
        private System.Windows.Forms.GroupBox groupBox1;
        private Msktextbox msktb_CEP;
        private System.Windows.Forms.Label label8;
        private AutoPeçasUI.MyTextBox tb_bairrro;
        private System.Windows.Forms.Label label7;
        private AutoPeçasUI.MyTextBox tb_complemento;
        private System.Windows.Forms.Label label6;
        private AutoPeçasUI.MyTextBox tb_numerocasa;
        private System.Windows.Forms.Label label4;
        private AutoPeçasUI.MyTextBox tb_endrua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private Msktextbox msktb_CPF;
        private System.Windows.Forms.Label label10;
        private Msktextbox msktb_Telfixo;
        private System.Windows.Forms.Label label11;
        private Msktextbox msktb_TelCelular;
        private System.Windows.Forms.Label label12;
        private MyComboBox cmb_estadocivil;
        private System.Windows.Forms.DataGridView dtg_Vendedor;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}