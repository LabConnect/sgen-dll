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
            double Frequenz, multiplikator = 1;
                     
            switch(manuell_multi.Text)
            {
                case "Hz":  multiplikator = 1;       break;
                case "kHz": multiplikator = 1000;    break;
                case "MHz": multiplikator = 1000000; break;
                default:    multiplikator = 1;       break;
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
    }
}
