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

    }
}
