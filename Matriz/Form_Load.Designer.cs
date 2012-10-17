namespace Matriz
{
    partial class Form_Load
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
            this.lb_prgrssbar = new System.Windows.Forms.Label();
            this.progessbar_Inicial = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb_prgrssbar
            // 
            this.lb_prgrssbar.BackColor = System.Drawing.Color.Transparent;
            this.lb_prgrssbar.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prgrssbar.ForeColor = System.Drawing.Color.Black;
            this.lb_prgrssbar.Location = new System.Drawing.Point(6, 5);
            this.lb_prgrssbar.Name = "lb_prgrssbar";
            this.lb_prgrssbar.Size = new System.Drawing.Size(435, 34);
            this.lb_prgrssbar.TabIndex = 11;
            this.lb_prgrssbar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // progessbar_Inicial
            // 
            this.progessbar_Inicial.BackColor = System.Drawing.SystemColors.Control;
            this.progessbar_Inicial.ForeColor = System.Drawing.Color.Blue;
            this.progessbar_Inicial.Location = new System.Drawing.Point(20, 50);
            this.progessbar_Inicial.MarqueeAnimationSpeed = 500;
            this.progessbar_Inicial.Maximum = 50;
            this.progessbar_Inicial.Name = "progessbar_Inicial";
            this.progessbar_Inicial.Size = new System.Drawing.Size(389, 10);
            this.progessbar_Inicial.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progessbar_Inicial.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(428, 68);
            this.ControlBox = false;
            this.Controls.Add(this.progessbar_Inicial);
            this.Controls.Add(this.lb_prgrssbar);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_prgrssbar;
        private System.Windows.Forms.ProgressBar progessbar_Inicial;
        private System.Windows.Forms.Timer timer1;
    }
}