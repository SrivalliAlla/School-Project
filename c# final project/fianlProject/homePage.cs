using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fianlProject
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            purchasePage myNewForm = new purchasePage();
            myNewForm.Show();
            this.Hide();
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            inventoryPage myNewForm = new inventoryPage();
            myNewForm.Show();
            this.Hide();
        }

        private void contactBtn_Click(object sender, EventArgs e)
        {
            contactPage myNewForm = new contactPage();
            myNewForm.Show();
            this.Hide();
        }

        private void createAccountBttn_Click(object sender, EventArgs e)
        {
            createAccount myNewForm = new createAccount();
            myNewForm.Show();
            this.Hide();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            returnPage mynewform = new returnPage();
            mynewform.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
