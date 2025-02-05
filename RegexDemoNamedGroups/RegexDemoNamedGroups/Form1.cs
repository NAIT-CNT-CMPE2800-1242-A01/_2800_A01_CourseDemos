using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexDemoNamedGroups
{       
    public partial class Form1 : Form
    {
        private BindingSource _bs = new BindingSource();

        public Form1()
        {                                   // H H2 H2 O H2-JQ Fe S C J Qe2 C0
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // named groups demo
            string sTest = "H2SO4";
            if (Regex.IsMatch(sTest, @"(?'Symbol'[A-Z][a-z]?)(?'Count'[0-9]+)*"))
            {
                foreach (Match m in Regex.Matches(sTest, @"(?'Symbol'[A-Z][a-z]?)(?'Count'[0-9]+)*"))
                    Console.WriteLine(m.Value + " : " + m.Groups["Symbol"] + ", " + m.Groups["Count"]);
            }

            // DGV demo

            // only need to do this once
            UI_DGV.DataSource = _bs;

            // now can push data through bs to get to dgv
            int[] stuff = new int[] { 2, 4, 5, 3, 2, 14, 56, 2, 1 };

            _bs.DataSource = from x in stuff select new
            {
                Value = x,
                Square = x * x,
                Half = $"{x / 2f:f2}"
            };
        }
    }
}
