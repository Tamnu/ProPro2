namespace Övningar
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
            this.lbxVisa = new System.Windows.Forms.ListBox();
            this.tbxKund = new System.Windows.Forms.TextBox();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            this.tbxDagar = new System.Windows.Forms.TextBox();
            this.tbxSök = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBoka = new System.Windows.Forms.Button();
            this.btnSök = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxVisa
            // 
            this.lbxVisa.FormattingEnabled = true;
            this.lbxVisa.Location = new System.Drawing.Point(109, 252);
            this.lbxVisa.Name = "lbxVisa";
            this.lbxVisa.Size = new System.Drawing.Size(577, 95);
            this.lbxVisa.TabIndex = 0;
            // 
            // tbxKund
            // 
            this.tbxKund.Location = new System.Drawing.Point(292, 25);
            this.tbxKund.Name = "tbxKund";
            this.tbxKund.Size = new System.Drawing.Size(100, 20);
            this.tbxKund.TabIndex = 1;
            // 
            // tbxDestination
            // 
            this.tbxDestination.Location = new System.Drawing.Point(292, 84);
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.Size = new System.Drawing.Size(100, 20);
            this.tbxDestination.TabIndex = 2;
            // 
            // tbxDagar
            // 
            this.tbxDagar.Location = new System.Drawing.Point(292, 143);
            this.tbxDagar.Name = "tbxDagar";
            this.tbxDagar.Size = new System.Drawing.Size(100, 20);
            this.tbxDagar.TabIndex = 3;
            // 
            // tbxSök
            // 
            this.tbxSök.Location = new System.Drawing.Point(292, 209);
            this.tbxSök.Name = "tbxSök";
            this.tbxSök.Size = new System.Drawing.Size(100, 20);
            this.tbxSök.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kund";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Antal dagar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sök";
            // 
            // btnBoka
            // 
            this.btnBoka.Location = new System.Drawing.Point(484, 141);
            this.btnBoka.Name = "btnBoka";
            this.btnBoka.Size = new System.Drawing.Size(75, 23);
            this.btnBoka.TabIndex = 9;
            this.btnBoka.Text = "Boka";
            this.btnBoka.UseVisualStyleBackColor = true;
            this.btnBoka.Click += new System.EventHandler(this.BtnBoka_Click);
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(484, 207);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(75, 23);
            this.btnSök.TabIndex = 10;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.btnBoka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSök);
            this.Controls.Add(this.tbxDagar);
            this.Controls.Add(this.tbxDestination);
            this.Controls.Add(this.tbxKund);
            this.Controls.Add(this.lbxVisa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxVisa;
        private System.Windows.Forms.TextBox tbxKund;
        private System.Windows.Forms.TextBox tbxDestination;
        private System.Windows.Forms.TextBox tbxDagar;
        private System.Windows.Forms.TextBox tbxSök;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBoka;
        private System.Windows.Forms.Button btnSök;
    }
}

