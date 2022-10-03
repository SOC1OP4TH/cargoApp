namespace cargoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.qati = new System.Windows.Forms.RadioButton();
            this.maye = new System.Windows.Forms.RadioButton();
            this.Burundi = new System.Windows.Forms.RadioButton();
            this.Wakanda = new System.Windows.Forms.RadioButton();
            this.Turkey = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Transparent;
            this.calculate.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculate.Location = new System.Drawing.Point(12, 393);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(198, 69);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Hesabla";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(348, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 42);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "6";
            this.textBox1.TextChanged += new System.EventHandler(this.calculate_Click);
            // 
            // qati
            // 
            this.qati.AutoSize = true;
            this.qati.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qati.Location = new System.Drawing.Point(6, 13);
            this.qati.Name = "qati";
            this.qati.Size = new System.Drawing.Size(63, 29);
            this.qati.TabIndex = 2;
            this.qati.TabStop = true;
            this.qati.Text = "Qatı";
            this.qati.UseVisualStyleBackColor = true;
            this.qati.CheckedChanged += new System.EventHandler(this.qati_CheckedChanged);
            // 
            // maye
            // 
            this.maye.AutoSize = true;
            this.maye.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maye.Location = new System.Drawing.Point(5, 44);
            this.maye.Name = "maye";
            this.maye.Size = new System.Drawing.Size(66, 25);
            this.maye.TabIndex = 3;
            this.maye.TabStop = true;
            this.maye.Text = "Maye";
            this.maye.UseVisualStyleBackColor = true;
            // 
            // Burundi
            // 
            this.Burundi.AutoSize = true;
            this.Burundi.BackColor = System.Drawing.Color.Transparent;
            this.Burundi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Burundi.Location = new System.Drawing.Point(354, 341);
            this.Burundi.Name = "Burundi";
            this.Burundi.Size = new System.Drawing.Size(91, 29);
            this.Burundi.TabIndex = 4;
            this.Burundi.TabStop = true;
            this.Burundi.Text = "Burundi";
            this.Burundi.UseVisualStyleBackColor = false;
            this.Burundi.CheckedChanged += new System.EventHandler(this.Burundi_CheckedChanged);
            // 
            // Wakanda
            // 
            this.Wakanda.AutoSize = true;
            this.Wakanda.BackColor = System.Drawing.Color.Transparent;
            this.Wakanda.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Wakanda.Location = new System.Drawing.Point(354, 303);
            this.Wakanda.Name = "Wakanda";
            this.Wakanda.Size = new System.Drawing.Size(103, 29);
            this.Wakanda.TabIndex = 5;
            this.Wakanda.TabStop = true;
            this.Wakanda.Text = "Wakanda";
            this.Wakanda.UseVisualStyleBackColor = false;
            this.Wakanda.CheckedChanged += new System.EventHandler(this.Wakanda_CheckedChanged);
            // 
            // Turkey
            // 
            this.Turkey.AutoSize = true;
            this.Turkey.BackColor = System.Drawing.Color.Transparent;
            this.Turkey.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Turkey.Location = new System.Drawing.Point(354, 264);
            this.Turkey.Name = "Turkey";
            this.Turkey.Size = new System.Drawing.Size(82, 29);
            this.Turkey.TabIndex = 6;
            this.Turkey.TabStop = true;
            this.Turkey.Text = "Turkey";
            this.Turkey.UseVisualStyleBackColor = false;
            this.Turkey.CheckedChanged += new System.EventHandler(this.Turkey_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(371, 489);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 60);
            this.textBox2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.qati);
            this.groupBox1.Controls.Add(this.maye);
            this.groupBox1.Location = new System.Drawing.Point(371, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(79, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kiloqram/litr daxil edin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Məhsul tipini qeyd edin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ölkəni qeyd edin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ödəyəcəyiniz məbləğ:";
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(473, 88);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(57, 42);
            this.Sil.TabIndex = 13;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 688);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Turkey);
            this.Controls.Add(this.Wakanda);
            this.Controls.Add(this.Burundi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calculate);
            this.Name = "Form1";
            this.Text = "myCargoApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button calculate;
        private TextBox textBox1;
        private RadioButton qati;
        private RadioButton maye;
        private RadioButton Burundi;
        private RadioButton Wakanda;
        private RadioButton Turkey;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Sil;
    }
}