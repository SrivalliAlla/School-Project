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
    public partial class returnPage : Form
    {
        public returnPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e) {
            string item = itemToBuy.Text.ToString();
            string email = usersEmail.Text.ToString();
            int howMany = Convert.ToInt32(howManyAnswer.Text);

            int price = 0;

            if (item == "Coke")
            {
                price = howMany * 3;
            }
            if (item == "Diet Coke")
            {
                price = howMany * 3;
            }
            if (item == "Sprite")
            {
                price = howMany * 3;
            }
            if (item == "Dr. Pepper")
            {
                price = howMany * 3;
            }
            if (item == "7-Up")
            {
                price = howMany * 3;
            }
            if (item == "Bottle Water")
            {
                price = howMany * 2;
            }
            if (item == "Iced Tea")
            {
                price = howMany * 4;
            }
            if (item == "Iced Cream")
            {
                price = howMany * 3;
            }

            try
            {
                System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=SrivalliLaptop\SQL;Initial Catalog=CMPS480_Final;Persist Security Info=True;User ID=sriv1;Password=hello123");
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.CommandText = "SELECT how_many_to_buy FROM purchase_table WHERE email = '" + email + "'";
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                int boughtHowMany = Convert.ToInt32(cmd.ExecuteScalar());
                sqlConnection1.Close();

                if (boughtHowMany >= howMany)
                {
                    cmd.CommandText = "INSERT INTO return_table (item_name, how_many_to_return, email) VALUES ('" + item + "', '" + howMany + "', '" + email + "')";

                    hugeTextBox.Text = "You returned: " + item + " and number of those item is: " + howMany;

                    cmd.Connection = sqlConnection1;

                    sqlConnection1.Open();

                    cmd.ExecuteNonQuery();
                    sqlConnection1.Close();
                }
                else
                {
                    hugeTextBox.Text = "You only bought " + boughtHowMany + " it is immpossible to return more than that. try again";
                }
                cmd.CommandText = "SELECT how_many FROM inventory WHERE item_name = '" + item + "'";
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();

                int currentHowMany = (int)cmd.ExecuteScalar();
                cmd.CommandText = "UPDATE inventory SET how_many = how_many + " + (howMany) + " WHERE item_name = '" + item + "'";
                cmd.ExecuteNonQuery();

                sqlConnection1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("an error occured. was unable to return the item(s)");
            }
        }


        private void returnPage_Load(object sender, EventArgs e) {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            homePage hp = new homePage();
            hp.Show();
            this.Close();
        }
    }
}
