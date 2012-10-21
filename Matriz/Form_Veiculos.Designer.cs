namespace Matriz
{
    partial class Form_Veiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Veiculos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_filtrar = new System.Windows.Forms.Button();
            this.Bt_busca1 = new System.Windows.Forms.Button();
            this.bt_Atualiza = new System.Windows.Forms.Button();
            this.bt_Deleta = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.dtg_Veiculos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_codigoveiculo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckb_FiltrarVeiculo = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_fabricante = new Matriz.MyComboBox();
            this.dtp_Inicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_Final = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_filtrarveiculo = new AutoPeçasUI.MyTextBox();
            this.tb_IDVeiculo = new AutoPeçasUI.MyTextBox();
            this.tb_NomeVeiculo = new AutoPeçasUI.MyTextBox();
            this.Titulo_Form_pecas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Veiculos)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(661, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 73);
            this.panel1.TabIndex = 12;
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Sair.BackgroundImage")));
            this.bt_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.Location = new System.Drawing.Point(326, 19);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(45, 44);
            this.bt_Sair.TabIndex = 11;
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_filtrar
            // 
            this.bt_filtrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_filtrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_filtrar.BackgroundImage")));
            this.bt_filtrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_filtrar.Enabled = false;
            this.bt_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_filtrar.Location = new System.Drawing.Point(226, 18);
            this.bt_filtrar.Name = "bt_filtrar";
            this.bt_filtrar.Size = new System.Drawing.Size(45, 44);
            this.bt_filtrar.TabIndex = 10;
            this.bt_filtrar.UseVisualStyleBackColor = false;
            // 
            // Bt_busca1
            // 
            this.Bt_busca1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_busca1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_busca1.BackgroundImage")));
            this.Bt_busca1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_busca1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_busca1.Location = new System.Drawing.Point(175, 19);
            this.Bt_busca1.Name = "Bt_busca1";
            this.Bt_busca1.Size = new System.Drawing.Size(45, 44);
            this.Bt_busca1.TabIndex = 6;
            this.Bt_busca1.UseVisualStyleBackColor = false;
            this.Bt_busca1.Click += new System.EventHandler(this.Bt_busca1_Click);
            // 
            // bt_Atualiza
            // 
            this.bt_Atualiza.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Atualiza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Atualiza.BackgroundImage")));
            this.bt_Atualiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Atualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Atualiza.Location = new System.Drawing.Point(67, 18);
            this.bt_Atualiza.Name = "bt_Atualiza";
            this.bt_Atualiza.Size = new System.Drawing.Size(46, 44);
            this.bt_Atualiza.TabIndex = 7;
            this.bt_Atualiza.UseVisualStyleBackColor = false;
            this.bt_Atualiza.Click += new System.EventHandler(this.bt_Atualiza_Click);
            // 
            // bt_Deleta
            // 
            this.bt_Deleta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Deleta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Deleta.BackgroundImage")));
            this.bt_Deleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Deleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Deleta.Location = new System.Drawing.Point(119, 17);
            this.bt_Deleta.Name = "bt_Deleta";
            this.bt_Deleta.Size = new System.Drawing.Size(50, 46);
            this.bt_Deleta.TabIndex = 8;
            this.bt_Deleta.UseVisualStyleBackColor = false;
            this.bt_Deleta.Click += new System.EventHandler(this.bt_Deleta_Click);
            // 
            // bt_gravar
            // 
            this.bt_gravar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_gravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_gravar.BackgroundImage")));
            this.bt_gravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gravar.Location = new System.Drawing.Point(14, 18);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(47, 44);
            this.bt_gravar.TabIndex = 9;
            this.bt_gravar.UseVisualStyleBackColor = false;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // dtg_Veiculos
            // 
            this.dtg_Veiculos.AllowUserToAddRows = false;
            this.dtg_Veiculos.AllowUserToDeleteRows = false;
            this.dtg_Veiculos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtg_Veiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Veiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Veiculos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_Veiculos.Location = new System.Drawing.Point(0, 185);
            this.dtg_Veiculos.Name = "dtg_Veiculos";
            this.dtg_Veiculos.ReadOnly = true;
            this.dtg_Veiculos.Size = new System.Drawing.Size(1076, 386);
            this.dtg_Veiculos.TabIndex = 13;
            this.dtg_Veiculos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtg_Veiculos_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Veiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ano Inicial:";
            // 
            // lb_codigoveiculo
            // 
            this.lb_codigoveiculo.AutoSize = true;
            this.lb_codigoveiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigoveiculo.Location = new System.Drawing.Point(257, 7);
            this.lb_codigoveiculo.Name = "lb_codigoveiculo";
            this.lb_codigoveiculo.Size = new System.Drawing.Size(63, 20);
            this.lb_codigoveiculo.TabIndex = 18;
            this.lb_codigoveiculo.Text = "Código:";
            this.lb_codigoveiculo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fabricante:";
            // 
            // ckb_FiltrarVeiculo
            // 
            this.ckb_FiltrarVeiculo.AutoSize = true;
            this.ckb_FiltrarVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_FiltrarVeiculo.Location = new System.Drawing.Point(392, 7);
            this.ckb_FiltrarVeiculo.Name = "ckb_FiltrarVeiculo";
            this.ckb_FiltrarVeiculo.Size = new System.Drawing.Size(72, 24);
            this.ckb_FiltrarVeiculo.TabIndex = 22;
            this.ckb_FiltrarVeiculo.Text = "Filtrar:";
            this.ckb_FiltrarVeiculo.UseVisualStyleBackColor = true;
            this.ckb_FiltrarVeiculo.CheckedChanged += new System.EventHandler(this.ckb_FiltrarVeiculo_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_fabricante);
            this.panel2.Controls.Add(this.dtp_Inicial);
            this.panel2.Controls.Add(this.dtp_Final);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tb_filtrarveiculo);
            this.panel2.Controls.Add(this.ckb_FiltrarVeiculo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tb_IDVeiculo);
            this.panel2.Controls.Add(this.lb_codigoveiculo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tb_NomeVeiculo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 84);
            this.panel2.TabIndex = 24;
            // 
            // cb_fabricante
            // 
            this.cb_fabricante.FormattingEnabled = true;
            this.cb_fabricante.Items.AddRange(new object[] {
            "Agrale",
            "Fiat",
            "Ford",
            "Chevrolet",
            "Volkswagen",
            "Dodge"});
            this.cb_fabricante.Location = new System.Drawing.Point(447, 42);
            this.cb_fabricante.Name = "cb_fabricante";
            this.cb_fabricante.Size = new System.Drawing.Size(121, 21);
            this.cb_fabricante.TabIndex = 27;
            // 
            // dtp_Inicial
            // 
            this.dtp_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Inicial.Location = new System.Drawing.Point(93, 41);
            this.dtp_Inicial.Name = "dtp_Inicial";
            this.dtp_Inicial.Size = new System.Drawing.Size(82, 20);
            this.dtp_Inicial.TabIndex = 26;
            // 
            // dtp_Final
            // 
            this.dtp_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Final.Location = new System.Drawing.Point(261, 41);
            this.dtp_Final.Name = "dtp_Final";
            this.dtp_Final.Size = new System.Drawing.Size(82, 20);
            this.dtp_Final.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ano Final:";
            // 
            // tb_filtrarveiculo
            // 
            this.tb_filtrarveiculo.Location = new System.Drawing.Point(458, 7);
            this.tb_filtrarveiculo.Name = "tb_filtrarveiculo";
            this.tb_filtrarveiculo.Size = new System.Drawing.Size(162, 20);
            this.tb_filtrarveiculo.TabIndex = 23;
            this.tb_filtrarveiculo.Visible = false;
            // 
            // tb_IDVeiculo
            // 
            this.tb_IDVeiculo.Location = new System.Drawing.Point(317, 6);
            this.tb_IDVeiculo.Name = "tb_IDVeiculo";
            this.tb_IDVeiculo.Size = new System.Drawing.Size(54, 20);
            this.tb_IDVeiculo.TabIndex = 19;
            this.tb_IDVeiculo.Visible = false;
            // 
            // tb_NomeVeiculo
            // 
            this.tb_NomeVeiculo.Location = new System.Drawing.Point(74, 7);
            this.tb_NomeVeiculo.Name = "tb_NomeVeiculo";
            this.tb_NomeVeiculo.Size = new System.Drawing.Size(166, 20);
            this.tb_NomeVeiculo.TabIndex = 15;
            // 
            // Titulo_Form_pecas
            // 
            this.Titulo_Form_pecas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo_Form_pecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo_Form_pecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Form_pecas.Location = new System.Drawing.Point(0, 0);
            this.Titulo_Form_pecas.Name = "Titulo_Form_pecas";
            this.Titulo_Form_pecas.Size = new System.Drawing.Size(1076, 51);
            this.Titulo_Form_pecas.TabIndex = 25;
            this.Titulo_Form_pecas.Text = "Cadastrar Veículos";
            // 
            // Form_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1076, 571);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtg_Veiculos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Titulo_Form_pecas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Veiculos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Veiculos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Veiculos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_filtrar;
        private System.Windows.Forms.Button Bt_busca1;
        private System.Windows.Forms.Button bt_Atualiza;
        private System.Windows.Forms.Button bt_Deleta;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.DataGridView dtg_Veiculos;
        private System.Windows.Forms.Label label1;
        private AutoPeçasUI.MyTextBox tb_NomeVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_codigoveiculo;
        private AutoPeçasUI.MyTextBox tb_IDVeiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckb_FiltrarVeiculo;
        private AutoPeçasUI.MyTextBox tb_filtrarveiculo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Titulo_Form_pecas;
        private System.Windows.Forms.DateTimePicker dtp_Inicial;
        private System.Windows.Forms.DateTimePicker dtp_Final;
        private System.Windows.Forms.Label label5;
        private MyComboBox cb_fabricante;
    }
}