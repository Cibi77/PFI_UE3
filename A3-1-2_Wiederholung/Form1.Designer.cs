namespace A3_1_2_Wiederholung
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
            this.NumNumber = new System.Windows.Forms.NumericUpDown();
            this.TxtMonth = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // LblChoose
            // 
            this.LblChoose.AutoSize = true;
            this.LblChoose.Location = new System.Drawing.Point(27, 72);
            this.LblChoose.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblChoose.Name = "LblChoose";
            this.LblChoose.Size = new System.Drawing.Size(329, 37);
            this.LblChoose.TabIndex = 0;
            this.LblChoose.Text = "Wählen Sie eine Zahl:";
            // 
            // NumNumber
            // 
            this.NumNumber.Location = new System.Drawing.Point(405, 72);
            this.NumNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NumNumber.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumNumber.Name = "NumNumber";
            this.NumNumber.Size = new System.Drawing.Size(253, 44);
            this.NumNumber.TabIndex = 1;
            this.NumNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumNumber.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // TxtMonth
            // 
            this.TxtMonth.BackColor = System.Drawing.Color.Black;
            this.TxtMonth.ForeColor = System.Drawing.Color.White;
            this.TxtMonth.Location = new System.Drawing.Point(34, 208);
            this.TxtMonth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtMonth.Name = "TxtMonth";
            this.TxtMonth.Size = new System.Drawing.Size(207, 44);
            this.TxtMonth.TabIndex = 2;
            this.TxtMonth.Text = "Januar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 341);
            this.Controls.Add(this.TxtMonth);
            this.Controls.Add(this.NumNumber);
            this.Controls.Add(this.LblChoose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblChoose;
        private System.Windows.Forms.NumericUpDown NumNumber;
        private System.Windows.Forms.TextBox TxtMonth;
    }
}

