using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117___Inventory_Project
{
    public partial class TESTFORM : Form
    {
        public TESTFORM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuUI Menu = new MenuUI();
            Menu.Show();
            this.Hide();

        }
    }
}
