namespace A3_1_2_Enum_Monatsname
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblChoose = new System.Windows.Forms.Label();
            this.NumChoose = new System.Windows.Forms.NumericUpDown();
            this.LblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumChoose)).BeginInit();
            this.SuspendLayout();
            // 
            // LblChoose
            // 
            this.LblChoose.AutoSize = true;
            this.LblChoose.Location = new System.Drawing.Point(28, 89);
            this.LblChoose.Name = "LblChoose";
            this.LblChoose.Size = new System.Drawing.Size(163, 20);
            this.LblChoose.TabIndex = 0;
            this.LblChoose.Text = "Wählen Sie eine Zahl:";
            // 
            // NumChoose
            // 
            this.NumChoose.Location = new System.Drawing.Point(218, 89);
            this.NumChoose.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumChoose.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumChoose.Name = "NumChoose";
            this.NumChoose.Size = new System.Drawing.Size(120, 26);
            this.NumChoose.TabIndex = 1;
            this.NumChoose.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumChoose.ValueChanged += new System.EventHandler(this.NumChoose_ValueChanged);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.BackColor = System.Drawing.Color.Black;
            this.LblResult.ForeColor = System.Drawing.Color.White;
            this.LblResult.Location = new System.Drawing.Point(111, 195);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(145, 20);
            this.LblResult.TabIndex = 2;
            this.LblResult.Text = "                                  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 342);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.NumChoose);
            this.Controls.Add(this.LblChoose);
            this.Name = "Form1";
            this.Text = "Aufgabe_A3-1-2";
            ((System.ComponentModel.ISupportInitialize)(this.NumChoose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblChoose;
        private System.Windows.Forms.NumericUpDown NumChoose;
        private System.Windows.Forms.Label LblResult;
    }
}

