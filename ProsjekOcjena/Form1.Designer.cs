namespace ProsjekOcjena
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
            this.txtUnosOcjene = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.txtProsjek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUnosOcjene
            // 
            this.txtUnosOcjene.Location = new System.Drawing.Point(150, 55);
            this.txtUnosOcjene.Name = "txtUnosOcjene";
            this.txtUnosOcjene.Size = new System.Drawing.Size(100, 22);
            this.txtUnosOcjene.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unos ocjene:";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(39, 96);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(211, 53);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "&Unesi ocjenu";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // txtProsjek
            // 
            this.txtProsjek.Location = new System.Drawing.Point(150, 173);
            this.txtProsjek.Name = "txtProsjek";
            this.txtProsjek.Size = new System.Drawing.Size(100, 22);
            this.txtProsjek.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prosjek ocjena:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 228);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProsjek);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnosOcjene);
            this.Name = "Form1";
            this.Text = "Prosjek ocjena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnosOcjene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.TextBox txtProsjek;
        private System.Windows.Forms.Label label2;
    }
}

