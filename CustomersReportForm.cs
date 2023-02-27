using POSSystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class CustomersReportForm : Form
    {
        public CustomersReportForm()
        {
            InitializeComponent();
            dataGrid.RowTemplate.Height = 35;
            dataGrid.DefaultCellStyle.Font = new Font("Tahoma", 13);
            try
            {

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM POSCustomers WHERE RegBr = '" + Settings.getSetting("branchId") + "'";
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        dataGrid.RowCount = 5000;
                        int currentRow = 0;
                        while (reader.Read())
                        {
                            dataGrid.Rows[currentRow].Cells[0].Value = reader["CustomerName"].ToString();
                            dataGrid.Rows[currentRow].Cells[1].Value = reader["MobilePhone"].ToString();
                            currentRow += 1;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة "+er.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
