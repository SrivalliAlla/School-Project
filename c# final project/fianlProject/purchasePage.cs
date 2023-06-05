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
using System.Xml.Linq;

namespace fianlProject
{
    public partial class purchasePage : Form
    {
        public purchasePage()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void finishButton_Click(object sender, EventArgs e)
        {
            string item = itemToBuy.Text.ToString();
            string email = usersEmail.Text.ToString();
            int howMany = Convert.ToInt32(howManyTxt.Text);

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

                cmd.CommandText = "SELECT how_many FROM inventory WHERE item_name = '" + item + "'";
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                int currentHowMany = Convert.ToInt32(cmd.ExecuteScalar());
                sqlConnection1.Close();

                if (currentHowMany >= howMany){
                    cmd.CommandText = "INSERT INTO purchase_table (item_name, how_many_to_buy, email, money_spent) VALUES ('" + item + "', '" + howMany + "', '" + email + "', '" + price + "')";
                    cmd.Connection = sqlConnection1;
                    hugeTextBox.Text = "You bought: " + item + " and number of those item is: " + howMany;
                }
                else                {
                    hugeTextBox.Text = "The order did not go through, there is not enough " + item + " in inventory. Check inventory before buying: ";
                }



                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();

                sqlConnection1.Open();
                cmd.CommandText = "UPDATE inventory SET how_many = how_many - " + (howMany) + " WHERE item_name = '" + item + "'";
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred unable to purchase that item(s). please try again");
            }


        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            homePage hr = new homePage();
            hr.Show();
            this.Hide();
        }
    }
}
