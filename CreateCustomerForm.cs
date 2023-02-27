using POSSystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class createCustomerForm : Form
    {
        public string name;
        public string id;

        public void fillCustomerNumber(string phone)
        {
            customerPhoneTextBox.Text = phone;
        }

        public createCustomerForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT MAX(CAST(CustomerId AS INT))+1 AS CustomerId FROM PosCustomers";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        id = reader["CustomerId"].ToString();
                    }
                    else
                        id = "1";
                    conn.Close();
                }

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO PosCustomers(CustomerId, CustomerName, MobilePhone, RegBr) VALUES('" + id + "', '" + customerNameTextBox.Text + "','" + customerPhoneTextBox.Text + "','" + Settings.getSetting("branchId") + "')";
                    cmd.ExecuteNonQuery();
                    name = customerNameTextBox.Text;
                    conn.Close();
                    MessageBox.Show("تم إضافة العميل بنجاح");
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }
    }
}
