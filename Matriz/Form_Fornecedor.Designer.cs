namespace Matriz
{
    partial class Form_Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Fornecedor));
            this.lb_codigofornecedor = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msktb_CEP = new Matriz.Msktextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_bairro = new AutoPeçasUI.MyTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_complemento = new AutoPeçasUI.MyTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_numendereco = new AutoPeçasUI.MyTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_endrua = new AutoPeçasUI.MyTextBox();
            this.ckb_Filtrar = new System.Windows.Forms.CheckBox();
            this.tb_filtro = new AutoPeçasUI.MyTextBox();
            this.msktb_CNPJ = new Matriz.Msktextbox();
            this.tb_NomeFornecedor = new AutoPeçasUI.MyTextBox();
            this.tb_IDFornecedor = new AutoPeçasUI.MyTextBox();
            this.msk_telfixo = new Matriz.Msktextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskt_telcel = new Matriz.Msktextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgv_fornecedores = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_Fornecedor = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_fornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_codigofornecedor
            // 
            this.lb_codigofornecedor.AutoSize = true;
            this.lb_codigofornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigofornecedor.Location = new System.Drawing.Point(300, 97);
            this.lb_codigofornecedor.Name = "lb_codigofornecedor";
            this.lb_codigofornecedor.Size = new System.Drawing.Size(132, 20);
            this.lb_codigofornecedor.TabIndex = 0;
            this.lb_codigofornecedor.Text = "Cód. Fornecedor:";
            this.lb_codigofornecedor.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Sair);
            this.panel1.Controls.Add(this.bt_filtrar);
            this.panel1.Controls.Add(this.Bt_busca1);
            this.panel1.Controls.Add(this.bt_Atualiza);
            this.panel1.Controls.Add(this.bt_Deleta);
            this.panel1.Controls.Add(this.bt_gravar);
            this.panel1.Location = new System.Drawing.Point(630, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 73);
            this.panel1.TabIndex = 7;
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Sair.BackgroundImage")));
            this.bt_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.Location = new System.Drawing.Point(320, 19);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(45, 44);
            this.bt_Sair.TabIndex = 5;
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
            this.bt_filtrar.Location = new System.Drawing.Point(210, 18);
            this.bt_filtrar.Name = "bt_filtrar";
            this.bt_filtrar.Size = new System.Drawing.Size(47, 44);
            this.bt_filtrar.TabIndex = 4;
            this.bt_filtrar.UseVisualStyleBackColor = false;
            this.bt_filtrar.Click += new System.EventHandler(this.bt_filtrar_Click);
            // 
            // Bt_busca1
            // 
            this.Bt_busca1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_busca1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_busca1.BackgroundImage")));
            this.Bt_busca1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_busca1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_busca1.Location = new System.Drawing.Point(162, 18);
            this.Bt_busca1.Name = "Bt_busca1";
            this.Bt_busca1.Size = new System.Drawing.Size(47, 44);
            this.Bt_busca1.TabIndex = 3;
            this.Bt_busca1.UseVisualStyleBackColor = false;
            this.Bt_busca1.Click += new System.EventHandler(this.Bt_busca1_Click);
            // 
            // bt_Atualiza
            // 
            this.bt_Atualiza.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Atualiza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Atualiza.BackgroundImage")));
            this.bt_Atualiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Atualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Atualiza.Location = new System.Drawing.Point(69, 18);
            this.bt_Atualiza.Name = "bt_Atualiza";
            this.bt_Atualiza.Size = new System.Drawing.Size(47, 44);
            this.bt_Atualiza.TabIndex = 1;
            this.bt_Atualiza.UseVisualStyleBackColor = false;
            this.bt_Atualiza.Click += new System.EventHandler(this.bt_Atualiza_Click);
            // 
            // bt_Deleta
            // 
            this.bt_Deleta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Deleta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Deleta.BackgroundImage")));
            this.bt_Deleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Deleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Deleta.Location = new System.Drawing.Point(115, 18);
            this.bt_Deleta.Name = "bt_Deleta";
            this.bt_Deleta.Size = new System.Drawing.Size(47, 44);
            this.bt_Deleta.TabIndex = 2;
            this.bt_Deleta.UseVisualStyleBackColor = false;
            this.bt_Deleta.Click += new System.EventHandler(this.bt_Deleta_Click);
            // 
            // bt_gravar
            // 
            this.bt_gravar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_gravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_gravar.BackgroundImage")));
            this.bt_gravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gravar.Location = new System.Drawing.Point(22, 18);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(47, 44);
            this.bt_gravar.TabIndex = 0;
            this.bt_gravar.UseVisualStyleBackColor = false;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // Titulo_Form_pecas
            // 
            this.Titulo_Form_pecas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo_Form_pecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo_Form_pecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Form_pecas.Location = new System.Drawing.Point(0, 0);
            this.Titulo_Form_pecas.Name = "Titulo_Form_pecas";
            this.Titulo_Form_pecas.Size = new System.Drawing.Size(1146, 51);
            this.Titulo_Form_pecas.TabIndex = 13;
            this.Titulo_Form_pecas.Text = "Cadastrar Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome do Fornecedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Logr.:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.msktb_CEP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_bairro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_complemento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_numendereco);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_endrua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 173);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 101);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço:";
            // 
            // msktb_CEP
            // 
            this.msktb_CEP.Location = new System.Drawing.Point(340, 66);
            this.msktb_CEP.Mask = "00000-999";
            this.msktb_CEP.Name = "msktb_CEP";
            this.msktb_CEP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msktb_CEP.Size = new System.Drawing.Size(72, 26);
            this.msktb_CEP.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(298, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "CEP:";
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(66, 67);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(207, 26);
            this.tb_bairro.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Bairro:";
            // 
            // tb_complemento
            // 
            this.tb_complemento.Location = new System.Drawing.Point(708, 22);
            this.tb_complemento.Name = "tb_complemento";
            this.tb_complemento.Size = new System.Drawing.Size(255, 26);
            this.tb_complemento.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(597, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Complemento:";
            // 
            // tb_numendereco
            // 
            this.tb_numendereco.Location = new System.Drawing.Point(529, 22);
            this.tb_numendereco.Name = "tb_numendereco";
            this.tb_numendereco.Size = new System.Drawing.Size(46, 26);
            this.tb_numendereco.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(502, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nº";
            // 
            // tb_endrua
            // 
            this.tb_endrua.Location = new System.Drawing.Point(57, 25);
            this.tb_endrua.Name = "tb_endrua";
            this.tb_endrua.Size = new System.Drawing.Size(419, 26);
            this.tb_endrua.TabIndex = 0;
            // 
            // ckb_Filtrar
            // 
            this.ckb_Filtrar.AutoSize = true;
            this.ckb_Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Filtrar.Location = new System.Drawing.Point(515, 96);
            this.ckb_Filtrar.Name = "ckb_Filtrar";
            this.ckb_Filtrar.Size = new System.Drawing.Size(68, 24);
            this.ckb_Filtrar.TabIndex = 25;
            this.ckb_Filtrar.Text = "Filtrar";
            this.ckb_Filtrar.UseVisualStyleBackColor = true;
            this.ckb_Filtrar.CheckedChanged += new System.EventHandler(this.ckb_Filtrar_CheckedChanged);
            // 
            // tb_filtro
            // 
            this.tb_filtro.Location = new System.Drawing.Point(586, 96);
            this.tb_filtro.Name = "tb_filtro";
            this.tb_filtro.Size = new System.Drawing.Size(73, 20);
            this.tb_filtro.TabIndex = 4;
            this.tb_filtro.Visible = false;
            // 
            // msktb_CNPJ
            // 
            this.msktb_CNPJ.BackColor = System.Drawing.SystemColors.Window;
            this.msktb_CNPJ.Location = new System.Drawing.Point(73, 96);
            this.msktb_CNPJ.Mask = "00000000/0000";
            this.msktb_CNPJ.Name = "msktb_CNPJ";
            this.msktb_CNPJ.RejectInputOnFirstFailure = true;
            this.msktb_CNPJ.ResetOnPrompt = false;
            this.msktb_CNPJ.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msktb_CNPJ.Size = new System.Drawing.Size(132, 20);
            this.msktb_CNPJ.TabIndex = 2;
            // 
            // tb_NomeFornecedor
            // 
            this.tb_NomeFornecedor.Location = new System.Drawing.Point(167, 66);
            this.tb_NomeFornecedor.Name = "tb_NomeFornecedor";
            this.tb_NomeFornecedor.Size = new System.Drawing.Size(265, 20);
            this.tb_NomeFornecedor.TabIndex = 3;
            // 
            // tb_IDFornecedor
            // 
            this.tb_IDFornecedor.Location = new System.Drawing.Point(428, 97);
            this.tb_IDFornecedor.Name = "tb_IDFornecedor";
            this.tb_IDFornecedor.Size = new System.Drawing.Size(42, 20);
            this.tb_IDFornecedor.TabIndex = 1;
            this.tb_IDFornecedor.Visible = false;
            // 
            // msk_telfixo
            // 
            this.msk_telfixo.BackColor = System.Drawing.SystemColors.Window;
            this.msk_telfixo.Location = new System.Drawing.Point(123, 135);
            this.msk_telfixo.Mask = "(99) 0000-0000";
            this.msk_telfixo.Name = "msk_telfixo";
            this.msk_telfixo.RejectInputOnFirstFailure = true;
            this.msk_telfixo.ResetOnPrompt = false;
            this.msk_telfixo.Size = new System.Drawing.Size(82, 20);
            this.msk_telfixo.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Telefone Fixo:";
            // 
            // mskt_telcel
            // 
            this.mskt_telcel.BackColor = System.Drawing.SystemColors.Window;
            this.mskt_telcel.Location = new System.Drawing.Point(360, 135);
            this.mskt_telcel.Mask = "(99) 0000-0000";
            this.mskt_telcel.Name = "mskt_telcel";
            this.mskt_telcel.RejectInputOnFirstFailure = true;
            this.mskt_telcel.ResetOnPrompt = false;
            this.mskt_telcel.Size = new System.Drawing.Size(82, 20);
            this.mskt_telcel.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(231, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Telefone Celular:";
            // 
            // dtgv_fornecedores
            // 
            this.dtgv_fornecedores.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgv_fornecedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_fornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_fornecedores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_fornecedores.Location = new System.Drawing.Point(0, 288);
            this.dtgv_fornecedores.Name = "dtgv_fornecedores";
            this.dtgv_fornecedores.Size = new System.Drawing.Size(1146, 267);
            this.dtgv_fornecedores.TabIndex = 30;
            this.dtgv_fornecedores.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_fornecedores_CellMouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(459, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Data do Contrato:";
            // 
            // dtp_Fornecedor
            // 
            this.dtp_Fornecedor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fornecedor.Location = new System.Drawing.Point(592, 135);
            this.dtp_Fornecedor.Name = "dtp_Fornecedor";
            this.dtp_Fornecedor.Size = new System.Drawing.Size(96, 20);
            this.dtp_Fornecedor.TabIndex = 33;
            // 
            // Form_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1146, 555);
            this.ControlBox = false;
            this.Controls.Add(this.dtp_Fornecedor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtgv_fornecedores);
            this.Controls.Add(this.mskt_telcel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.msk_telfixo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ckb_Filtrar);
            this.Controls.Add(this.tb_filtro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msktb_CNPJ);
            this.Controls.Add(this.tb_NomeFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Titulo_Form_pecas);
            this.Controls.Add(this.lb_codigofornecedor);
            this.Controls.Add(this.tb_IDFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Fornecedor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Fornecedor_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_fornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_codigofornecedor;
        private AutoPeçasUI.MyTextBox tb_IDFornecedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_filtrar;
        private System.Windows.Forms.Button Bt_busca1;
        private System.Windows.Forms.Button bt_Atualiza;
        private System.Windows.Forms.Button bt_Deleta;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.Label Titulo_Form_pecas;
        private AutoPeçasUI.MyTextBox tb_NomeFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Msktextbox msktb_CNPJ;
        private System.Windows.Forms.Label label3;
        private AutoPeçasUI.MyTextBox tb_endrua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private AutoPeçasUI.MyTextBox tb_bairro;
        private System.Windows.Forms.Label label7;
        private AutoPeçasUI.MyTextBox tb_complemento;
        private System.Windows.Forms.Label label6;
        private AutoPeçasUI.MyTextBox tb_numendereco;
        private System.Windows.Forms.Label label4;
        private Msktextbox msktb_CEP;
        private System.Windows.Forms.CheckBox ckb_Filtrar;
        private AutoPeçasUI.MyTextBox tb_filtro;
        private Msktextbox msk_telfixo;
        private System.Windows.Forms.Label label9;
        private Msktextbox mskt_telcel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgv_fornecedores;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_Fornecedor;
    }
}