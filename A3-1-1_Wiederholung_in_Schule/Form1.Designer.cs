namespace A3_1_1_Wiederholung
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
            this.CmdMonday = new System.Windows.Forms.Button();
            this.CmdTuesday = new System.Windows.Forms.Button();
            this.CmdWednesday = new System.Windows.Forms.Button();
            this.CmdThursday = new System.Windows.Forms.Button();
            this.CmdFriday = new System.Windows.Forms.Button();
            this.CmdSaturday = new System.Windows.Forms.Button();
            this.CmdSunday = new System.Windows.Forms.Button();
            this.LblNumeric = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdMonday
            // 
            this.CmdMonday.Location = new System.Drawing.Point(41, 69);
            this.CmdMonday.Name = "CmdMonday";
            this.CmdMonday.Size = new System.Drawing.Size(110, 44);
            this.CmdMonday.TabIndex = 0;
            this.CmdMonday.Text = "Montag";
            this.CmdMonday.UseVisualStyleBackColor = true;
            this.CmdMonday.Click += new System.EventHandler(this.CmdMonday_Click);
            // 
            // CmdTuesday
            // 
            this.CmdTuesday.Location = new System.Drawing.Point(170, 69);
            this.CmdTuesday.Name = "CmdTuesday";
            this.CmdTuesday.Size = new System.Drawing.Size(110, 44);
            this.CmdTuesday.TabIndex = 0;
            this.CmdTuesday.Text = "Dienstag";
            this.CmdTuesday.UseVisualStyleBackColor = true;
            this.CmdTuesday.Click += new System.EventHandler(this.CmdTuesday_Click);
            // 
            // CmdWednesday
            // 
            this.CmdWednesday.Location = new System.Drawing.Point(301, 69);
            this.CmdWednesday.Name = "CmdWednesday";
            this.CmdWednesday.Size = new System.Drawing.Size(110, 44);
            this.CmdWednesday.TabIndex = 0;
            this.CmdWednesday.Text = "Mittwoch";
            this.CmdWednesday.UseVisualStyleBackColor = true;
            this.CmdWednesday.Click += new System.EventHandler(this.CmdWednesday_Click);
            // 
            // CmdThursday
            // 
            this.CmdThursday.Location = new System.Drawing.Point(41, 133);
            this.CmdThursday.Name = "CmdThursday";
            this.CmdThursday.Size = new System.Drawing.Size(110, 44);
            this.CmdThursday.TabIndex = 0;
            this.CmdThursday.Text = "Donnerstag";
            this.CmdThursday.UseVisualStyleBackColor = true;
            this.CmdThursday.Click += new System.EventHandler(this.CmdThursday_Click);
            // 
            // CmdFriday
            // 
            this.CmdFriday.Location = new System.Drawing.Point(170, 133);
            this.CmdFriday.Name = "CmdFriday";
            this.CmdFriday.Size = new System.Drawing.Size(110, 44);
            this.CmdFriday.TabIndex = 0;
            this.CmdFriday.Text = "Freitag";
            this.CmdFriday.UseVisualStyleBackColor = true;
            this.CmdFriday.Click += new System.EventHandler(this.CmdFriday_Click);
            // 
            // CmdSaturday
            // 
            this.CmdSaturday.Location = new System.Drawing.Point(301, 133);
            this.CmdSaturday.Name = "CmdSaturday";
            this.CmdSaturday.Size = new System.Drawing.Size(110, 44);
            this.CmdSaturday.TabIndex = 0;
            this.CmdSaturday.Text = "Samstag";
            this.CmdSaturday.UseVisualStyleBackColor = true;
            this.CmdSaturday.Click += new System.EventHandler(this.CmdSaturday_Click);
            // 
            // CmdSunday
            // 
            this.CmdSunday.Location = new System.Drawing.Point(170, 196);
            this.CmdSunday.Name = "CmdSunday";
            this.CmdSunday.Size = new System.Drawing.Size(110, 44);
            this.CmdSunday.TabIndex = 0;
            this.CmdSunday.Text = "Sonntag";
            this.CmdSunday.UseVisualStyleBackColor = true;
            this.CmdSunday.Click += new System.EventHandler(this.CmdSunday_Click);
            // 
            // LblNumeric
            // 
            this.LblNumeric.AutoSize = true;
            this.LblNumeric.Location = new System.Drawing.Point(56, 305);
            this.LblNumeric.Name = "LblNumeric";
            this.LblNumeric.Size = new System.Drawing.Size(184, 20);
            this.LblNumeric.TabIndex = 1;
            this.LblNumeric.Text = "Numerischer Wochentag";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 381);
            this.Controls.Add(this.LblNumeric);
            this.Controls.Add(this.CmdWednesday);
            this.Controls.Add(this.CmdSunday);
            this.Controls.Add(this.CmdSaturday);
            this.Controls.Add(this.CmdFriday);
            this.Controls.Add(this.CmdThursday);
            this.Controls.Add(this.CmdTuesday);
            this.Controls.Add(this.CmdMonday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdMonday;
        private System.Windows.Forms.Button CmdTuesday;
        private System.Windows.Forms.Button CmdWednesday;
        private System.Windows.Forms.Button CmdThursday;
        private System.Windows.Forms.Button CmdFriday;
        private System.Windows.Forms.Button CmdSaturday;
        private System.Windows.Forms.Button CmdSunday;
        private System.Windows.Forms.Label LblNumeric;
    }
}

