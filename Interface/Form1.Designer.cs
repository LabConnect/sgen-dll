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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.frequenz_show = new System.Windows.Forms.NumericUpDown();
            this.manuell_frequenz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frequenz_show)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
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
            this.manuell_multi.Location = new System.Drawing.Point(109, 134);
            this.manuell_multi.Name = "manuell_multi";
            this.manuell_multi.Size = new System.Drawing.Size(45, 21);
            this.manuell_multi.TabIndex = 2;
            this.manuell_multi.Text = "kHz";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(79, 233);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // frequenz_show
            // 
            this.frequenz_show.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequenz_show.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.frequenz_show.Location = new System.Drawing.Point(17, 63);
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
            10111000,
            0,
            0,
            0});
            this.frequenz_show.ValueChanged += new System.EventHandler(this.frequenz_show_ValueChanged);
            // 
            // manuell_frequenz
            // 
            this.manuell_frequenz.Location = new System.Drawing.Point(17, 135);
            this.manuell_frequenz.Name = "manuell_frequenz";
            this.manuell_frequenz.Size = new System.Drawing.Size(86, 20);
            this.manuell_frequenz.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Manuell setzen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.manuell_frequenz);
            this.Controls.Add(this.frequenz_show);
            this.Controls.Add(this.comboBox2);
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown frequenz_show;
        private System.Windows.Forms.TextBox manuell_frequenz;
        private System.Windows.Forms.ComboBox manuell_multi;
        private System.Windows.Forms.Button button1;
    }
}

