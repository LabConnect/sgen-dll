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
            ((System.ComponentModel.ISupportInitialize)(this.frequenz_show)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
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
            this.manuell_multi.Location = new System.Drawing.Point(104, 119);
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
            this.waveformbox.Location = new System.Drawing.Point(132, 167);
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
            this.frequenz_show.Location = new System.Drawing.Point(12, 48);
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
            this.manuell_frequenz.Location = new System.Drawing.Point(12, 120);
            this.manuell_frequenz.Name = "manuell_frequenz";
            this.manuell_frequenz.Size = new System.Drawing.Size(86, 20);
            this.manuell_frequenz.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 117);
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
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Signalform";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 27);
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
            this.comboBox1.Location = new System.Drawing.Point(192, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "1000";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 284);
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
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.frequenz_show)).EndInit();
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
    }
}

