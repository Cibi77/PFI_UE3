namespace Test_enum
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
            this.LblWeekday = new System.Windows.Forms.Label();
            this.NumDay = new System.Windows.Forms.NumericUpDown();
            this.LblDayName = new System.Windows.Forms.Label();
            this.TxtDayName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumDay)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWeekday
            // 
            this.LblWeekday.AutoSize = true;
            this.LblWeekday.Location = new System.Drawing.Point(36, 50);
            this.LblWeekday.Name = "LblWeekday";
            this.LblWeekday.Size = new System.Drawing.Size(184, 20);
            this.LblWeekday.TabIndex = 0;
            this.LblWeekday.Text = "Wochentag in Nummern:";
            // 
            // NumDay
            // 
            this.NumDay.Location = new System.Drawing.Point(272, 48);
            this.NumDay.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumDay.Name = "NumDay";
            this.NumDay.Size = new System.Drawing.Size(61, 26);
            this.NumDay.TabIndex = 1;
            this.NumDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumDay.ValueChanged += new System.EventHandler(this.NumDay_ValueChanged);
            // 
            // LblDayName
            // 
            this.LblDayName.AutoSize = true;
            this.LblDayName.Location = new System.Drawing.Point(40, 194);
            this.LblDayName.Name = "LblDayName";
            this.LblDayName.Size = new System.Drawing.Size(86, 20);
            this.LblDayName.TabIndex = 2;
            this.LblDayName.Text = "Tag Name:";
            // 
            // TxtDayName
            // 
            this.TxtDayName.Location = new System.Drawing.Point(174, 187);
            this.TxtDayName.Name = "TxtDayName";
            this.TxtDayName.ReadOnly = true;
            this.TxtDayName.Size = new System.Drawing.Size(159, 26);
            this.TxtDayName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 344);
            this.Controls.Add(this.TxtDayName);
            this.Controls.Add(this.LblDayName);
            this.Controls.Add(this.NumDay);
            this.Controls.Add(this.LblWeekday);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblWeekday;
        private System.Windows.Forms.NumericUpDown NumDay;
        private System.Windows.Forms.Label LblDayName;
        private System.Windows.Forms.TextBox TxtDayName;
    }
}

