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
    public partial class inventoryPage : Form
    {
        public inventoryPage()
        {
            InitializeComponent();
        }

        private void inventoryPage_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            string itemsBought = itemToBuy.Text.ToString();

            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=SrivalliLaptop\SQL;Initial Catalog=CMPS480_Final;Persist Security Info=True;User ID=sriv1;Password=hello123");
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "SELECT how_many FROM inventory WHERE item_name = @itemName";
            cmd.Parameters.AddWithValue("@itemName", itemsBought);

            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            object result = cmd.ExecuteScalar();

            int count = result != null ? Convert.ToInt32(result) : 0;

            sqlConnection1.Close();

            textBoz.Text = "For " + itemToBuy.Text + " there are " + count.ToString() + " left";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            homePage hr = new homePage();
            hr.Show();
            this.Close();
        }
    }
}
