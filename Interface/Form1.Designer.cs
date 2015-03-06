﻿namespace Interface
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.manuell_multi = new System.Windows.Forms.ComboBox();
            this.waveformbox = new System.Windows.Forms.ComboBox();
            this.frequenz_show = new System.Windows.Forms.NumericUpDown();
            this.manuell_frequenz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vss_box = new System.Windows.Forms.NumericUpDown();
            this.voffset_box = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frequenz_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vss_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voffset_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frequenz";
            // 
            // manuell_multi
            // 
            this.manuell_multi.FormattingEnabled = true;
            this.manuell_multi.Items.AddRange(new object[] {
            "Hz",
            "kHz",
            "MHz"});
            this.manuell_multi.Location = new System.Drawing.Point(104, 107);
            this.manuell_multi.Name = "manuell_multi";
            this.manuell_multi.Size = new System.Drawing.Size(45, 21);
            this.manuell_multi.TabIndex = 2;
            this.manuell_multi.Text = "kHz";
            // 
            // waveformbox
            // 
            this.waveformbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waveformbox.FormattingEnabled = true;
            this.waveformbox.Items.AddRange(new object[] {
            "Sinus",
            "Dreieck",
            "Rechteck"});
            this.waveformbox.Location = new System.Drawing.Point(179, 145);
            this.waveformbox.Name = "waveformbox";
            this.waveformbox.Size = new System.Drawing.Size(94, 24);
            this.waveformbox.TabIndex = 3;
            this.waveformbox.Text = "Sinus";
            this.waveformbox.SelectedIndexChanged += new System.EventHandler(this.waveformbox_SelectedIndexChanged);
            // 
            // frequenz_show
            // 
            this.frequenz_show.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequenz_show.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.frequenz_show.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.frequenz_show.Location = new System.Drawing.Point(12, 36);
            this.frequenz_show.Maximum = new decimal(new int[] {
            12500000,
            0,
            0,
            0});
            this.frequenz_show.Name = "frequenz_show";
            this.frequenz_show.ReadOnly = true;
            this.frequenz_show.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frequenz_show.Size = new System.Drawing.Size(241, 66);
            this.frequenz_show.TabIndex = 4;
            this.frequenz_show.Value = new decimal(new int[] {
            1750,
            0,
            0,
            0});
            this.frequenz_show.ValueChanged += new System.EventHandler(this.frequenz_show_ValueChanged);
            // 
            // manuell_frequenz
            // 
            this.manuell_frequenz.Location = new System.Drawing.Point(12, 108);
            this.manuell_frequenz.Name = "manuell_frequenz";
            this.manuell_frequenz.Size = new System.Drawing.Size(86, 20);
            this.manuell_frequenz.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Manuell setzen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Signalform";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Step";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "50",
            "100",
            "500",
            "1000",
            "5000",
            "10000",
            "50000",
            "100000"});
            this.comboBox1.Location = new System.Drawing.Point(192, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "1000";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ausgansspannung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Offsetspannung";
            // 
            // vss_box
            // 
            this.vss_box.DecimalPlaces = 2;
            this.vss_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vss_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.vss_box.Location = new System.Drawing.Point(201, 174);
            this.vss_box.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.vss_box.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.vss_box.Name = "vss_box";
            this.vss_box.Size = new System.Drawing.Size(52, 22);
            this.vss_box.TabIndex = 12;
            this.vss_box.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.vss_box.ValueChanged += new System.EventHandler(this.vss_box_ValueChanged);
            // 
            // voffset_box
            // 
            this.voffset_box.DecimalPlaces = 2;
            this.voffset_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voffset_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.voffset_box.Location = new System.Drawing.Point(201, 206);
            this.voffset_box.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.voffset_box.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            -2147483648});
            this.voffset_box.Name = "voffset_box";
            this.voffset_box.Size = new System.Drawing.Size(52, 22);
            this.voffset_box.TabIndex = 13;
            this.voffset_box.ValueChanged += new System.EventHandler(this.voffset_box_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "V";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(349, 230);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 284);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.voffset_box);
            this.Controls.Add(this.vss_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.manuell_frequenz);
            this.Controls.Add(this.frequenz_show);
            this.Controls.Add(this.waveformbox);
            this.Controls.Add(this.manuell_multi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LabConnect Interface ©2015 Hendrik Lüth";
            ((System.ComponentModel.ISupportInitialize)(this.frequenz_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vss_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voffset_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox waveformbox;
        private System.Windows.Forms.NumericUpDown frequenz_show;
        private System.Windows.Forms.TextBox manuell_frequenz;
        private System.Windows.Forms.ComboBox manuell_multi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown vss_box;
        private System.Windows.Forms.NumericUpDown voffset_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
    }
}

