namespace Tavling
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
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.tbxPoint = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbxVisa = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnVisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(157, 51);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxNamn.TabIndex = 0;
            // 
            // tbxPoint
            // 
            this.tbxPoint.Location = new System.Drawing.Point(157, 134);
            this.tbxPoint.Name = "tbxPoint";
            this.tbxPoint.Size = new System.Drawing.Size(100, 20);
            this.tbxPoint.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 20);
            this.textBox3.TabIndex = 2;
            // 
            // lbxVisa
            // 
            this.lbxVisa.FormattingEnabled = true;
            this.lbxVisa.Location = new System.Drawing.Point(157, 297);
            this.lbxVisa.Name = "lbxVisa";
            this.lbxVisa.Size = new System.Drawing.Size(237, 108);
            this.lbxVisa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Poäng";
            // 
            // tbxSearch
            // 
            this.tbxSearch.AutoSize = true;
            this.tbxSearch.Location = new System.Drawing.Point(74, 224);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(59, 13);
            this.tbxSearch.TabIndex = 6;
            this.tbxSearch.Text = "Sök poäng";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(534, 70);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Registrera";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(534, 215);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(75, 23);
            this.btnVisa.TabIndex = 8;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.BtnVisa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxVisa);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbxPoint);
            this.Controls.Add(this.tbxNamn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.TextBox tbxPoint;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox lbxVisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tbxSearch;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnVisa;
    }
}

