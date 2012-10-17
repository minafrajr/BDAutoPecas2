namespace Matriz
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AUTOPECASDataSet = new Matriz.AUTOPECASDataSet();
            this.PecasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PecasTableAdapter = new Matriz.AUTOPECASDataSetTableAdapters.PecasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AUTOPECASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PecasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PecasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Matriz.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(664, 374);
            this.reportViewer1.TabIndex = 0;
            // 
            // AUTOPECASDataSet
            // 
            this.AUTOPECASDataSet.DataSetName = "AUTOPECASDataSet";
            this.AUTOPECASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PecasBindingSource
            // 
            this.PecasBindingSource.DataMember = "Pecas";
            this.PecasBindingSource.DataSource = this.AUTOPECASDataSet;
            // 
            // PecasTableAdapter
            // 
            this.PecasTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 406);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AUTOPECASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PecasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PecasBindingSource;
        private AUTOPECASDataSet AUTOPECASDataSet;
        private AUTOPECASDataSetTableAdapters.PecasTableAdapter PecasTableAdapter;
    }
}