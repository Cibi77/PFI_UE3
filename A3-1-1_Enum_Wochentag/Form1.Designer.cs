namespace A3_1_1_Enum_Wochentag
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
            this.LblDayofWeek = new System.Windows.Forms.Label();
            this.CmdMonday = new System.Windows.Forms.Button();
            this.CmdThuesday = new System.Windows.Forms.Button();
            this.CmdWednesday = new System.Windows.Forms.Button();
            this.CmdThursday = new System.Windows.Forms.Button();
            this.CmdFriday = new System.Windows.Forms.Button();
            this.CmdSaturday = new System.Windows.Forms.Button();
            this.CmdSunday = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDayofWeek
            // 
            this.LblDayofWeek.AutoSize = true;
            this.LblDayofWeek.Location = new System.Drawing.Point(44, 243);
            this.LblDayofWeek.Name = "LblDayofWeek";
            this.LblDayofWeek.Size = new System.Drawing.Size(184, 20);
            this.LblDayofWeek.TabIndex = 0;
            this.LblDayofWeek.Text = "Numerischer Wochentag";
            // 
            // CmdMonday
            // 
            this.CmdMonday.Location = new System.Drawing.Point(48, 46);
            this.CmdMonday.Name = "CmdMonday";
            this.CmdMonday.Size = new System.Drawing.Size(104, 36);
            this.CmdMonday.TabIndex = 1;
            this.CmdMonday.Text = "Montag";
            this.CmdMonday.UseVisualStyleBackColor = true;
            this.CmdMonday.Click += new System.EventHandler(this.CmdMonday_Click);
            // 
            // CmdThuesday
            // 
            this.CmdThuesday.Location = new System.Drawing.Point(169, 46);
            this.CmdThuesday.Name = "CmdThuesday";
            this.CmdThuesday.Size = new System.Drawing.Size(104, 36);
            this.CmdThuesday.TabIndex = 1;
            this.CmdThuesday.Text = "Dienstag";
            this.CmdThuesday.UseVisualStyleBackColor = true;
            this.CmdThuesday.Click += new System.EventHandler(this.CmdThuesday_Click);
            // 
            // CmdWednesday
            // 
            this.CmdWednesday.Location = new System.Drawing.Point(292, 46);
            this.CmdWednesday.Name = "CmdWednesday";
            this.CmdWednesday.Size = new System.Drawing.Size(104, 36);
            this.CmdWednesday.TabIndex = 1;
            this.CmdWednesday.Text = "Mittwoch";
            this.CmdWednesday.UseVisualStyleBackColor = true;
            this.CmdWednesday.Click += new System.EventHandler(this.CmdWednesday_Click);
            // 
            // CmdThursday
            // 
            this.CmdThursday.Location = new System.Drawing.Point(48, 99);
            this.CmdThursday.Name = "CmdThursday";
            this.CmdThursday.Size = new System.Drawing.Size(115, 36);
            this.CmdThursday.TabIndex = 1;
            this.CmdThursday.Text = "Donnerstag";
            this.CmdThursday.UseVisualStyleBackColor = true;
            this.CmdThursday.Click += new System.EventHandler(this.CmdThursday_Click);
            // 
            // CmdFriday
            // 
            this.CmdFriday.Location = new System.Drawing.Point(169, 99);
            this.CmdFriday.Name = "CmdFriday";
            this.CmdFriday.Size = new System.Drawing.Size(104, 36);
            this.CmdFriday.TabIndex = 1;
            this.CmdFriday.Text = "Freitag";
            this.CmdFriday.UseVisualStyleBackColor = true;
            this.CmdFriday.Click += new System.EventHandler(this.CmdFriday_Click);
            // 
            // CmdSaturday
            // 
            this.CmdSaturday.Location = new System.Drawing.Point(292, 99);
            this.CmdSaturday.Name = "CmdSaturday";
            this.CmdSaturday.Size = new System.Drawing.Size(104, 36);
            this.CmdSaturday.TabIndex = 1;
            this.CmdSaturday.Text = "Samstag";
            this.CmdSaturday.UseVisualStyleBackColor = true;
            this.CmdSaturday.Click += new System.EventHandler(this.CmdSaturday_Click);
            // 
            // CmdSunday
            // 
            this.CmdSunday.Location = new System.Drawing.Point(169, 153);
            this.CmdSunday.Name = "CmdSunday";
            this.CmdSunday.Size = new System.Drawing.Size(104, 36);
            this.CmdSunday.TabIndex = 1;
            this.CmdSunday.Text = "Sunday";
            this.CmdSunday.UseVisualStyleBackColor = true;
            this.CmdSunday.Click += new System.EventHandler(this.CmdSunday_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 385);
            this.Controls.Add(this.CmdWednesday);
            this.Controls.Add(this.CmdThuesday);
            this.Controls.Add(this.CmdSunday);
            this.Controls.Add(this.CmdSaturday);
            this.Controls.Add(this.CmdFriday);
            this.Controls.Add(this.CmdThursday);
            this.Controls.Add(this.CmdMonday);
            this.Controls.Add(this.LblDayofWeek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDayofWeek;
        private System.Windows.Forms.Button CmdMonday;
        private System.Windows.Forms.Button CmdThuesday;
        private System.Windows.Forms.Button CmdWednesday;
        private System.Windows.Forms.Button CmdThursday;
        private System.Windows.Forms.Button CmdFriday;
        private System.Windows.Forms.Button CmdSaturday;
        private System.Windows.Forms.Button CmdSunday;
    }
}

