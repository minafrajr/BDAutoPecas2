namespace Matriz
{
    partial class Form_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cliente));
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_estado = new Matriz.MyComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Cidade = new AutoPeçasUI.MyTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mask_CEP = new Matriz.Msktextbox();
            this.tb_Bairro = new AutoPeçasUI.MyTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_NumeroComplemento = new AutoPeçasUI.MyTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Logradouro = new AutoPeçasUI.MyTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_filtrar = new System.Windows.Forms.Button();
            this.Bt_busca1 = new System.Windows.Forms.Button();
            this.bt_Atualiza = new System.Windows.Forms.Button();
            this.bt_Deleta = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo_Form_pecas = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_CodigoCliente = new AutoPeçasUI.MyTextBox();
            this.lb_Cod = new System.Windows.Forms.Label();
            this.mask_CPFCNPJ = new Matriz.Msktextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.radio_PJ = new System.Windows.Forms.RadioButton();
            this.radio_PF = new System.Windows.Forms.RadioButton();
            this.mask_TelefoneCelular = new Matriz.Msktextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.mask_TelefoneFixo = new Matriz.Msktextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_NomeCliente = new AutoPeçasUI.MyTextBox();
            this.dtg_Cliente = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "CEP:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.cmb_estado);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tb_Cidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mask_CEP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_Bairro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_NumeroComplemento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_Logradouro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 188);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 102);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço:";
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "RS",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmb_estado.Location = new System.Drawing.Point(751, 55);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(54, 24);
            this.cmb_estado.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(713, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "UF: ";
            // 
            // tb_Cidade
            // 
            this.tb_Cidade.Location = new System.Drawing.Point(520, 57);
            this.tb_Cidade.Name = "tb_Cidade";
            this.tb_Cidade.Size = new System.Drawing.Size(179, 22);
            this.tb_Cidade.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cidade: ";
            // 
            // mask_CEP
            // 
            this.mask_CEP.Location = new System.Drawing.Point(348, 57);
            this.mask_CEP.Mask = "00000-999";
            this.mask_CEP.Name = "mask_CEP";
            this.mask_CEP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mask_CEP.Size = new System.Drawing.Size(72, 22);
            this.mask_CEP.TabIndex = 9;
            // 
            // tb_Bairro
            // 
            this.tb_Bairro.Location = new System.Drawing.Point(66, 57);
            this.tb_Bairro.Name = "tb_Bairro";
            this.tb_Bairro.Size = new System.Drawing.Size(207, 22);
            this.tb_Bairro.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Bairro:";
            // 
            // tb_NumeroComplemento
            // 
            this.tb_NumeroComplemento.Location = new System.Drawing.Point(595, 21);
            this.tb_NumeroComplemento.Name = "tb_NumeroComplemento";
            this.tb_NumeroComplemento.Size = new System.Drawing.Size(104, 22);
            this.tb_NumeroComplemento.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(502, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nº/Comp:";
            // 
            // tb_Logradouro
            // 
            this.tb_Logradouro.Location = new System.Drawing.Point(66, 21);
            this.tb_Logradouro.Name = "tb_Logradouro";
            this.tb_Logradouro.Size = new System.Drawing.Size(419, 22);
            this.tb_Logradouro.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Logr.:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Sair);
            this.panel1.Controls.Add(this.bt_filtrar);
            this.panel1.Controls.Add(this.Bt_busca1);
            this.panel1.Controls.Add(this.bt_Atualiza);
            this.panel1.Controls.Add(this.bt_Deleta);
            this.panel1.Controls.Add(this.bt_gravar);
            this.panel1.Location = new System.Drawing.Point(518, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 73);
            this.panel1.TabIndex = 32;
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
            this.bt_filtrar.Location = new System.Drawing.Point(226, 17);
            this.bt_filtrar.Name = "bt_filtrar";
            this.bt_filtrar.Size = new System.Drawing.Size(45, 45);
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
            this.Bt_busca1.Location = new System.Drawing.Point(175, 17);
            this.Bt_busca1.Name = "Bt_busca1";
            this.Bt_busca1.Size = new System.Drawing.Size(45, 46);
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
            this.bt_Atualiza.Location = new System.Drawing.Point(67, 18);
            this.bt_Atualiza.Name = "bt_Atualiza";
            this.bt_Atualiza.Size = new System.Drawing.Size(46, 45);
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
            this.bt_Deleta.Location = new System.Drawing.Point(119, 17);
            this.bt_Deleta.Name = "bt_Deleta";
            this.bt_Deleta.Size = new System.Drawing.Size(50, 46);
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
            this.bt_gravar.Location = new System.Drawing.Point(14, 17);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(47, 44);
            this.bt_gravar.TabIndex = 0;
            this.bt_gravar.UseVisualStyleBackColor = false;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome:";
            // 
            // Titulo_Form_pecas
            // 
            this.Titulo_Form_pecas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo_Form_pecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo_Form_pecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Form_pecas.Location = new System.Drawing.Point(0, 0);
            this.Titulo_Form_pecas.Name = "Titulo_Form_pecas";
            this.Titulo_Form_pecas.Size = new System.Drawing.Size(1029, 51);
            this.Titulo_Form_pecas.TabIndex = 34;
            this.Titulo_Form_pecas.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_CodigoCliente);
            this.groupBox2.Controls.Add(this.lb_Cod);
            this.groupBox2.Controls.Add(this.mask_CPFCNPJ);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.radio_PJ);
            this.groupBox2.Controls.Add(this.radio_PF);
            this.groupBox2.Controls.Add(this.mask_TelefoneCelular);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mask_TelefoneFixo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_NomeCliente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // tb_CodigoCliente
            // 
            this.tb_CodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CodigoCliente.Location = new System.Drawing.Point(795, 54);
            this.tb_CodigoCliente.Name = "tb_CodigoCliente";
            this.tb_CodigoCliente.ReadOnly = true;
            this.tb_CodigoCliente.Size = new System.Drawing.Size(63, 22);
            this.tb_CodigoCliente.TabIndex = 5;
            this.tb_CodigoCliente.Visible = false;
            // 
            // lb_Cod
            // 
            this.lb_Cod.AutoSize = true;
            this.lb_Cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cod.Location = new System.Drawing.Point(747, 54);
            this.lb_Cod.Name = "lb_Cod";
            this.lb_Cod.Size = new System.Drawing.Size(42, 20);
            this.lb_Cod.TabIndex = 45;
            this.lb_Cod.Text = "Cod:";
            this.lb_Cod.Visible = false;
            // 
            // mask_CPFCNPJ
            // 
            this.mask_CPFCNPJ.Location = new System.Drawing.Point(586, 54);
            this.mask_CPFCNPJ.Mask = "000,000,000-00";
            this.mask_CPFCNPJ.Name = "mask_CPFCNPJ";
            this.mask_CPFCNPJ.Size = new System.Drawing.Size(141, 22);
            this.mask_CPFCNPJ.TabIndex = 4;
            this.mask_CPFCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "CPF/CNPJ:";
            // 
            // radio_PJ
            // 
            this.radio_PJ.AutoSize = true;
            this.radio_PJ.Location = new System.Drawing.Point(732, 21);
            this.radio_PJ.Name = "radio_PJ";
            this.radio_PJ.Size = new System.Drawing.Size(126, 20);
            this.radio_PJ.TabIndex = 41;
            this.radio_PJ.Text = "Pessoa Jurídica:";
            this.radio_PJ.UseVisualStyleBackColor = true;
            // 
            // radio_PF
            // 
            this.radio_PF.AutoSize = true;
            this.radio_PF.Checked = true;
            this.radio_PF.Location = new System.Drawing.Point(611, 23);
            this.radio_PF.Name = "radio_PF";
            this.radio_PF.Size = new System.Drawing.Size(115, 20);
            this.radio_PF.TabIndex = 40;
            this.radio_PF.TabStop = true;
            this.radio_PF.Text = "Pessoa Fisica:";
            this.radio_PF.UseVisualStyleBackColor = true;
            this.radio_PF.CheckedChanged += new System.EventHandler(this.radio_PF_CheckedChanged);
            // 
            // mask_TelefoneCelular
            // 
            this.mask_TelefoneCelular.Location = new System.Drawing.Point(325, 54);
            this.mask_TelefoneCelular.Mask = "(99) 0000-0000";
            this.mask_TelefoneCelular.Name = "mask_TelefoneCelular";
            this.mask_TelefoneCelular.Size = new System.Drawing.Size(139, 22);
            this.mask_TelefoneCelular.TabIndex = 3;
            this.mask_TelefoneCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Celular:";
            // 
            // mask_TelefoneFixo
            // 
            this.mask_TelefoneFixo.Location = new System.Drawing.Point(85, 54);
            this.mask_TelefoneFixo.Mask = "(99) 0000-0000";
            this.mask_TelefoneFixo.Name = "mask_TelefoneFixo";
            this.mask_TelefoneFixo.Size = new System.Drawing.Size(139, 22);
            this.mask_TelefoneFixo.TabIndex = 2;
            this.mask_TelefoneFixo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Telefone:";
            // 
            // tb_NomeCliente
            // 
            this.tb_NomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NomeCliente.Location = new System.Drawing.Point(85, 21);
            this.tb_NomeCliente.Name = "tb_NomeCliente";
            this.tb_NomeCliente.Size = new System.Drawing.Size(509, 22);
            this.tb_NomeCliente.TabIndex = 1;
            // 
            // dtg_Cliente
            // 
            this.dtg_Cliente.AllowUserToAddRows = false;
            this.dtg_Cliente.AllowUserToDeleteRows = false;
            this.dtg_Cliente.AllowUserToResizeColumns = false;
            this.dtg_Cliente.AllowUserToResizeRows = false;
            this.dtg_Cliente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtg_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Cliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_Cliente.Location = new System.Drawing.Point(0, 306);
            this.dtg_Cliente.MultiSelect = false;
            this.dtg_Cliente.Name = "dtg_Cliente";
            this.dtg_Cliente.ReadOnly = true;
            this.dtg_Cliente.Size = new System.Drawing.Size(1029, 224);
            this.dtg_Cliente.TabIndex = 35;
            this.dtg_Cliente.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtg_Cliente_CellMouseClick);
            // 
            // Form_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1029, 530);
            this.ControlBox = false;
            this.Controls.Add(this.dtg_Cliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Titulo_Form_pecas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Cliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Cliente";
            this.Load += new System.EventHandler(this.Form_Cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Msktextbox mask_CEP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private AutoPeçasUI.MyTextBox tb_Bairro;
        private System.Windows.Forms.Label label7;
        private AutoPeçasUI.MyTextBox tb_NumeroComplemento;
        private System.Windows.Forms.Label label4;
        private AutoPeçasUI.MyTextBox tb_Logradouro;
        private System.Windows.Forms.Label label3;
        private AutoPeçasUI.MyTextBox tb_NomeCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_filtrar;
        private System.Windows.Forms.Button Bt_busca1;
        private System.Windows.Forms.Button bt_Atualiza;
        private System.Windows.Forms.Button bt_Deleta;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo_Form_pecas;
        private AutoPeçasUI.MyTextBox tb_Cidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private Msktextbox mask_TelefoneFixo;
        private Msktextbox mask_TelefoneCelular;
        private System.Windows.Forms.Label label6;
        private Msktextbox mask_CPFCNPJ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radio_PJ;
        private System.Windows.Forms.RadioButton radio_PF;
        private System.Windows.Forms.Label label10;
        private MyComboBox cmb_estado;
        private System.Windows.Forms.DataGridView dtg_Cliente;
        private AutoPeçasUI.MyTextBox tb_CodigoCliente;
        private System.Windows.Forms.Label lb_Cod;
    }
}