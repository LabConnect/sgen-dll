namespace Interface
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
            this.components = new System.ComponentModel.Container();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ergebnis0 = new System.Windows.Forms.Label();
            this.ergebnis1 = new System.Windows.Forms.Label();
            this.ergebnis2 = new System.Windows.Forms.Label();
            this.ergebnis3 = new System.Windows.Forms.Label();
            this.ergebnis4 = new System.Windows.Forms.Label();
            this.ergebnis5 = new System.Windows.Forms.Label();
            this.ergebnis6 = new System.Windows.Forms.Label();
            this.ergebnis7 = new System.Windows.Forms.Label();
            this.ergebnis8 = new System.Windows.Forms.Label();
            this.ergebnis9 = new System.Windows.Forms.Label();
            this.ergebnis10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ergebnis11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frequenz_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vss_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voffset_box)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 51);
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
            this.manuell_multi.Location = new System.Drawing.Point(104, 150);
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
            this.waveformbox.Location = new System.Drawing.Point(179, 188);
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
            this.frequenz_show.Location = new System.Drawing.Point(12, 79);
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
            this.manuell_frequenz.Location = new System.Drawing.Point(12, 151);
            this.manuell_frequenz.Name = "manuell_frequenz";
            this.manuell_frequenz.Size = new System.Drawing.Size(86, 20);
            this.manuell_frequenz.TabIndex = 5;
            this.manuell_frequenz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manuell_frequenz_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 148);
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
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Signalform";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 58);
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
            this.comboBox1.Location = new System.Drawing.Point(192, 57);
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
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ausgansspannung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 244);
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
            131072});
            this.vss_box.Location = new System.Drawing.Point(201, 217);
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
            this.voffset_box.Location = new System.Drawing.Point(201, 249);
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
            this.label6.Location = new System.Drawing.Point(251, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "V";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ergebnis0
            // 
            this.ergebnis0.AutoSize = true;
            this.ergebnis0.Location = new System.Drawing.Point(290, 63);
            this.ergebnis0.Name = "ergebnis0";
            this.ergebnis0.Size = new System.Drawing.Size(53, 13);
            this.ergebnis0.TabIndex = 16;
            this.ergebnis0.Text = "ergebnis0";
            // 
            // ergebnis1
            // 
            this.ergebnis1.AutoSize = true;
            this.ergebnis1.Location = new System.Drawing.Point(290, 77);
            this.ergebnis1.Name = "ergebnis1";
            this.ergebnis1.Size = new System.Drawing.Size(53, 13);
            this.ergebnis1.TabIndex = 17;
            this.ergebnis1.Text = "ergebnis1";
            // 
            // ergebnis2
            // 
            this.ergebnis2.AutoSize = true;
            this.ergebnis2.Location = new System.Drawing.Point(290, 115);
            this.ergebnis2.Name = "ergebnis2";
            this.ergebnis2.Size = new System.Drawing.Size(53, 13);
            this.ergebnis2.TabIndex = 18;
            this.ergebnis2.Text = "ergebnis2";
            // 
            // ergebnis3
            // 
            this.ergebnis3.AutoSize = true;
            this.ergebnis3.Location = new System.Drawing.Point(290, 130);
            this.ergebnis3.Name = "ergebnis3";
            this.ergebnis3.Size = new System.Drawing.Size(53, 13);
            this.ergebnis3.TabIndex = 19;
            this.ergebnis3.Text = "ergebnis3";
            // 
            // ergebnis4
            // 
            this.ergebnis4.AutoSize = true;
            this.ergebnis4.Location = new System.Drawing.Point(290, 143);
            this.ergebnis4.Name = "ergebnis4";
            this.ergebnis4.Size = new System.Drawing.Size(53, 13);
            this.ergebnis4.TabIndex = 20;
            this.ergebnis4.Text = "ergebnis4";
            // 
            // ergebnis5
            // 
            this.ergebnis5.AutoSize = true;
            this.ergebnis5.Location = new System.Drawing.Point(290, 156);
            this.ergebnis5.Name = "ergebnis5";
            this.ergebnis5.Size = new System.Drawing.Size(53, 13);
            this.ergebnis5.TabIndex = 21;
            this.ergebnis5.Text = "ergebnis5";
            // 
            // ergebnis6
            // 
            this.ergebnis6.AutoSize = true;
            this.ergebnis6.Location = new System.Drawing.Point(290, 182);
            this.ergebnis6.Name = "ergebnis6";
            this.ergebnis6.Size = new System.Drawing.Size(53, 13);
            this.ergebnis6.TabIndex = 22;
            this.ergebnis6.Text = "ergebnis6";
            // 
            // ergebnis7
            // 
            this.ergebnis7.AutoSize = true;
            this.ergebnis7.Location = new System.Drawing.Point(290, 197);
            this.ergebnis7.Name = "ergebnis7";
            this.ergebnis7.Size = new System.Drawing.Size(53, 13);
            this.ergebnis7.TabIndex = 23;
            this.ergebnis7.Text = "ergebnis7";
            // 
            // ergebnis8
            // 
            this.ergebnis8.AutoSize = true;
            this.ergebnis8.Location = new System.Drawing.Point(290, 227);
            this.ergebnis8.Name = "ergebnis8";
            this.ergebnis8.Size = new System.Drawing.Size(53, 13);
            this.ergebnis8.TabIndex = 24;
            this.ergebnis8.Text = "ergebnis8";
            // 
            // ergebnis9
            // 
            this.ergebnis9.AutoSize = true;
            this.ergebnis9.Location = new System.Drawing.Point(290, 240);
            this.ergebnis9.Name = "ergebnis9";
            this.ergebnis9.Size = new System.Drawing.Size(53, 13);
            this.ergebnis9.TabIndex = 25;
            this.ergebnis9.Text = "ergebnis9";
            // 
            // ergebnis10
            // 
            this.ergebnis10.AutoSize = true;
            this.ergebnis10.Location = new System.Drawing.Point(290, 271);
            this.ergebnis10.Name = "ergebnis10";
            this.ergebnis10.Size = new System.Drawing.Size(59, 13);
            this.ergebnis10.TabIndex = 26;
            this.ergebnis10.Text = "ergebnis10";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(169, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Daten übertragen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 276);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Daten beim boot laden";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 296);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(151, 17);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "Daten auf Gerät speichern";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ergebnis11
            // 
            this.ergebnis11.AutoSize = true;
            this.ergebnis11.Location = new System.Drawing.Point(290, 292);
            this.ergebnis11.Name = "ergebnis11";
            this.ergebnis11.Size = new System.Drawing.Size(59, 13);
            this.ergebnis11.TabIndex = 30;
            this.ergebnis11.Text = "ergebnis11";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Verbinden";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Signalgenerator Ser.Nr. 0001"});
            this.comboBox2.Location = new System.Drawing.Point(12, 14);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 21);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.Text = "Signalgenerator Ser.Nr. 0001";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Aktualisieren";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 324);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ergebnis11);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ergebnis10);
            this.Controls.Add(this.ergebnis9);
            this.Controls.Add(this.ergebnis8);
            this.Controls.Add(this.ergebnis7);
            this.Controls.Add(this.ergebnis6);
            this.Controls.Add(this.ergebnis5);
            this.Controls.Add(this.ergebnis4);
            this.Controls.Add(this.ergebnis3);
            this.Controls.Add(this.ergebnis2);
            this.Controls.Add(this.ergebnis1);
            this.Controls.Add(this.ergebnis0);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frequenz_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vss_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voffset_box)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ergebnis0;
        private System.Windows.Forms.Label ergebnis1;
        private System.Windows.Forms.Label ergebnis2;
        private System.Windows.Forms.Label ergebnis3;
        private System.Windows.Forms.Label ergebnis4;
        private System.Windows.Forms.Label ergebnis5;
        private System.Windows.Forms.Label ergebnis6;
        private System.Windows.Forms.Label ergebnis7;
        private System.Windows.Forms.Label ergebnis8;
        private System.Windows.Forms.Label ergebnis9;
        private System.Windows.Forms.Label ergebnis10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label ergebnis11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
    }
}

