using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibWithDlgDemoMar11_2025
{
    public partial class DlgConnect : Form
    {
        public DlgConnect(
            bool bAddrEdit,
            bool bPortEdit,
            string defAddr = "www.microsoft.com",
            UInt16 defPort = 1666)
        {
            InitializeComponent();
        }
    }
}
