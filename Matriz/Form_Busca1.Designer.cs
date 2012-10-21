namespace Matriz
{
    partial class Form_Pecas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pecas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Titulo_Form_pecas = new System.Windows.Forms.Label();
            this.NomedoProduto = new System.Windows.Forms.Label();
            this.Bt_busca1 = new System.Windows.Forms.Button();
            this.bt_Atualiza = new System.Windows.Forms.Button();
            this.dtg_Produtos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_codigofornecedor_peças = new System.Windows.Forms.ComboBox();
            this.fORNECEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTOPECASDataSet11 = new Matriz.AUTOPECASDataSet1();
            this.autopecasDataSet1 = new Matriz.AUTOPECASDataSet();
            this.binsourcePecas = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.bt_Deleta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_filtrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pecasTableAdapter = new Matriz.AUTOPECASDataSetTableAdapters.PecasTableAdapter();
            this.cmb_IDVeiculo = new System.Windows.Forms.ComboBox();
            this.veiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new Matriz.AUTOPECASDataSetTableAdapters.CategoriasTableAdapter();
            this.tableAdapterManager = new Matriz.AUTOPECASDataSetTableAdapters.TableAdapterManager();
            this.idCategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckb_Filtrar = new System.Windows.Forms.CheckBox();
            this.textBox1 = new AutoPeçasUI.MyTextBox();
            this.tb_IDpeca = new AutoPeçasUI.MyTextBox();
            this.tb_nomepeca = new AutoPeçasUI.MyTextBox();
            this.veiculosTableAdapter = new Matriz.AUTOPECASDataSetTableAdapters.VeiculosTableAdapter();
            this.fORNECEDORESTableAdapter = new Matriz.AUTOPECASDataSet1TableAdapters.FORNECEDORESTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskt_preco = new Matriz.Msktextbox();
            this.mskt_quantidade = new Matriz.Msktextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOPECASDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopecasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binsourcePecas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo_Form_pecas
            // 
            resources.ApplyResources(this.Titulo_Form_pecas, "Titulo_Form_pecas");
            this.Titulo_Form_pecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo_Form_pecas.Name = "Titulo_Form_pecas";
            // 
            // NomedoProduto
            // 
            resources.ApplyResources(this.NomedoProduto, "NomedoProduto");
            this.NomedoProduto.Name = "NomedoProduto";
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
            // dtg_Produtos
            // 
            this.dtg_Produtos.AllowUserToOrderColumns = true;
            this.dtg_Produtos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtg_Produtos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Produtos.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dtg_Produtos, "dtg_Produtos");
            this.dtg_Produtos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtg_Produtos.Name = "dtg_Produtos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Produtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_Produtos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtg_Produtos_CellMouseClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmb_codigofornecedor_peças
            // 
            this.cmb_codigofornecedor_peças.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmb_codigofornecedor_peças.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_codigofornecedor_peças.DataSource = this.fORNECEDORESBindingSource;
            this.cmb_codigofornecedor_peças.DisplayMember = "NOMEFORNECEDOR";
            this.cmb_codigofornecedor_peças.DropDownHeight = 136;
            this.cmb_codigofornecedor_peças.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_codigofornecedor_peças.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_codigofornecedor_peças, "cmb_codigofornecedor_peças");
            this.cmb_codigofornecedor_peças.Name = "cmb_codigofornecedor_peças";
            this.cmb_codigofornecedor_peças.ValueMember = "IDFORNECEDOR";
            // 
            // fORNECEDORESBindingSource
            // 
            this.fORNECEDORESBindingSource.DataMember = "FORNECEDORES";
            this.fORNECEDORESBindingSource.DataSource = this.aUTOPECASDataSet11;
            // 
            // aUTOPECASDataSet11
            // 
            this.aUTOPECASDataSet11.DataSetName = "AUTOPECASDataSet1";
            this.aUTOPECASDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autopecasDataSet1
            // 
            this.autopecasDataSet1.DataSetName = "AUTOPECASDataSet";
            this.autopecasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // binsourcePecas
            // 
            this.binsourcePecas.DataMember = "Pecas";
            this.binsourcePecas.DataSource = this.autopecasDataSet1;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // bt_gravar
            // 
            this.bt_gravar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.bt_gravar, "bt_gravar");
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.UseVisualStyleBackColor = false;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // bt_Deleta
            // 
            this.bt_Deleta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.bt_Deleta, "bt_Deleta");
            this.bt_Deleta.Name = "bt_Deleta";
            this.bt_Deleta.UseVisualStyleBackColor = false;
            this.bt_Deleta.Click += new System.EventHandler(this.bt_Deleta_Click);
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
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // pecasTableAdapter
            // 
            this.pecasTableAdapter.ClearBeforeFill = true;
            // 
            // cmb_IDVeiculo
            // 
            this.cmb_IDVeiculo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_IDVeiculo.DataSource = this.veiculosBindingSource;
            this.cmb_IDVeiculo.DisplayMember = "NomeVeiculo";
            this.cmb_IDVeiculo.DropDownHeight = 200;
            this.cmb_IDVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IDVeiculo.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_IDVeiculo, "cmb_IDVeiculo");
            this.cmb_IDVeiculo.Name = "cmb_IDVeiculo";
            this.cmb_IDVeiculo.ValueMember = "IdVeiculo";
            // 
            // veiculosBindingSource
            // 
            this.veiculosBindingSource.DataMember = "Veiculos";
            this.veiculosBindingSource.DataSource = this.autopecasDataSet1;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.autopecasDataSet1;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = this.categoriasTableAdapter;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.PecasTableAdapter = this.pecasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Matriz.AUTOPECASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VeiculosTableAdapter = null;
            // 
            // idCategoriaComboBox
            // 
            this.idCategoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "IdCategoria", true));
            this.idCategoriaComboBox.DataSource = this.categoriasBindingSource;
            this.idCategoriaComboBox.DisplayMember = "NomeCategoria";
            this.idCategoriaComboBox.DropDownHeight = 136;
            this.idCategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.idCategoriaComboBox, "idCategoriaComboBox");
            this.idCategoriaComboBox.FormattingEnabled = true;
            this.idCategoriaComboBox.Name = "idCategoriaComboBox";
            this.idCategoriaComboBox.ValueMember = "IdCategoria";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // ckb_Filtrar
            // 
            resources.ApplyResources(this.ckb_Filtrar, "ckb_Filtrar");
            this.ckb_Filtrar.Name = "ckb_Filtrar";
            this.ckb_Filtrar.UseVisualStyleBackColor = true;
            this.ckb_Filtrar.CheckedChanged += new System.EventHandler(this.ckb_Filtrar_CheckedChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // tb_IDpeca
            // 
            resources.ApplyResources(this.tb_IDpeca, "tb_IDpeca");
            this.tb_IDpeca.Name = "tb_IDpeca";
            // 
            // tb_nomepeca
            // 
            resources.ApplyResources(this.tb_nomepeca, "tb_nomepeca");
            this.tb_nomepeca.Name = "tb_nomepeca";
            // 
            // veiculosTableAdapter
            // 
            this.veiculosTableAdapter.ClearBeforeFill = true;
            // 
            // fORNECEDORESTableAdapter
            // 
            this.fORNECEDORESTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // mskt_preco
            // 
            resources.ApplyResources(this.mskt_preco, "mskt_preco");
            this.mskt_preco.Name = "mskt_preco";
            // 
            // mskt_quantidade
            // 
            resources.ApplyResources(this.mskt_quantidade, "mskt_quantidade");
            this.mskt_quantidade.Name = "mskt_quantidade";
            // 
            // Form_Pecas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.mskt_quantidade);
            this.Controls.Add(this.mskt_preco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckb_Filtrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_IDpeca);
            this.Controls.Add(this.tb_nomepeca);
            this.Controls.Add(this.idCategoriaComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_IDVeiculo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_codigofornecedor_peças);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_Produtos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NomedoProduto);
            this.Controls.Add(this.Titulo_Form_pecas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Pecas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form_Pecas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOPECASDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopecasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binsourcePecas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo_Form_pecas;
        private System.Windows.Forms.Label NomedoProduto;
        private System.Windows.Forms.Button Bt_busca1;
        private System.Windows.Forms.Button bt_Atualiza;
        private System.Windows.Forms.DataGridView dtg_Produtos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_codigofornecedor_peças;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.Button bt_Deleta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_filtrar;
        private System.Windows.Forms.Button bt_Sair;
        private AUTOPECASDataSet autopecasDataSet1;
        private System.Windows.Forms.BindingSource binsourcePecas;
        private AUTOPECASDataSetTableAdapters.PecasTableAdapter pecasTableAdapter;
        private System.Windows.Forms.ComboBox cmb_IDVeiculo;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private AUTOPECASDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private AUTOPECASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox idCategoriaComboBox;
        private System.Windows.Forms.Label label6;
        private AutoPeçasUI.MyTextBox tb_nomepeca;
        private AutoPeçasUI.MyTextBox tb_IDpeca;
        private AutoPeçasUI.MyTextBox textBox1;
        private System.Windows.Forms.CheckBox ckb_Filtrar;
        private AUTOPECASDataSetTableAdapters.VeiculosTableAdapter veiculosTableAdapter;
        private System.Windows.Forms.BindingSource veiculosBindingSource;
        private AUTOPECASDataSet1 aUTOPECASDataSet11;
        private System.Windows.Forms.BindingSource fORNECEDORESBindingSource;
        private AUTOPECASDataSet1TableAdapters.FORNECEDORESTableAdapter fORNECEDORESTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Msktextbox mskt_preco;
        private Msktextbox mskt_quantidade;
    }
}