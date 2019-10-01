namespace Träning
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
            this.tbxSträcka = new System.Windows.Forms.TextBox();
            this.tbxTid = new System.Windows.Forms.TextBox();
            this.tbxSök = new System.Windows.Forms.TextBox();
            this.lbxVisa = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAlla = new System.Windows.Forms.Button();
            this.btnNågra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxSträcka
            // 
            this.tbxSträcka.Location = new System.Drawing.Point(176, 45);
            this.tbxSträcka.Name = "tbxSträcka";
            this.tbxSträcka.Size = new System.Drawing.Size(100, 20);
            this.tbxSträcka.TabIndex = 0;
            // 
            // tbxTid
            // 
            this.tbxTid.Location = new System.Drawing.Point(176, 102);
            this.tbxTid.Name = "tbxTid";
            this.tbxTid.Size = new System.Drawing.Size(100, 20);
            this.tbxTid.TabIndex = 1;
            // 
            // tbxSök
            // 
            this.tbxSök.Location = new System.Drawing.Point(210, 167);
            this.tbxSök.Name = "tbxSök";
            this.tbxSök.Size = new System.Drawing.Size(168, 20);
            this.tbxSök.TabIndex = 2;
            // 
            // lbxVisa
            // 
            this.lbxVisa.FormattingEnabled = true;
            this.lbxVisa.Location = new System.Drawing.Point(176, 257);
            this.lbxVisa.Name = "lbxVisa";
            this.lbxVisa.Size = new System.Drawing.Size(232, 147);
            this.lbxVisa.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(302, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnAlla
            // 
            this.btnAlla.Location = new System.Drawing.Point(303, 193);
            this.btnAlla.Name = "btnAlla";
            this.btnAlla.Size = new System.Drawing.Size(186, 23);
            this.btnAlla.TabIndex = 5;
            this.btnAlla.Text = "Visa tid";
            this.btnAlla.UseVisualStyleBackColor = true;
            this.btnAlla.Click += new System.EventHandler(this.BtnAlla_Click);
            // 
            // btnNågra
            // 
            this.btnNågra.Location = new System.Drawing.Point(303, 228);
            this.btnNågra.Name = "btnNågra";
            this.btnNågra.Size = new System.Drawing.Size(186, 23);
            this.btnNågra.TabIndex = 6;
            this.btnNågra.Text = "Visa hastighet";
            this.btnNågra.UseVisualStyleBackColor = true;
            this.btnNågra.Click += new System.EventHandler(this.BtnNågra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sträcka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sök";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNågra);
            this.Controls.Add(this.btnAlla);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxVisa);
            this.Controls.Add(this.tbxSök);
            this.Controls.Add(this.tbxTid);
            this.Controls.Add(this.tbxSträcka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSträcka;
        private System.Windows.Forms.TextBox tbxTid;
        private System.Windows.Forms.TextBox tbxSök;
        private System.Windows.Forms.ListBox lbxVisa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAlla;
        private System.Windows.Forms.Button btnNågra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

