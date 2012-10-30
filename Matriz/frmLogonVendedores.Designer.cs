namespace Matriz
{
    partial class frmLogonVendedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.pn_AlterarSenha = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtg_Auxiliar = new System.Windows.Forms.DataGridView();
            this.tb_confirmarSEnha = new AutoPeçasUI.MyTextBox();
            this.tb_Novasenha = new AutoPeçasUI.MyTextBox();
            this.tb_senha = new AutoPeçasUI.MyTextBox();
            this.tb_login = new AutoPeçasUI.MyTextBox();
            this.pn_AlterarSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Auxiliar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(195, 170);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueci minha senha";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pn_AlterarSenha
            // 
            this.pn_AlterarSenha.Controls.Add(this.button4);
            this.pn_AlterarSenha.Controls.Add(this.button3);
            this.pn_AlterarSenha.Controls.Add(this.label4);
            this.pn_AlterarSenha.Controls.Add(this.tb_confirmarSEnha);
            this.pn_AlterarSenha.Controls.Add(this.label3);
            this.pn_AlterarSenha.Controls.Add(this.tb_Novasenha);
            this.pn_AlterarSenha.Location = new System.Drawing.Point(13, 66);
            this.pn_AlterarSenha.Name = "pn_AlterarSenha";
            this.pn_AlterarSenha.Size = new System.Drawing.Size(291, 119);
            this.pn_AlterarSenha.TabIndex = 7;
            this.pn_AlterarSenha.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nova senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirmar nova senha:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(198, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtg_Auxiliar
            // 
            this.dtg_Auxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Auxiliar.Location = new System.Drawing.Point(141, 321);
            this.dtg_Auxiliar.Name = "dtg_Auxiliar";
            this.dtg_Auxiliar.Size = new System.Drawing.Size(64, 35);
            this.dtg_Auxiliar.TabIndex = 8;
            // 
            // tb_confirmarSEnha
            // 
            this.tb_confirmarSEnha.Location = new System.Drawing.Point(17, 64);
            this.tb_confirmarSEnha.Name = "tb_confirmarSEnha";
            this.tb_confirmarSEnha.Size = new System.Drawing.Size(174, 20);
            this.tb_confirmarSEnha.TabIndex = 9;
            // 
            // tb_Novasenha
            // 
            this.tb_Novasenha.Location = new System.Drawing.Point(17, 21);
            this.tb_Novasenha.Name = "tb_Novasenha";
            this.tb_Novasenha.Size = new System.Drawing.Size(174, 20);
            this.tb_Novasenha.TabIndex = 1;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(30, 85);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(174, 20);
            this.tb_senha.TabIndex = 1;
            this.tb_senha.UseSystemPasswordChar = true;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(30, 38);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(174, 20);
            this.tb_login.TabIndex = 0;
            // 
            // frmLogonVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 194);
            this.Controls.Add(this.dtg_Auxiliar);
            this.Controls.Add(this.pn_AlterarSenha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogonVendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logon ";
            this.pn_AlterarSenha.ResumeLayout(false);
            this.pn_AlterarSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Auxiliar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoPeçasUI.MyTextBox tb_login;
        private AutoPeçasUI.MyTextBox tb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pn_AlterarSenha;
        private System.Windows.Forms.Label label4;
        private AutoPeçasUI.MyTextBox tb_confirmarSEnha;
        private System.Windows.Forms.Label label3;
        private AutoPeçasUI.MyTextBox tb_Novasenha;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtg_Auxiliar;
    }
}