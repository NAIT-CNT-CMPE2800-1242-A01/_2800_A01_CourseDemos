using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibWithDlgDemoMar11_2025;

namespace DialogTestHarness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////DlgConnect dlg = new DlgConnect();
            //ColorDialog dlg = new ColorDialog();

            //dlg.Color = Color.BlueViolet;
            //dlg.FullOpen = true;

            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    BackColor = dlg.Color;
            //}

            // prepopulate properties (if appropriate)
            DlgConnect dlg = new DlgConnect(42);
            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
