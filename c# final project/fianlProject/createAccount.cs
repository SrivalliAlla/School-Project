using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fianlProject
{
    public partial class createAccount : Form
    {
        public createAccount()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string userName = nameText.Text;
            string number = numberTxt.Text.ToString();
            string email = emailText.Text;
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=SrivalliLaptop\SQL;Initial Catalog=CMPS480_Final;Persist Security Info=True;User ID=sriv1;Password=hello123");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "INSERT INTO create_account (name, number, email) VALUES ('" + userName + "', '" + number + "', '" + email + "')";

            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            cmd.ExecuteNonQuery();

            sqlConnection1.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            homePage hp = new homePage();
            hp.Show();
            this.Close();
        }
    }
}
