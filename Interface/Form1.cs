using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabConnect;

namespace Interface
{
    
    public partial class Form1 : Form
    {
        LabConnect.Sgen Signalgenerator = new Sgen();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change_frequenz_UI();
        }

        private void frequenz_show_ValueChanged(object sender, EventArgs e)
        {
            Signalgenerator.SetFrequency(Convert.ToInt32(frequenz_show.Value));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frequenz_show.Increment = Convert.ToInt32(comboBox1.Text);
        }

        private void waveformbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Signalgenerator.SetWaveform(waveformbox.SelectedIndex);
            
        }

        private void vss_box_ValueChanged(object sender, EventArgs e)
        {
            Signalgenerator.RegwertUout(Convert.ToInt32(vss_box.Value * 1000));
        }

        private void voffset_box_ValueChanged(object sender, EventArgs e)
        {
            Signalgenerator.RegwertOffset(Convert.ToDouble(voffset_box.Value));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ergebnis0.Text = Convert.ToString(Signalgenerator.output_data[0], 16);
            ergebnis1.Text = Convert.ToString(Signalgenerator.output_data[1], 16);
            ergebnis2.Text = Convert.ToString(Signalgenerator.output_data[2], 16);
            ergebnis3.Text = Convert.ToString(Signalgenerator.output_data[3], 16);
            ergebnis4.Text = Convert.ToString(Signalgenerator.output_data[4], 16);
            ergebnis5.Text = Convert.ToString(Signalgenerator.output_data[5], 16);
            ergebnis6.Text = Convert.ToString(Signalgenerator.output_data[6], 16);
            ergebnis7.Text = Convert.ToString(Signalgenerator.output_data[7], 16);
            ergebnis8.Text = Convert.ToString(Signalgenerator.output_data[8], 16);
            ergebnis9.Text = Convert.ToString(Signalgenerator.output_data[9], 16);
            ergebnis10.Text = Convert.ToString(Signalgenerator.output_data[10], 16);
            ergebnis11.Text = Convert.ToString(Signalgenerator.output_data[11], 16);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signalgenerator.SetCommand();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Signalgenerator.GetBootLoad();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Signalgenerator.BootData(checkBox2.Checked, checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Signalgenerator.BootData(checkBox2.Checked, checkBox1.Checked);
        }

        private void manuell_frequenz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                change_frequenz_UI();
            }
        }

        private void change_frequenz_UI()
        {
            double Frequenz, multiplikator = 1;

            switch (manuell_multi.Text)
            {
                case "Hz": multiplikator = 1; break;
                case "kHz": multiplikator = 1000; break;
                case "MHz": multiplikator = 1000000; break;
                default: multiplikator = 1; break;
            }

            try
            {
                Frequenz = Convert.ToDouble(manuell_frequenz.Text) * multiplikator;
            }
            catch
            {
                MessageBox.Show("Die eingegebene Frequenz muss zwischen 1Hz und 12,5Mhz liegen!");
                return;
            }

            if ((Frequenz > 12500000) | (Frequenz < 1))
            {
                MessageBox.Show("Die eingegebene Frequenz muss zwischen 1Hz und 12,5Mhz liegen!");
                return;
            }

            frequenz_show.Value = Convert.ToInt32(Frequenz);
            Signalgenerator.SetFrequency(Convert.ToInt32(Frequenz));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Verbinden" && Signalgenerator.init() == true)
            {
                comboBox2.Enabled = false;
                button3.Text = "Trennen";
                groupBox1.Enabled = true;
                checkBox1.Checked = Signalgenerator.GetBootLoad();
                seriennummer1.Text = Convert.ToString(Signalgenerator.calibration_data[0]);
                MCLK1.Text = Convert.ToString(Signalgenerator.MCLK);
            }
            else
            {
                comboBox2.Enabled = true;
                button3.Text = "Verbinden";
                groupBox1.Enabled = false;
                seriennummer1.Text = "0";
                MCLK1.Text = "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte errorcode = Signalgenerator.GetErrors();
            MessageBox.Show(Convert.ToString(errorcode,16));
        }
    }
}
