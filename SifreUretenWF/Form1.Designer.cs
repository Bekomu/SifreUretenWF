namespace SifreUretenWF
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
            this.cbKharf = new System.Windows.Forms.CheckBox();
            this.cbBharf = new System.Windows.Forms.CheckBox();
            this.cbRakam = new System.Windows.Forms.CheckBox();
            this.cbOzel = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblSifreAdet = new System.Windows.Forms.Label();
            this.lblSifreUzunlugu = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKharf
            // 
            this.cbKharf.AutoSize = true;
            this.cbKharf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKharf.Location = new System.Drawing.Point(12, 18);
            this.cbKharf.Name = "cbKharf";
            this.cbKharf.Size = new System.Drawing.Size(107, 24);
            this.cbKharf.TabIndex = 0;
            this.cbKharf.Text = "Küçük Harf";
            this.cbKharf.UseVisualStyleBackColor = true;
            // 
            // cbBharf
            // 
            this.cbBharf.AutoSize = true;
            this.cbBharf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBharf.Location = new System.Drawing.Point(12, 48);
            this.cbBharf.Name = "cbBharf";
            this.cbBharf.Size = new System.Drawing.Size(107, 24);
            this.cbBharf.TabIndex = 1;
            this.cbBharf.Text = "Büyük Harf";
            this.cbBharf.UseVisualStyleBackColor = true;
            // 
            // cbRakam
            // 
            this.cbRakam.AutoSize = true;
            this.cbRakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbRakam.Location = new System.Drawing.Point(12, 78);
            this.cbRakam.Name = "cbRakam";
            this.cbRakam.Size = new System.Drawing.Size(96, 24);
            this.cbRakam.TabIndex = 2;
            this.cbRakam.Text = "Rakamlar";
            this.cbRakam.UseVisualStyleBackColor = true;
            // 
            // cbOzel
            // 
            this.cbOzel.AutoSize = true;
            this.cbOzel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOzel.Location = new System.Drawing.Point(12, 108);
            this.cbOzel.Name = "cbOzel";
            this.cbOzel.Size = new System.Drawing.Size(124, 24);
            this.cbOzel.TabIndex = 3;
            this.cbOzel.Text = "Özel Karakter";
            this.cbOzel.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(132, 152);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSifreAdet
            // 
            this.lblSifreAdet.AutoSize = true;
            this.lblSifreAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreAdet.Location = new System.Drawing.Point(8, 158);
            this.lblSifreAdet.Name = "lblSifreAdet";
            this.lblSifreAdet.Size = new System.Drawing.Size(87, 20);
            this.lblSifreAdet.TabIndex = 5;
            this.lblSifreAdet.Text = "Şifre Sayısı";
            // 
            // lblSifreUzunlugu
            // 
            this.lblSifreUzunlugu.AutoSize = true;
            this.lblSifreUzunlugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreUzunlugu.Location = new System.Drawing.Point(8, 197);
            this.lblSifreUzunlugu.Name = "lblSifreUzunlugu";
            this.lblSifreUzunlugu.Size = new System.Drawing.Size(114, 20);
            this.lblSifreUzunlugu.TabIndex = 6;
            this.lblSifreUzunlugu.Text = "Şifre Uzunluğu";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown2.Location = new System.Drawing.Point(132, 195);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Şifre Üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(275, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 279);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 317);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.lblSifreUzunlugu);
            this.Controls.Add(this.lblSifreAdet);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbOzel);
            this.Controls.Add(this.cbRakam);
            this.Controls.Add(this.cbBharf);
            this.Controls.Add(this.cbKharf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbKharf;
        private System.Windows.Forms.CheckBox cbBharf;
        private System.Windows.Forms.CheckBox cbRakam;
        private System.Windows.Forms.CheckBox cbOzel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblSifreAdet;
        private System.Windows.Forms.Label lblSifreUzunlugu;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

