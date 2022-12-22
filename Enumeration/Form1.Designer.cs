namespace Enumeration
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
            this.Txt_Ausgabe = new System.Windows.Forms.TextBox();
            this.CmdDemo = new System.Windows.Forms.Button();
            this.CmdModulo = new System.Windows.Forms.Button();
            this.CmdIncDecDemo = new System.Windows.Forms.Button();
            this.CmdDivision = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Ausgabe
            // 
            this.Txt_Ausgabe.Location = new System.Drawing.Point(40, 226);
            this.Txt_Ausgabe.Multiline = true;
            this.Txt_Ausgabe.Name = "Txt_Ausgabe";
            this.Txt_Ausgabe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Ausgabe.Size = new System.Drawing.Size(713, 184);
            this.Txt_Ausgabe.TabIndex = 0;
            // 
            // CmdDemo
            // 
            this.CmdDemo.Location = new System.Drawing.Point(40, 134);
            this.CmdDemo.Name = "CmdDemo";
            this.CmdDemo.Size = new System.Drawing.Size(125, 47);
            this.CmdDemo.TabIndex = 1;
            this.CmdDemo.Text = "Enum Demo";
            this.CmdDemo.UseVisualStyleBackColor = true;
            this.CmdDemo.Click += new System.EventHandler(this.CmdDemo_Click);
            // 
            // CmdModulo
            // 
            this.CmdModulo.Location = new System.Drawing.Point(195, 134);
            this.CmdModulo.Name = "CmdModulo";
            this.CmdModulo.Size = new System.Drawing.Size(125, 47);
            this.CmdModulo.TabIndex = 1;
            this.CmdModulo.Text = "Modulo Demo";
            this.CmdModulo.UseVisualStyleBackColor = true;
            this.CmdModulo.Click += new System.EventHandler(this.CmdModulo_Click);
            // 
            // CmdIncDecDemo
            // 
            this.CmdIncDecDemo.Location = new System.Drawing.Point(360, 134);
            this.CmdIncDecDemo.Name = "CmdIncDecDemo";
            this.CmdIncDecDemo.Size = new System.Drawing.Size(125, 47);
            this.CmdIncDecDemo.TabIndex = 1;
            this.CmdIncDecDemo.Text = "Inc/Dec Demo";
            this.CmdIncDecDemo.UseVisualStyleBackColor = true;
            this.CmdIncDecDemo.Click += new System.EventHandler(this.CmdIncDecDemo_Click);
            // 
            // CmdDivision
            // 
            this.CmdDivision.Location = new System.Drawing.Point(517, 134);
            this.CmdDivision.Name = "CmdDivision";
            this.CmdDivision.Size = new System.Drawing.Size(125, 47);
            this.CmdDivision.TabIndex = 1;
            this.CmdDivision.Text = "Division Demo";
            this.CmdDivision.UseVisualStyleBackColor = true;
            this.CmdDivision.Click += new System.EventHandler(this.CmdDivision_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(40, 50);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(594, 37);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "3. Kapitel - Enumeration und Operatoren";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.CmdDivision);
            this.Controls.Add(this.CmdIncDecDemo);
            this.Controls.Add(this.CmdModulo);
            this.Controls.Add(this.CmdDemo);
            this.Controls.Add(this.Txt_Ausgabe);
            this.Name = "Form1";
            this.Text = "Enum_Übung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Ausgabe;
        private System.Windows.Forms.Button CmdDemo;
        private System.Windows.Forms.Button CmdModulo;
        private System.Windows.Forms.Button CmdIncDecDemo;
        private System.Windows.Forms.Button CmdDivision;
        private System.Windows.Forms.Label LblTitle;
    }
}

