namespace Matriz
{
    partial class Form_Venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Venda));
            this.Titulo_Form_pecas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_filtrar = new System.Windows.Forms.Button();
            this.Bt_busca1 = new System.Windows.Forms.Button();
            this.bt_Atualiza = new System.Windows.Forms.Button();
            this.bt_Deleta = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.dtg_Venda = new System.Windows.Forms.DataGridView();
            this.dtg_col_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_col_DescricaoPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_col_PrecoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_col_Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_col_subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Concluir = new System.Windows.Forms.Button();
            this.bt_ConsultaPeca = new System.Windows.Forms.Button();
            this.bt_PesquisarCliente = new System.Windows.Forms.Button();
            this.myTextBox2 = new AutoPeçasUI.MyTextBox();
            this.tb_Cliente = new AutoPeçasUI.MyTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Venda)).BeginInit();
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
            this.panel1.Controls.Add(this.bt_filtrar);
            this.panel1.Controls.Add(this.Bt_busca1);
            this.panel1.Controls.Add(this.bt_Atualiza);
            this.panel1.Controls.Add(this.bt_Deleta);
            this.panel1.Controls.Add(this.bt_gravar);
            this.panel1.Location = new System.Drawing.Point(624, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 73);
            this.panel1.TabIndex = 12;
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Sair.BackgroundImage")));
            this.bt_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_Sair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Sair.Location = new System.Drawing.Point(273, 17);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(47, 44);
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
            this.bt_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_filtrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_filtrar.Location = new System.Drawing.Point(202, 18);
            this.bt_filtrar.Name = "bt_filtrar";
            this.bt_filtrar.Size = new System.Drawing.Size(47, 44);
            this.bt_filtrar.TabIndex = 10;
            this.bt_filtrar.UseVisualStyleBackColor = false;
            // 
            // Bt_busca1
            // 
            this.Bt_busca1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_busca1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_busca1.BackgroundImage")));
            this.Bt_busca1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_busca1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Bt_busca1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Bt_busca1.Location = new System.Drawing.Point(155, 18);
            this.Bt_busca1.Name = "Bt_busca1";
            this.Bt_busca1.Size = new System.Drawing.Size(47, 44);
            this.Bt_busca1.TabIndex = 6;
            this.Bt_busca1.UseVisualStyleBackColor = false;
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
            this.bt_gravar.TabIndex = 9;
            this.bt_gravar.UseVisualStyleBackColor = false;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // dtg_Venda
            // 
            this.dtg_Venda.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtg_Venda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtg_col_Item,
            this.dtg_col_DescricaoPeca,
            this.dtg_col_PrecoUnit,
            this.dtg_col_Quant,
            this.dtg_col_subtotal});
            this.dtg_Venda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_Venda.Location = new System.Drawing.Point(0, 239);
            this.dtg_Venda.Name = "dtg_Venda";
            this.dtg_Venda.Size = new System.Drawing.Size(959, 211);
            this.dtg_Venda.TabIndex = 13;
            // 
            // dtg_col_Item
            // 
            this.dtg_col_Item.HeaderText = "Item";
            this.dtg_col_Item.Name = "dtg_col_Item";
            this.dtg_col_Item.ReadOnly = true;
            // 
            // dtg_col_DescricaoPeca
            // 
            this.dtg_col_DescricaoPeca.HeaderText = "Peca";
            this.dtg_col_DescricaoPeca.Name = "dtg_col_DescricaoPeca";
            this.dtg_col_DescricaoPeca.ReadOnly = true;
            // 
            // dtg_col_PrecoUnit
            // 
            this.dtg_col_PrecoUnit.HeaderText = "Preço Unitario";
            this.dtg_col_PrecoUnit.Name = "dtg_col_PrecoUnit";
            this.dtg_col_PrecoUnit.ReadOnly = true;
            // 
            // dtg_col_Quant
            // 
            this.dtg_col_Quant.HeaderText = "Quant";
            this.dtg_col_Quant.Name = "dtg_col_Quant";
            this.dtg_col_Quant.ReadOnly = true;
            // 
            // dtg_col_subtotal
            // 
            this.dtg_col_subtotal.HeaderText = "Subtotal";
            this.dtg_col_subtotal.Name = "dtg_col_subtotal";
            this.dtg_col_subtotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código Peça:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descrição:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 46);
            this.textBox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 79);
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
            this.bt_Concluir.Location = new System.Drawing.Point(897, 180);
            this.bt_Concluir.Name = "bt_Concluir";
            this.bt_Concluir.Size = new System.Drawing.Size(47, 44);
            this.bt_Concluir.TabIndex = 21;
            this.bt_Concluir.UseVisualStyleBackColor = false;
            // 
            // bt_ConsultaPeca
            // 
            this.bt_ConsultaPeca.Location = new System.Drawing.Point(168, 127);
            this.bt_ConsultaPeca.Name = "bt_ConsultaPeca";
            this.bt_ConsultaPeca.Size = new System.Drawing.Size(28, 23);
            this.bt_ConsultaPeca.TabIndex = 22;
            this.bt_ConsultaPeca.Text = "...";
            this.bt_ConsultaPeca.UseVisualStyleBackColor = true;
            this.bt_ConsultaPeca.Click += new System.EventHandler(this.bt_ConsultaPeca_Click);
            // 
            // bt_PesquisarCliente
            // 
            this.bt_PesquisarCliente.Location = new System.Drawing.Point(566, 79);
            this.bt_PesquisarCliente.Name = "bt_PesquisarCliente";
            this.bt_PesquisarCliente.Size = new System.Drawing.Size(28, 23);
            this.bt_PesquisarCliente.TabIndex = 23;
            this.bt_PesquisarCliente.Text = "...";
            this.bt_PesquisarCliente.UseVisualStyleBackColor = true;
            this.bt_PesquisarCliente.Click += new System.EventHandler(this.bt_PesquisarCliente_Click);
            // 
            // myTextBox2
            // 
            this.myTextBox2.Location = new System.Drawing.Point(116, 127);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Size = new System.Drawing.Size(46, 20);
            this.myTextBox2.TabIndex = 16;
            // 
            // tb_Cliente
            // 
            this.tb_Cliente.Location = new System.Drawing.Point(168, 79);
            this.tb_Cliente.Name = "tb_Cliente";
            this.tb_Cliente.Size = new System.Drawing.Size(384, 20);
            this.tb_Cliente.TabIndex = 14;
            this.tb_Cliente.TextChanged += new System.EventHandler(this.tb_Cliente_TextChanged);
            // 
            // Form_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bt_PesquisarCliente);
            this.Controls.Add(this.bt_ConsultaPeca);
            this.Controls.Add(this.bt_Concluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Cliente);
            this.Controls.Add(this.dtg_Venda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Titulo_Form_pecas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Venda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Venda";
            this.Load += new System.EventHandler(this.Form_Venda_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Venda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo_Form_pecas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_filtrar;
        private System.Windows.Forms.Button Bt_busca1;
        private System.Windows.Forms.Button bt_Atualiza;
        private System.Windows.Forms.Button bt_Deleta;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.DataGridView dtg_Venda;
        private AutoPeçasUI.MyTextBox tb_Cliente;
        private System.Windows.Forms.Label label1;
        private AutoPeçasUI.MyTextBox myTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Concluir;
        private System.Windows.Forms.Button bt_ConsultaPeca;
        private System.Windows.Forms.Button bt_PesquisarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_col_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_col_DescricaoPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_col_PrecoUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_col_Quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_col_subtotal;
    }
}