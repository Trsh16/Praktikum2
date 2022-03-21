namespace Praktikum2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox_aktif = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_merah = new System.Windows.Forms.RadioButton();
            this.radioButton_biru = new System.Windows.Forms.RadioButton();
            this.label_output = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // textBox_data
            // 
            this.textBox_data.Location = new System.Drawing.Point(75, 12);
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(292, 31);
            this.textBox_data.TabIndex = 1;
            this.textBox_data.TextChanged += new System.EventHandler(this.textBox_data_TextChanged);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(382, 12);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(112, 34);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Koleksi:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 254);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkBox_aktif
            // 
            this.checkBox_aktif.AutoSize = true;
            this.checkBox_aktif.Location = new System.Drawing.Point(336, 66);
            this.checkBox_aktif.Name = "checkBox_aktif";
            this.checkBox_aktif.Size = new System.Drawing.Size(75, 29);
            this.checkBox_aktif.TabIndex = 5;
            this.checkBox_aktif.Text = "Aktif";
            this.checkBox_aktif.UseVisualStyleBackColor = true;
            this.checkBox_aktif.CheckedChanged += new System.EventHandler(this.checkBox_aktif_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Setting:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output:";
            // 
            // radioButton_merah
            // 
            this.radioButton_merah.AutoSize = true;
            this.radioButton_merah.Location = new System.Drawing.Point(264, 105);
            this.radioButton_merah.Name = "radioButton_merah";
            this.radioButton_merah.Size = new System.Drawing.Size(147, 29);
            this.radioButton_merah.TabIndex = 9;
            this.radioButton_merah.TabStop = true;
            this.radioButton_merah.Text = "Warna Merah ";
            this.radioButton_merah.UseVisualStyleBackColor = true;
            this.radioButton_merah.CheckedChanged += new System.EventHandler(this.radioButton_merah_CheckedChanged);
            // 
            // radioButton_biru
            // 
            this.radioButton_biru.AutoSize = true;
            this.radioButton_biru.Location = new System.Drawing.Point(264, 140);
            this.radioButton_biru.Name = "radioButton_biru";
            this.radioButton_biru.Size = new System.Drawing.Size(122, 29);
            this.radioButton_biru.TabIndex = 10;
            this.radioButton_biru.TabStop = true;
            this.radioButton_biru.Text = "Warna Biru";
            this.radioButton_biru.UseVisualStyleBackColor = true;
            this.radioButton_biru.CheckedChanged += new System.EventHandler(this.radioButton_biru_CheckedChanged);
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_output.Location = new System.Drawing.Point(297, 298);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(0, 81);
            this.label_output.TabIndex = 11;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(275, 404);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(264, 34);
            this.button_clear.TabIndex = 12;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.radioButton_biru);
            this.Controls.Add(this.radioButton_merah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_aktif);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_data);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_data;
        private Button button_add;
        private Label label2;
        private ListBox listBox1;
        private CheckBox checkBox_aktif;
        private Label label3;
        private Label label4;
        private RadioButton radioButton_merah;
        private RadioButton radioButton_biru;
        private Label label_output;
        private Button button_clear;
    }
}