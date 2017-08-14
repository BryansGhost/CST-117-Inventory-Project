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
    public partial class PasswordUI : Form
    {
        public PasswordUI()
        {
            InitializeComponent();
        }

        //Button Takes you back to the main menu 
        private void BackButton_Click(object sender, EventArgs e)
        {
            MenuUI MenuUIForm = new MenuUI();
            MenuUIForm.Show();
            this.Hide();
        }

        //Button will check password list 
        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (UserNameBox.Text == "Admin") //Default for testing
            {
                if (PasswordBox.Text == "Password1") // Default for testing
                {
                    new TESTFORM().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect!");
                }
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!");
            }
        }
    }
}
