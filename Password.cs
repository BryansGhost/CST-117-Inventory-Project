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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //This loads a MS Access .mdb dataset of usernames and passwords that were copied into the program
        private void Password_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryPasswordSQLdocDataSet.PasswordList' table. You can move, or remove it, as needed.
            this.passwordListTableAdapter.Fill(this.inventoryPasswordSQLdocDataSet.PasswordList);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuUI MenuForm = new MenuUI();
            MenuForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //This button will check the password 
        private void LogInButton_Click(object sender, EventArgs e)
        {

        }
    }
}
