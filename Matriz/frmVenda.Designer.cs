namespace Matriz
{
    partial class frmVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.Titulo_Form_pecas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_Atualiza = new System.Windows.Forms.Button();
            this.bt_Deleta = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.dtg_Venda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_descricaoPeca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Concluir = new System.Windows.Forms.Button();
            this.bt_ConsultaPeca = new System.Windows.Forms.Button();
            this.bt_PesquisarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgw_auxiliarCliente = new System.Windows.Forms.DataGridView();
            this.tb_quantidadePecaEstoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.num_quantidadePecas = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgw_auxiliarPecas = new System.Windows.Forms.DataGridView();
            this.tb_IDVenda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_CondVendedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.num_desconto = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_IDItensVenda = new System.Windows.Forms.TextBox();
            this.tb_codCliente = new AutoPeçasUI.MyTextBox();
            this.tb_codPeca = new AutoPeçasUI.MyTextBox();
            this.tb_Cliente = new AutoPeçasUI.MyTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_auxiliarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantidadePecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_auxiliarPecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_desconto)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo_Form_pecas
            // 
            this.Titulo_Form_pecas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo_Form_pecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo_Form_pecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.Titulo_Form_pecas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Titulo_Form_pecas.Location = new System.Drawing.Point(0, 0);
            this.Titulo_Form_pecas.Name = "Titulo_Form_pecas";
            this.Titulo_Form_pecas.Size = new System.Drawing.Size(959, 51);
            this.Titulo_Form_pecas.TabIndex = 1;
            this.Titulo_Form_pecas.Text = "Gerar Venda";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Sair);
            this.panel1.Controls.Add(this.bt_Atualiza);
            this.panel1.Controls.Add(this.bt_Deleta);
            this.panel1.Controls.Add(this.bt_gravar);
            this.panel1.Location = new System.Drawing.Point(624, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 73);
            this.panel1.TabIndex = 12;
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Sair.BackgroundImage")));
            this.bt_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_Sair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Sair.Location = new System.Drawing.Point(174, 17);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(47, 44);
            this.bt_Sair.TabIndex = 11;
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_Atualiza
            // 
            this.bt_Atualiza.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Atualiza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Atualiza.BackgroundImage")));
            this.bt_Atualiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Atualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_Atualiza.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Atualiza.Location = new System.Drawing.Point(61, 18);
            this.bt_Atualiza.Name = "bt_Atualiza";
            this.bt_Atualiza.Size = new System.Drawing.Size(47, 44);
            this.bt_Atualiza.TabIndex = 7;
            this.bt_Atualiza.UseVisualStyleBackColor = false;
            this.bt_Atualiza.Click += new System.EventHandler(this.bt_Atualiza_Click);
            // 
            // bt_Deleta
            // 
            this.bt_Deleta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Deleta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Deleta.BackgroundImage")));
            this.bt_Deleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Deleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bt_Deleta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Deleta.Location = new System.Drawing.Point(108, 18);
            this.bt_Deleta.Name = "bt_Deleta";
            this.bt_Deleta.Size = new System.Drawing.Size(47, 44);
            this.bt_Deleta.TabIndex = 8;
            this.bt_Deleta.UseVisualStyleBackColor = false;
            this.bt_Deleta.Click += new System.EventHandler(this.bt_Deleta_Click);
            // 
            // bt_gravar
            // 
            this.bt_gravar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_gravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_gravar.BackgroundImage")));
            this.bt_gravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_gravar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_gravar.Location = new System.Drawing.Point(14, 18);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(47, 44);
            this.bt_gravar.TabIndex = 4;
            this.bt_gravar.UseVisualStyleBackColor = false;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // dtg_Venda
            // 
            this.dtg_Venda.AllowUserToAddRows = false;
            this.dtg_Venda.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_Venda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Venda.Location = new System.Drawing.Point(-1, 181);
            this.dtg_Venda.Name = "dtg_Venda";
            this.dtg_Venda.Size = new System.Drawing.Size(780, 266);
            this.dtg_Venda.TabIndex = 13;
            this.dtg_Venda.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtg_Venda_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código Peça:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descrição:";
            // 
            // tb_descricaoPeca
            // 
            this.tb_descricaoPeca.Location = new System.Drawing.Point(132, 140);
            this.tb_descricaoPeca.Multiline = true;
            this.tb_descricaoPeca.Name = "tb_descricaoPeca";
            this.tb_descricaoPeca.ReadOnly = true;
            this.tb_descricaoPeca.Size = new System.Drawing.Size(353, 20);
            this.tb_descricaoPeca.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cliente:";
            // 
            // bt_Concluir
            // 
            this.bt_Concluir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Concluir.BackgroundImage = global::Matriz.Properties.Resources._7689_64x64;
            this.bt_Concluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Concluir.Location = new System.Drawing.Point(897, 126);
            this.bt_Concluir.Name = "bt_Concluir";
            this.bt_Concluir.Size = new System.Drawing.Size(50, 44);
            this.bt_Concluir.TabIndex = 21;
            this.bt_Concluir.UseVisualStyleBackColor = false;
            this.bt_Concluir.Click += new System.EventHandler(this.bt_Concluir_Click);
            // 
            // bt_ConsultaPeca
            // 
            this.bt_ConsultaPeca.Location = new System.Drawing.Point(19, 137);
            this.bt_ConsultaPeca.Name = "bt_ConsultaPeca";
            this.bt_ConsultaPeca.Size = new System.Drawing.Size(33, 23);
            this.bt_ConsultaPeca.TabIndex = 22;
            this.bt_ConsultaPeca.Text = "...";
            this.bt_ConsultaPeca.UseVisualStyleBackColor = true;
            this.bt_ConsultaPeca.Click += new System.EventHandler(this.bt_ConsultaPeca_Click);
            // 
            // bt_PesquisarCliente
            // 
            this.bt_PesquisarCliente.Location = new System.Drawing.Point(19, 80);
            this.bt_PesquisarCliente.Name = "bt_PesquisarCliente";
            this.bt_PesquisarCliente.Size = new System.Drawing.Size(28, 23);
            this.bt_PesquisarCliente.TabIndex = 23;
            this.bt_PesquisarCliente.Text = "...";
            this.bt_PesquisarCliente.UseVisualStyleBackColor = true;
            this.bt_PesquisarCliente.Click += new System.EventHandler(this.bt_PesquisarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cód. Cliente:";
            // 
            // dtgw_auxiliarCliente
            // 
            this.dtgw_auxiliarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgw_auxiliarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgw_auxiliarCliente.Location = new System.Drawing.Point(35, 321);
            this.dtgw_auxiliarCliente.Name = "dtgw_auxiliarCliente";
            this.dtgw_auxiliarCliente.Size = new System.Drawing.Size(450, 98);
            this.dtgw_auxiliarCliente.TabIndex = 26;
            // 
            // tb_quantidadePecaEstoque
            // 
            this.tb_quantidadePecaEstoque.Location = new System.Drawing.Point(539, 139);
            this.tb_quantidadePecaEstoque.Multiline = true;
            this.tb_quantidadePecaEstoque.Name = "tb_quantidadePecaEstoque";
            this.tb_quantidadePecaEstoque.ReadOnly = true;
            this.tb_quantidadePecaEstoque.Size = new System.Drawing.Size(74, 20);
            this.tb_quantidadePecaEstoque.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(497, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Qtde. Estoque:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(619, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Preço Unitario:";
            // 
            // num_quantidadePecas
            // 
            this.num_quantidadePecas.Location = new System.Drawing.Point(794, 140);
            this.num_quantidadePecas.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_quantidadePecas.Name = "num_quantidadePecas";
            this.num_quantidadePecas.Size = new System.Drawing.Size(51, 20);
            this.num_quantidadePecas.TabIndex = 3;
            this.num_quantidadePecas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_quantidadePecas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_quantidadePecas_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(749, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Quantidade:";
            // 
            // dtgw_auxiliarPecas
            // 
            this.dtgw_auxiliarPecas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgw_auxiliarPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgw_auxiliarPecas.Location = new System.Drawing.Point(91, 340);
            this.dtgw_auxiliarPecas.Name = "dtgw_auxiliarPecas";
            this.dtgw_auxiliarPecas.Size = new System.Drawing.Size(413, 98);
            this.dtgw_auxiliarPecas.TabIndex = 34;
            // 
            // tb_IDVenda
            // 
            this.tb_IDVenda.Location = new System.Drawing.Point(365, 29);
            this.tb_IDVenda.Name = "tb_IDVenda";
            this.tb_IDVenda.ReadOnly = true;
            this.tb_IDVenda.Size = new System.Drawing.Size(75, 20);
            this.tb_IDVenda.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Venda nº:";
            // 
            // tb_CondVendedor
            // 
            this.tb_CondVendedor.Location = new System.Drawing.Point(262, 30);
            this.tb_CondVendedor.Name = "tb_CondVendedor";
            this.tb_CondVendedor.ReadOnly = true;
            this.tb_CondVendedor.Size = new System.Drawing.Size(79, 20);
            this.tb_CondVendedor.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(258, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Vendedor:";
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(663, 139);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.ReadOnly = true;
            this.tb_preco.Size = new System.Drawing.Size(69, 20);
            this.tb_preco.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(819, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Total:";
            // 
            // tb_total
            // 
            this.tb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total.Location = new System.Drawing.Point(873, 412);
            this.tb_total.Name = "tb_total";
            this.tb_total.ReadOnly = true;
            this.tb_total.Size = new System.Drawing.Size(70, 26);
            this.tb_total.TabIndex = 41;
            this.tb_total.Text = "0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(785, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Desconto:";
            // 
            // num_desconto
            // 
            this.num_desconto.Location = new System.Drawing.Point(873, 376);
            this.num_desconto.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_desconto.Name = "num_desconto";
            this.num_desconto.Size = new System.Drawing.Size(47, 20);
            this.num_desconto.TabIndex = 43;
            this.num_desconto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_desconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_desconto_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(920, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "%";
            // 
            // tb_IDItensVenda
            // 
            this.tb_IDItensVenda.Location = new System.Drawing.Point(843, 340);
            this.tb_IDItensVenda.Name = "tb_IDItensVenda";
            this.tb_IDItensVenda.ReadOnly = true;
            this.tb_IDItensVenda.Size = new System.Drawing.Size(100, 20);
            this.tb_IDItensVenda.TabIndex = 45;
            this.tb_IDItensVenda.Visible = false;
            // 
            // tb_codCliente
            // 
            this.tb_codCliente.Location = new System.Drawing.Point(58, 82);
            this.tb_codCliente.Name = "tb_codCliente";
            this.tb_codCliente.Size = new System.Drawing.Size(68, 20);
            this.tb_codCliente.TabIndex = 1;
            this.tb_codCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codCliente_KeyPress_1);
            // 
            // tb_codPeca
            // 
            this.tb_codPeca.Location = new System.Drawing.Point(58, 139);
            this.tb_codPeca.Name = "tb_codPeca";
            this.tb_codPeca.Size = new System.Drawing.Size(68, 20);
            this.tb_codPeca.TabIndex = 2;
            this.tb_codPeca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codPeca_KeyPress);
            // 
            // tb_Cliente
            // 
            this.tb_Cliente.Location = new System.Drawing.Point(132, 83);
            this.tb_Cliente.Name = "tb_Cliente";
            this.tb_Cliente.ReadOnly = true;
            this.tb_Cliente.Size = new System.Drawing.Size(353, 20);
            this.tb_Cliente.TabIndex = 14;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tb_IDItensVenda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.num_desconto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_CondVendedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_IDVenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.num_quantidadePecas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_quantidadePecaEstoque);
            this.Controls.Add(this.tb_codCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_PesquisarCliente);
            this.Controls.Add(this.bt_ConsultaPeca);
            this.Controls.Add(this.bt_Concluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_descricaoPeca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_codPeca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Cliente);
            this.Controls.Add(this.dtg_Venda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Titulo_Form_pecas);
            this.Controls.Add(this.dtgw_auxiliarCliente);
            this.Controls.Add(this.dtgw_auxiliarPecas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVenda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Venda";
            this.Load += new System.EventHandler(this.Form_Venda_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_auxiliarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantidadePecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_auxiliarPecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_desconto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo_Form_pecas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_Atualiza;
        private System.Windows.Forms.Button bt_Deleta;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.DataGridView dtg_Venda;
        private AutoPeçasUI.MyTextBox tb_Cliente;
        private System.Windows.Forms.Label label1;
        private AutoPeçasUI.MyTextBox tb_codPeca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_descricaoPeca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Concluir;
        private System.Windows.Forms.Button bt_ConsultaPeca;
        private System.Windows.Forms.Button bt_PesquisarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgw_auxiliarCliente;
        private AutoPeçasUI.MyTextBox tb_codCliente;
        private System.Windows.Forms.TextBox tb_quantidadePecaEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_quantidadePecas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgw_auxiliarPecas;
        private System.Windows.Forms.TextBox tb_IDVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_CondVendedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown num_desconto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_IDItensVenda;
    }
}