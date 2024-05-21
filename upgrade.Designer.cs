namespace ProsjekUgrade
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_unesi = new System.Windows.Forms.Button();
            this.Btn_spremi = new System.Windows.Forms.Button();
            this.Btn_ispisi = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 43);
            this.textBox1.TabIndex = 1;
            // 
            // Btn_unesi
            // 
            this.Btn_unesi.AccessibleDescription = "";
            this.Btn_unesi.AccessibleName = "";
            this.Btn_unesi.Location = new System.Drawing.Point(241, 140);
            this.Btn_unesi.Name = "Btn_unesi";
            this.Btn_unesi.Size = new System.Drawing.Size(146, 88);
            this.Btn_unesi.TabIndex = 2;
            this.Btn_unesi.Text = "Unesi";
            this.Btn_unesi.UseVisualStyleBackColor = true;
            this.Btn_unesi.Click += new System.EventHandler(this.Btn_unesi_Click);
            // 
            // Btn_spremi
            // 
            this.Btn_spremi.Location = new System.Drawing.Point(241, 234);
            this.Btn_spremi.Name = "Btn_spremi";
            this.Btn_spremi.Size = new System.Drawing.Size(146, 84);
            this.Btn_spremi.TabIndex = 3;
            this.Btn_spremi.Text = "Spremi";
            this.Btn_spremi.UseVisualStyleBackColor = true;
            // 
            // Btn_ispisi
            // 
            this.Btn_ispisi.Location = new System.Drawing.Point(241, 324);
            this.Btn_ispisi.Name = "Btn_ispisi";
            this.Btn_ispisi.Size = new System.Drawing.Size(146, 82);
            this.Btn_ispisi.TabIndex = 4;
            this.Btn_ispisi.Text = "Ispiši";
            this.Btn_ispisi.UseVisualStyleBackColor = true;
            this.Btn_ispisi.Click += new System.EventHandler(this.Btn_ispisi_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 95);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 343);
            this.textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hrvatski jezik",
            "Matematika"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(375, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "";
            this.button1.AccessibleName = "";
            this.button1.Location = new System.Drawing.Point(243, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 88);
            this.button1.TabIndex = 8;
            this.button1.Text = "Učitaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Btn_ispisi);
            this.Controls.Add(this.Btn_spremi);
            this.Controls.Add(this.Btn_unesi);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_unesi;
        private System.Windows.Forms.Button Btn_spremi;
        private System.Windows.Forms.Button Btn_ispisi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

