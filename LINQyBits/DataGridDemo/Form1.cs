using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridDemo
{
    public partial class Form1 : Form
    {
        // the binding source adapts your data to the control (and back if needed)
        BindingSource bs = new BindingSource();
        static Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // associate the binding source with the data grid view countrol
            UI_DGVOutput.DataSource = bs;
        }

        private void UI_B_Populate_Click(object sender, EventArgs e)
        {
            // generate some data
            List<int> iNums = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            var Squares = iNums.ToDictionary((k) => k, (k) => (int)Math.Pow(k, 2));

            // take first 5 values, create anon type with elements we want, and apply to datasource
            bs.DataSource = from kvp in Squares.Take(5)
                            select new {
                                Number = kvp.Key,                       // original number
                                Square = kvp.Value.ToString("f2"),      // its square
                                Random = rnd.Next (kvp.Key, kvp.Value)  // manufactured column
                            };
            
            // change the column name in the UI (can use more complex names than annon type name)
            UI_DGVOutput.Columns[0].HeaderText = "Base Number";
        }       
    }
}
