using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace LINQyBits
{
    public partial class Form1 : Form
    {
        private static Random _rnd = new Random();
        private BindingSource _bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UI_DGV.DataSource = _bs;

            //List<int> nums = new List<int>();

            //while (nums.Count < 20)
            //    nums.Add(_rnd.Next(1, 20));

            //Console.WriteLine(" ");
            //Console.WriteLine(" ");

            //var result = (
            //    from i in nums
            //    where i >= 10
            //    select i into q
            //    orderby q
            //    where q % 2 == 0
            //    select q).ToList().Distinct();

            //foreach (var s in result)
            //    Console.WriteLine(s.ToString());

            //// Console.WriteLine(" ");
            //Console.WriteLine(" ");
            //Console.WriteLine(" ");

            //List<int> nums = new List<int>();

            //while (nums.Count < 20)
            //    nums.Add(_rnd.Next(1, 20));

            //var result = (
            //    from i in nums
            //    where i >= 10
            //    select i into q
            //    orderby q
            //    where q % 2 == 0
            //    select q).ToList().Distinct();

            // OR
            //var result = (from i in nums
            //              where i >= 10
            //              select i
            //                    into q
            //              where q % 2 == 0
            //              orderby q
            //              select q).Distinct();

            //foreach (var s in result)
            //    Console.WriteLine($"{s}");

            // let stuff, 1231
            //var result = from str in new List<string>() { "cat", "bat", "sat", "hat", "mat", "cat", "MAT", "hAt" }
            //                let label = char.ToUpper(str.First()) + str.Substring(1).ToLower()
            //                orderby label ascending
            //                select new
            //                {
            //                    Label = label,
            //                    Original = str,
            //                    Sum = str.ToLower().Sum(c => c)
            //                }
            //                into projected
            //                orderby projected.Sum
            //                select projected
            //                into orderedprojected
            //                group orderedprojected by orderedprojected.Label;

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category : {item.Key}: ");
            //    Console.WriteLine(string.Join(", ", item));
            //}

var result = from str in new List<string>()
    { "cat CAT CaT", "bat BAT baT", "MAT mAt mat" }
                let splitty = str.Split(new char[] { ' ' })
                from word in splitty
                orderby word
                select word;

Console.WriteLine(string.Join("::", result));

            //List<Widget> widgets = new List<Widget>();
            //widgets.Add(new Widget("Coke", 1, 20));
            //widgets.Add(new Widget("Diamond", 42000, 1));
            //widgets.Add(new Widget("Diet Coke", 1, 20));
            //widgets.Add(new Widget("Apple Juice", 1, 20));
            //widgets.Add(new Widget("KitKat", 1.25f, 56));

            //var items = from w in widgets orderby w._Price ascending, w._Name descending group w by w._Price;
            //foreach (var gp in items)
            //{
            //    Console.WriteLine("Items with price : " + gp.Key.ToString("f2"));
            //    foreach (var item in gp)
            //        Console.WriteLine("  " + item._Name + " : " + item._Price.ToString("f2"));
            //}

            //_bs.DataSource = items;


            //List<Supplier> sups = new List<Supplier>();
            //sups.Add(new Supplier("The Coka-Cola Company", 20));
            //sups.Add(new Supplier("Nestle", 56));
            //sups.Add(new Supplier("Mother Nature", 1));

            //var items = from w in widgets
            //            join s in sups on w._SupplierUNID equals s._UNID orderby w._Name
            //            select new { 
            //                WidgetName = w._Name,
            //                SupplierName = s._Name,
            //                WidgetPrice = w._Price
            //            };

            //foreach (var v in items)
            //    Console.WriteLine(
            //        v.WidgetName + " (" + 
            //        v.SupplierName + ") @ $" +         
            //        v.WidgetPrice.ToString("f2"));

            //Console.WriteLine(" ");
            //Console.WriteLine(" ");



            //int[] stuff = new int[] { 3, 5, 4, 0, 17, 21, 44 };

            //var result = from n in stuff where n > 0 select $"{(n * 1.05):f2}";
            //result.ToList().ForEach(q => Console.WriteLine(q));

            //var result = from n in stuff where n > 0 select new { Price = n, GST = n * 0.05 };

            //foreach (var x in result)
            //    Console.WriteLine($"{x.Price:f2}, {x.GST:f2}");


            //var result = from n in stuff where n < 10 select n;
            //stuff[0] = 100;
            //result.ToList().ForEach((o) => Console.Write($"{o} "));

            //            Console.WriteLine("");


            //var result = from n in stuff where n > 0 select new { Price = n, GST = n * 0.05 };
            //o.Price.ToString("f2") + ", " + o.GST.ToString("f2")));

            //Console.WriteLine(" ");
            //Console.WriteLine(" ");


            //(from n in nums where n % 2 == 0 orderby n select n).
            //    Distinct().
            //    Take(5).
            //    ToList().
            //    ForEach ((o) => Console.Write(o.ToString() + " "));

            //List<Widget> widgets = new List<Widget>();
            //widgets.Add(new Widget("Coke", 1));
            //widgets.Add(new Widget("Diamond", 42000));
            //widgets.Add(new Widget("Pepsi", 1));
            //widgets.Add(new Widget("KitKat", 1.25f));

            //// don't select, but group all
            //var items = from w in widgets group w by w._Price;

            //// each group will contain a key field - the group is also enumerable
            //foreach (var gp in items)
            //{
            //    Console.WriteLine($"Items with price : {gp.Key:f2}");
            //    foreach (var item in gp)
            //        Console.WriteLine($"  {item._Name} : {item._Price:f2}");
            //}

            //List<Widget> widgets = new List<Widget>();
            //widgets.Add(new Widget("Coke", 1, 20));
            //widgets.Add(new Widget("Diamond", 42000, 1));
            //widgets.Add(new Widget("Diet Coke", 1, 20));
            //widgets.Add(new Widget("Apple Juice", 1, 20));
            //widgets.Add(new Widget("KitKat", 1.25f, 56));

            //List<Supplier> sups = new List<Supplier>();
            //sups.Add(new Supplier("The Coka-Cola Company", 20));
            //sups.Add(new Supplier("Nestle", 56));
            //sups.Add(new Supplier("Mother Nature", 1));
            //sups.Add(new Supplier("All Alone", 42));

            //var items = from w in widgets
            //            join s in sups on w._SupplierUNID equals s._UNID // inner join
            //            orderby w._Name
            //            select new // create anonymous type for results (combine data)
            //            {
            //                WidgetName = w._Name,
            //                SupplierName = s._Name,
            //                WidgetPrice = w._Price
            //            };

            //            Console.WriteLine(items);

            //foreach (var v in items)
            //    Console.WriteLine($"{v.WidgetName} ({v.SupplierName}) @ ${v.WidgetPrice:f2}");
            //        }
            //    }

            //    public class Widget
            //    {
            //        public string _Name;
            //        public float _Price;
            //        public int _SupplierUNID;

            //        public Widget(string name, float price, int supplierUNID)
            //        {
            //            _Name = name.Trim();
            //            _Price = price;
            //            _SupplierUNID = supplierUNID;
            //        }
            //    }

            //public class Widget
            //{
            //    public string _Name;
            //    public float _Price;

            //    public Widget(string name, float price)
            //    {
            //        _Name = name.Trim();
            //        _Price = price;
            //    }
            //}
        }

        public class Supplier
        {
            public string _Name;
            public int _UNID;

            public Supplier(string name, int UNID)
            {
                _Name = name;
                _UNID = UNID;
            }
        }
    }
}
