namespace Uppgifter
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.tbxFörhandsgranskning = new System.Windows.Forms.TextBox();
            this.tbxTeckensnitt = new System.Windows.Forms.TextBox();
            this.cbxFet = new System.Windows.Forms.CheckBox();
            this.cbxKursiv = new System.Windows.Forms.CheckBox();
            this.cbxUnder = new System.Windows.Forms.CheckBox();
            this.tbxStorlek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(384, 364);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Check";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tbxFörhandsgranskning
            // 
            this.tbxFörhandsgranskning.Location = new System.Drawing.Point(120, 31);
            this.tbxFörhandsgranskning.Multiline = true;
            this.tbxFörhandsgranskning.Name = "tbxFörhandsgranskning";
            this.tbxFörhandsgranskning.Size = new System.Drawing.Size(362, 169);
            this.tbxFörhandsgranskning.TabIndex = 2;
            // 
            // tbxTeckensnitt
            // 
            this.tbxTeckensnitt.Location = new System.Drawing.Point(120, 235);
            this.tbxTeckensnitt.Name = "tbxTeckensnitt";
            this.tbxTeckensnitt.Size = new System.Drawing.Size(100, 20);
            this.tbxTeckensnitt.TabIndex = 3;
            // 
            // cbxFet
            // 
            this.cbxFet.AutoSize = true;
            this.cbxFet.Location = new System.Drawing.Point(120, 312);
            this.cbxFet.Name = "cbxFet";
            this.cbxFet.Size = new System.Drawing.Size(41, 17);
            this.cbxFet.TabIndex = 4;
            this.cbxFet.Text = "Fet";
            this.cbxFet.UseVisualStyleBackColor = true;
            // 
            // cbxKursiv
            // 
            this.cbxKursiv.AutoSize = true;
            this.cbxKursiv.Location = new System.Drawing.Point(120, 347);
            this.cbxKursiv.Name = "cbxKursiv";
            this.cbxKursiv.Size = new System.Drawing.Size(55, 17);
            this.cbxKursiv.TabIndex = 5;
            this.cbxKursiv.Text = "Kursiv";
            this.cbxKursiv.UseVisualStyleBackColor = true;
            // 
            // cbxUnder
            // 
            this.cbxUnder.AutoSize = true;
            this.cbxUnder.Location = new System.Drawing.Point(250, 312);
            this.cbxUnder.Name = "cbxUnder";
            this.cbxUnder.Size = new System.Drawing.Size(90, 17);
            this.cbxUnder.TabIndex = 6;
            this.cbxUnder.Text = "Understruken";
            this.cbxUnder.UseVisualStyleBackColor = true;
            // 
            // tbxStorlek
            // 
            this.tbxStorlek.Location = new System.Drawing.Point(342, 235);
            this.tbxStorlek.Name = "tbxStorlek";
            this.tbxStorlek.Size = new System.Drawing.Size(100, 20);
            this.tbxStorlek.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxStorlek);
            this.Controls.Add(this.cbxUnder);
            this.Controls.Add(this.cbxKursiv);
            this.Controls.Add(this.cbxFet);
            this.Controls.Add(this.tbxTeckensnitt);
            this.Controls.Add(this.tbxFörhandsgranskning);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxFörhandsgranskning;
        private System.Windows.Forms.TextBox tbxTeckensnitt;
        private System.Windows.Forms.CheckBox cbxFet;
        private System.Windows.Forms.CheckBox cbxKursiv;
        private System.Windows.Forms.CheckBox cbxUnder;
        private System.Windows.Forms.TextBox tbxStorlek;
    }
}

