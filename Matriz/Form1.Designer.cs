namespace Matriz
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cOMPRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bUSCAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTAGEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRAVARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.padrãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfEstoque = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Imagem_Inicial = new System.Windows.Forms.PictureBox();
            this.DataHora = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem_Inicial)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPRAToolStripMenuItem,
            this.vENDAToolStripMenuItem,
            this.bUSCAToolStripMenuItem,
            this.lISTAGEMToolStripMenuItem,
            this.gRAVARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cOMPRAToolStripMenuItem
            // 
            this.cOMPRAToolStripMenuItem.Name = "cOMPRAToolStripMenuItem";
            this.cOMPRAToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.cOMPRAToolStripMenuItem.Text = "Compra";
            // 
            // vENDAToolStripMenuItem
            // 
            this.vENDAToolStripMenuItem.Name = "vENDAToolStripMenuItem";
            this.vENDAToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.vENDAToolStripMenuItem.Text = "Venda";
            // 
            // bUSCAToolStripMenuItem
            // 
            this.bUSCAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.códigoToolStripMenuItem1,
            this.nomeToolStripMenuItem1});
            this.bUSCAToolStripMenuItem.Name = "bUSCAToolStripMenuItem";
            this.bUSCAToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.bUSCAToolStripMenuItem.Text = "Busca";
            // 
            // códigoToolStripMenuItem1
            // 
            this.códigoToolStripMenuItem1.Name = "códigoToolStripMenuItem1";
            this.códigoToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.códigoToolStripMenuItem1.Text = "Código";
            this.códigoToolStripMenuItem1.Click += new System.EventHandler(this.códigoToolStripMenuItem1_Click);
            // 
            // nomeToolStripMenuItem1
            // 
            this.nomeToolStripMenuItem1.Name = "nomeToolStripMenuItem1";
            this.nomeToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.nomeToolStripMenuItem1.Text = "Nome";
            // 
            // lISTAGEMToolStripMenuItem
            // 
            this.lISTAGEMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.códigoToolStripMenuItem,
            this.nomeToolStripMenuItem,
            this.quantidadeToolStripMenuItem,
            this.preçoToolStripMenuItem});
            this.lISTAGEMToolStripMenuItem.Name = "lISTAGEMToolStripMenuItem";
            this.lISTAGEMToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.lISTAGEMToolStripMenuItem.Text = "Listagem";
            // 
            // códigoToolStripMenuItem
            // 
            this.códigoToolStripMenuItem.Name = "códigoToolStripMenuItem";
            this.códigoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.códigoToolStripMenuItem.Text = "Código";
            // 
            // nomeToolStripMenuItem
            // 
            this.nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            this.nomeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.nomeToolStripMenuItem.Text = "Nome";
            // 
            // quantidadeToolStripMenuItem
            // 
            this.quantidadeToolStripMenuItem.Name = "quantidadeToolStripMenuItem";
            this.quantidadeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.quantidadeToolStripMenuItem.Text = "Quantidade";
            // 
            // preçoToolStripMenuItem
            // 
            this.preçoToolStripMenuItem.Name = "preçoToolStripMenuItem";
            this.preçoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.preçoToolStripMenuItem.Text = "Preço";
            // 
            // gRAVARToolStripMenuItem
            // 
            this.gRAVARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.padrãoToolStripMenuItem});
            this.gRAVARToolStripMenuItem.Name = "gRAVARToolStripMenuItem";
            this.gRAVARToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.gRAVARToolStripMenuItem.Text = "Gravar";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.novoToolStripMenuItem.Text = "Novo...";
            // 
            // padrãoToolStripMenuItem
            // 
            this.padrãoToolStripMenuItem.Name = "padrãoToolStripMenuItem";
            this.padrãoToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.padrãoToolStripMenuItem.Text = "Padrão";
            this.padrãoToolStripMenuItem.Click += new System.EventHandler(this.padrãoToolStripMenuItem_Click);
            // 
            // InfEstoque
            // 
            this.InfEstoque.BackColor = System.Drawing.Color.Transparent;
            this.InfEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InfEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfEstoque.Location = new System.Drawing.Point(184, 162);
            this.InfEstoque.Name = "InfEstoque";
            this.InfEstoque.Size = new System.Drawing.Size(124, 31);
            this.InfEstoque.TabIndex = 3;
            this.InfEstoque.Text = "Estoque:";
            this.InfEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.CausesValidation = false;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(314, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(295, 324);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(311, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.imotion.com.br/imagens/details.php?image_id=7414";
            // 
            // Imagem_Inicial
            // 
            this.Imagem_Inicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Imagem_Inicial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Imagem_Inicial.Image = ((System.Drawing.Image)(resources.GetObject("Imagem_Inicial.Image")));
            this.Imagem_Inicial.Location = new System.Drawing.Point(32, 74);
            this.Imagem_Inicial.Name = "Imagem_Inicial";
            this.Imagem_Inicial.Size = new System.Drawing.Size(553, 247);
            this.Imagem_Inicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Imagem_Inicial.TabIndex = 6;
            this.Imagem_Inicial.TabStop = false;
            this.Imagem_Inicial.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DataHora
            // 
            this.DataHora.AutoSize = true;
            this.DataHora.Location = new System.Drawing.Point(185, 227);
            this.DataHora.Name = "DataHora";
            this.DataHora.Size = new System.Drawing.Size(0, 13);
            this.DataHora.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 339);
            this.Controls.Add(this.DataHora);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfEstoque);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Imagem_Inicial);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Controle de Auto-Peças";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem_Inicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cOMPRAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bUSCAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lISTAGEMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRAVARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem padrãoToolStripMenuItem;
        private System.Windows.Forms.Label InfEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox Imagem_Inicial;
        private System.Windows.Forms.Label DataHora;

    }
}

