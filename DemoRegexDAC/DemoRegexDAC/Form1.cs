using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// needed for REGEX
using System.Text.RegularExpressions;
using System.Drawing.Design;

namespace DemoRegexDAC
{
    public partial class Form1 : Form
    {
        // binding source relays data to and from the data aware control
        public BindingSource _bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // associate the data source of the DGV control to the binding source
            UI_DGV_Output.DataSource = _bs;
        }

        private void UI_B_DemoDGV_Click(object sender, EventArgs e)
        {
            // bs/dgv can display data from any public properties
            List<Widget> wids = new List<Widget>();
            wids.Add(new Widget(432));
            wids.Add(new Widget(91));
            wids.Add(new Widget(283));
            wids.Add(new Widget(-26));

            // update control
            _bs.DataSource = wids;
        }

        private void UI_B_DataA_Click(object sender, EventArgs e)
        {
            // properties exposed in a class can be consumed by a DGV/binding source
            //  this includes the properties that make up anonymous types
            _bs.DataSource = from c in "Hello" select new { Value = c, ASCII = (int)c };

            // columns will take on property names, so not generally what we want
            UI_DGV_Output.Columns[0].HeaderText = "char Value";
        }

        private void UI_B_DataB_Click(object sender, EventArgs e)
        {
            // build a regex object to support a particular expression XXX-d+
            Regex reg = new Regex(@"(?'prefix'[A-Z]{3})[-](?'num'\d+)");

            // the test string to parse (find matches in)
            string thingtoparse = @"MAC-0101, MAC-1021, BEF-223, snot, MAC-A, Turtle, TEK-1000";

            // determine how many elements in the test string qualify for parsing (would be 7)
            int iParsedItemsCount = thingtoparse.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Count();

            // is there a match in the test string (at least one)?
            if (reg.IsMatch (thingtoparse))
            {
                // get the collection of items that match
                MatchCollection x = reg.Matches(thingtoparse);

                // show them in the console
                foreach (Match gp in x)
                    Console.WriteLine($"{gp.Value} : {gp.Groups["prefix"]}, {gp.Groups["num"]}");

                // show them in the data-aware control
                _bs.DataSource = from Match gp in x select new { Full = gp.Value, Prefix = gp.Groups[1], Number = gp.Groups[2] };

                // was the entire test string consumed?
                if (iParsedItemsCount != x.Count)
                    Console.WriteLine("Not all items were matches!");
            }
        }

        private void UI_B_LINQ_GPS_Click(object sender, EventArgs e)
        {
            _bs.DataSource =
                from s
                in new string[] { "bucket", "stuff", "thing", "toast", "onion", "meat", "of", "bat", "cat", "eat", "fat", "hat", "mat", "pat", }
                group s
                by s.Length
                into g
                orderby g.Count(), g.Key
                select
                new { Length = g.Key, Count = g.Count(), Words = string.Join(", ", g) };

            UI_DGV_Output.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }

    public class Widget
    {
        public int DataVal { get; private set; }
        public string Description
        {
            get => "hello";
        }

        public Widget(int iVal) => DataVal = iVal;
    }
}
