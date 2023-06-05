using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace fianlProject
{
    public partial class contactPage : Form
    {
        public contactPage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            homePage hp = new homePage();
            hp.Show();
            this.Hide();
        }

        private void submitBtn_Click(object sender, EventArgs e){
            string name = nameText.Text.ToString();
            string email = emailText.Text.ToString();
            string mess = messageTxt.Text.ToString();
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=SrivalliLaptop\SQL;Initial Catalog=CMPS480_Final;Persist Security Info=True;User ID=sriv1;Password=hello123");
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "INSERT INTO contact_page_table (name, email, user_message) VALUES ('" + name + "', '" + email + "', '" + mess + "')";



            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            cmd.ExecuteNonQuery();

            sqlConnection1.Close();
        }
    }
}
