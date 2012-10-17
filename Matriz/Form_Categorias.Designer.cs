namespace Matriz
{
    partial class Form_Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Categorias));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_filtrar = new System.Windows.Forms.Button();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.Bt_busca1 = new System.Windows.Forms.Button();
            this.bt_Atualiza = new System.Windows.Forms.Button();
            this.bt_Deleta = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.dtg_Categorias = new System.Windows.Forms.DataGridView();
            this.Titulo_Form_pecas = new System.Windows.Forms.Label();
            this.NomedoProduto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_IDCategoria = new System.Windows.Forms.TextBox();
            this.lb_Codigo = new System.Windows.Forms.Label();
            this.ckb_filtrar = new System.Windows.Forms.CheckBox();
            this.tb_NomeCategoria = new AutoPeçasUI.MyTextBox();
            this.tb_DescriCatg = new AutoPeçasUI.MyTextBox();
            this.tb_filtrar = new AutoPeçasUI.MyTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_filtrar);
            this.panel1.Controls.Add(this.bt_Sair);
            this.panel1.Controls.Add(this.Bt_busca1);
            this.panel1.Controls.Add(this.bt_Atualiza);
            this.panel1.Controls.Add(this.bt_Deleta);
            this.panel1.Controls.Add(this.bt_gravar);
            this.panel1.Location = new System.Drawing.Point(520, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 73);
            this.panel1.TabIndex = 3;
            // 
            // bt_filtrar
            // 
            this.bt_filtrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_filtrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_filtrar.BackgroundImage")));
            this.bt_filtrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_filtrar.Enabled = false;
            this.bt_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_filtrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_filtrar.Location = new System.Drawing.Point(196, 16);
            this.bt_filtrar.Name = "bt_filtrar";
            this.bt_filtrar.Size = new System.Drawing.Size(45, 44);
            this.bt_filtrar.TabIndex = 23;
            this.bt_filtrar.UseVisualStyleBackColor = false;
            this.bt_filtrar.Click += new System.EventHandler(this.bt_filtrar_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Sair.BackgroundImage = global::Matriz.Properties.Resources.Log_Out_icon;
            this.bt_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.Location = new System.Drawing.Point(286, 17);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(45, 44);
            this.bt_Sair.TabIndex = 0;
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // Bt_busca1
            // 
            this.Bt_busca1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_busca1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_busca1.BackgroundImage")));
            this.Bt_busca1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_busca1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Bt_busca1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Bt_busca1.Location = new System.Drawing.Point(149, 15);
            this.Bt_busca1.Name = "Bt_busca1";
            this.Bt_busca1.Size = new System.Drawing.Size(47, 44);
            this.Bt_busca1.TabIndex = 22;
            this.Bt_busca1.UseVisualStyleBackColor = false;
            this.Bt_busca1.Click += new System.EventHandler(this.Bt_busca1_Click);
            // 
            // bt_Atualiza
            // 
            this.bt_Atualiza.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Atualiza.BackgroundImage = global::Matriz.Properties.Resources._8437_128x128;
            this.bt_Atualiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Atualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Atualiza.Location = new System.Drawing.Point(56, 15);
            this.bt_Atualiza.Name = "bt_Atualiza";
            this.bt_Atualiza.Size = new System.Drawing.Size(47, 44);
            this.bt_Atualiza.TabIndex = 2;
            this.bt_Atualiza.UseVisualStyleBackColor = false;
            this.bt_Atualiza.Click += new System.EventHandler(this.bt_Atualiza_Click);
            // 
            // bt_Deleta
            // 
            this.bt_Deleta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Deleta.BackgroundImage = global::Matriz.Properties.Resources.Trash;
            this.bt_Deleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Deleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Deleta.Location = new System.Drawing.Point(103, 15);
            this.bt_Deleta.Name = "bt_Deleta";
            this.bt_Deleta.Size = new System.Drawing.Size(47, 44);
            this.bt_Deleta.TabIndex = 3;
            this.bt_Deleta.UseVisualStyleBackColor = false;
            this.bt_Deleta.Click += new System.EventHandler(this.bt_Deleta_Click);
            // 
            // bt_gravar
            // 
            this.bt_gravar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_gravar.BackgroundImage = global::Matriz.Properties.Resources.Add;
            this.bt_gravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gravar.Location = new System.Drawing.Point(9, 15);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(47, 44);
            this.bt_gravar.TabIndex = 1;
            this.bt_gravar.UseVisualStyleBackColor = false;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // dtg_Categorias
            // 
            this.dtg_Categorias.AllowUserToOrderColumns = true;
            this.dtg_Categorias.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtg_Categorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Categorias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_Categorias.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtg_Categorias.Location = new System.Drawing.Point(0, 183);
            this.dtg_Categorias.Name = "dtg_Categorias";
            this.dtg_Categorias.Size = new System.Drawing.Size(907, 352);
            this.dtg_Categorias.TabIndex = 4;
            // 
            // Titulo_Form_pecas
            // 
            this.Titulo_Form_pecas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo_Form_pecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo_Form_pecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Form_pecas.Location = new System.Drawing.Point(0, 0);
            this.Titulo_Form_pecas.Name = "Titulo_Form_pecas";
            this.Titulo_Form_pecas.Size = new System.Drawing.Size(907, 51);
            this.Titulo_Form_pecas.TabIndex = 6;
            this.Titulo_Form_pecas.Text = "Cadastrar Categorias";
            // 
            // NomedoProduto
            // 
            this.NomedoProduto.AutoSize = true;
            this.NomedoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomedoProduto.Location = new System.Drawing.Point(13, 54);
            this.NomedoProduto.Name = "NomedoProduto";
            this.NomedoProduto.Size = new System.Drawing.Size(82, 20);
            this.NomedoProduto.TabIndex = 15;
            this.NomedoProduto.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descrição:";
            // 
            // tb_IDCategoria
            // 
            this.tb_IDCategoria.Location = new System.Drawing.Point(354, 55);
            this.tb_IDCategoria.Name = "tb_IDCategoria";
            this.tb_IDCategoria.Size = new System.Drawing.Size(44, 20);
            this.tb_IDCategoria.TabIndex = 20;
            this.tb_IDCategoria.Visible = false;
            // 
            // lb_Codigo
            // 
            this.lb_Codigo.AutoSize = true;
            this.lb_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Codigo.Location = new System.Drawing.Point(293, 54);
            this.lb_Codigo.Name = "lb_Codigo";
            this.lb_Codigo.Size = new System.Drawing.Size(63, 20);
            this.lb_Codigo.TabIndex = 21;
            this.lb_Codigo.Text = "Código:";
            this.lb_Codigo.Visible = false;
            // 
            // ckb_filtrar
            // 
            this.ckb_filtrar.AutoSize = true;
            this.ckb_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_filtrar.Location = new System.Drawing.Point(399, 87);
            this.ckb_filtrar.Name = "ckb_filtrar";
            this.ckb_filtrar.Size = new System.Drawing.Size(68, 24);
            this.ckb_filtrar.TabIndex = 22;
            this.ckb_filtrar.Text = "Filtrar";
            this.ckb_filtrar.UseVisualStyleBackColor = true;
            this.ckb_filtrar.CheckedChanged += new System.EventHandler(this.ckb_filtrar_CheckedChanged);
            // 
            // tb_NomeCategoria
            // 
            this.tb_NomeCategoria.Location = new System.Drawing.Point(96, 56);
            this.tb_NomeCategoria.Name = "tb_NomeCategoria";
            this.tb_NomeCategoria.Size = new System.Drawing.Size(169, 20);
            this.tb_NomeCategoria.TabIndex = 25;
            // 
            // tb_DescriCatg
            // 
            this.tb_DescriCatg.Location = new System.Drawing.Point(96, 91);
            this.tb_DescriCatg.Multiline = true;
            this.tb_DescriCatg.Name = "tb_DescriCatg";
            this.tb_DescriCatg.Size = new System.Drawing.Size(268, 71);
            this.tb_DescriCatg.TabIndex = 24;
            // 
            // tb_filtrar
            // 
            this.tb_filtrar.Location = new System.Drawing.Point(399, 117);
            this.tb_filtrar.Name = "tb_filtrar";
            this.tb_filtrar.Size = new System.Drawing.Size(119, 20);
            this.tb_filtrar.TabIndex = 23;
            this.tb_filtrar.Visible = false;
            // 
            // Form_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(907, 535);
            this.ControlBox = false;
            this.Controls.Add(this.tb_NomeCategoria);
            this.Controls.Add(this.tb_DescriCatg);
            this.Controls.Add(this.tb_filtrar);
            this.Controls.Add(this.ckb_filtrar);
            this.Controls.Add(this.tb_IDCategoria);
            this.Controls.Add(this.lb_Codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomedoProduto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtg_Categorias);
            this.Controls.Add(this.Titulo_Form_pecas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Categorias";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Categorias_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Categorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_Atualiza;
        private System.Windows.Forms.Button bt_Deleta;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.DataGridView dtg_Categorias;
        private System.Windows.Forms.Label Titulo_Form_pecas;
        private System.Windows.Forms.Label NomedoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_IDCategoria;
        private System.Windows.Forms.Label lb_Codigo;
        private System.Windows.Forms.Button bt_filtrar;
        private System.Windows.Forms.Button Bt_busca1;
        private System.Windows.Forms.CheckBox ckb_filtrar;
        private AutoPeçasUI.MyTextBox tb_filtrar;
        private AutoPeçasUI.MyTextBox tb_DescriCatg;
        private AutoPeçasUI.MyTextBox tb_NomeCategoria;
    }
}