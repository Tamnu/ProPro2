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
            this.cbxFet = new System.Windows.Forms.CheckBox();
            this.cbxKursiv = new System.Windows.Forms.CheckBox();
            this.cbxUnder = new System.Windows.Forms.CheckBox();
            this.tbxStorlek = new System.Windows.Forms.TextBox();
            this.cbxStrike = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // cbxFet
            // 
            this.cbxFet.AutoSize = true;
            this.cbxFet.Location = new System.Drawing.Point(120, 312);
            this.cbxFet.Name = "cbxFet";
            this.cbxFet.Size = new System.Drawing.Size(41, 17);
            this.cbxFet.TabIndex = 4;
            this.cbxFet.Text = "Fet";
            this.cbxFet.UseVisualStyleBackColor = true;
            this.cbxFet.CheckedChanged += new System.EventHandler(this.CbxFet_CheckedChanged);
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
            this.cbxKursiv.CheckedChanged += new System.EventHandler(this.CbxKursiv_CheckedChanged);
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
            this.cbxUnder.CheckedChanged += new System.EventHandler(this.CbxUnder_CheckedChanged);
            // 
            // tbxStorlek
            // 
            this.tbxStorlek.Location = new System.Drawing.Point(342, 235);
            this.tbxStorlek.Name = "tbxStorlek";
            this.tbxStorlek.Size = new System.Drawing.Size(100, 20);
            this.tbxStorlek.TabIndex = 7;
            // 
            // cbxStrike
            // 
            this.cbxStrike.AutoSize = true;
            this.cbxStrike.Location = new System.Drawing.Point(250, 347);
            this.cbxStrike.Name = "cbxStrike";
            this.cbxStrike.Size = new System.Drawing.Size(53, 17);
            this.cbxStrike.TabIndex = 8;
            this.cbxStrike.Text = "Strike";
            this.cbxStrike.UseVisualStyleBackColor = true;
            this.cbxStrike.CheckedChanged += new System.EventHandler(this.CbxStrike_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(591, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbxStrike);
            this.Controls.Add(this.tbxStorlek);
            this.Controls.Add(this.cbxUnder);
            this.Controls.Add(this.cbxKursiv);
            this.Controls.Add(this.cbxFet);
            this.Controls.Add(this.tbxFörhandsgranskning);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxFörhandsgranskning;
        private System.Windows.Forms.CheckBox cbxFet;
        private System.Windows.Forms.CheckBox cbxKursiv;
        private System.Windows.Forms.CheckBox cbxUnder;
        private System.Windows.Forms.TextBox tbxStorlek;
        private System.Windows.Forms.CheckBox cbxStrike;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

