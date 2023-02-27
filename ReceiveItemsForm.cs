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
    public partial class receiveItemsForm : Form
    {
        int totalReceived = 0;
        public receiveItemsForm()
        {
            InitializeComponent();
            itemsGridView.DefaultCellStyle.Font = new Font("Tahoma", 15);
            dataGrid.DefaultCellStyle.Font = new Font("Tahoma", 15);
            dataGrid.RowTemplate.Height = 35;
            itemsGridView.RowTemplate.Height = 35;
            receiveItems();
        }

        private void receiveItemsForm_Load(object sender, EventArgs e)
        {

        }

        private void receiveItems()
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
                    cmd.CommandText = "SELECT * FROM QDTI WHERE ReceivingBy IS NULL and To_Br = '" + Settings.getSetting("branchId") + "'";
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        dataGrid.RowCount = 100;
                        int currentRow = 0;
                        while (reader.Read())
                        {
                            dataGrid.Rows[currentRow].Cells[0].Value = reader["BLNO"].ToString();
                            dataGrid.Rows[currentRow].Cells[1].Value = reader["From_BranchName"].ToString();
                            dataGrid.Rows[currentRow].Cells[2].Value = reader["TotalQty"].ToString();
                            dataGrid.Rows[currentRow].Cells[3].Value = Convert.ToDateTime(reader["BLDate"].ToString()).ToString("yyyy-MM-dd");

                            currentRow += 1;
                        }
                    }
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }

        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGrid.SelectedRows[0].Cells[0].Value != null)
                {
                    countLbl.Text = "0";
                    totalReceived = 0;
                    string blno = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                    itemsGridView.Rows.Clear();
                    using (SqlConnection conn = Connection.GetDataConnection())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandTimeout = 60000;
                        cmd.CommandText = "SELECT * FROM QDTD WHERE BLNO = '" + blno + "'";
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            itemsGridView.RowCount = 1000;
                            int currentRow = 0;
                            while (reader.Read())
                            {
                                itemsGridView.Rows[currentRow].Cells[0].Value = reader["Barcode"].ToString();
                                itemsGridView.Rows[currentRow].Cells[1].Value = reader["ComputerNo"].ToString();
                                itemsGridView.Rows[currentRow].Cells[2].Value = reader["ColorEName"].ToString();
                                itemsGridView.Rows[currentRow].Cells[3].Value = reader["SizeName"].ToString();
                                itemsGridView.Rows[currentRow].Cells[4].Value = reader["Qty"].ToString();
                                itemsGridView.Rows[currentRow].Cells[5].Value = "0";
                                currentRow += 1;
                            }
                        }
                        conn.Close();
                    }
                }
                else
                {
                    itemsGridView.Rows.Clear();
                }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (checkTextBox.Text != "")
                    {
                        foreach (DataGridViewRow r in itemsGridView.Rows)
                        {
                            if (r.Cells[0].Value != null)
                            {
                                int receivedQty = Convert.ToInt32(r.Cells[5].Value.ToString());
                                receivedQty = receivedQty + 1;
                                if ((r.Cells[0].Value.ToString().ToLower() == checkTextBox.Text.ToLower()) && (receivedQty.ToString() == r.Cells[4].Value.ToString()))
                                {
                                    r.Cells[0].Style.BackColor = Color.Green;
                                    r.Cells[1].Style.BackColor = Color.Green;
                                    r.Cells[2].Style.BackColor = Color.Green;
                                    r.Cells[3].Style.BackColor = Color.Green;
                                    r.Cells[4].Style.BackColor = Color.Green;
                                    r.Cells[5].Style.BackColor = Color.Green;
                                    r.Cells[5].Value = receivedQty.ToString();
                                    checkTextBox.Text = "";
                                    totalReceived = totalReceived + 1;
                                    countLbl.Text = totalReceived.ToString();
                                }
                                else
                                {
                                    if ((r.Cells[0].Value.ToString().ToLower() == checkTextBox.Text.ToLower()) && (receivedQty.ToString() != r.Cells[4].Value.ToString()))
                                    {
                                        r.Cells[0].Style.BackColor = Color.Yellow;
                                        r.Cells[1].Style.BackColor = Color.Yellow;
                                        r.Cells[2].Style.BackColor = Color.Yellow;
                                        r.Cells[3].Style.BackColor = Color.Yellow;
                                        r.Cells[4].Style.BackColor = Color.Yellow;
                                        r.Cells[5].Style.BackColor = Color.Yellow;
                                        r.Cells[5].Value = receivedQty.ToString();
                                        checkTextBox.Text = "";
                                        totalReceived = totalReceived + 1;
                                        countLbl.Text = totalReceived.ToString();
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
                }
            }
        }

        private void receiveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool valid = true;
                foreach (DataGridViewRow r in itemsGridView.Rows)
                {
                    if (r.Cells[0].Value != null)
                    {
                        if ((r.Cells[0].Style.BackColor != Color.Green))
                        {
                            valid = false;
                            if (r.Cells[0].Style.BackColor != Color.Yellow)
                            {
                                r.Cells[0].Style.BackColor = Color.Red;
                                r.Cells[1].Style.BackColor = Color.Red;
                                r.Cells[2].Style.BackColor = Color.Red;
                                r.Cells[3].Style.BackColor = Color.Red;
                                r.Cells[4].Style.BackColor = Color.Red;
                                r.Cells[5].Style.BackColor = Color.Red;
                            }
                        }
                    }
                } 

                if (valid)
                {
                    if (dataGrid.SelectedRows[0].Cells[0].Value != null)
                    {
                        string blno = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                        int idx = dataGrid.SelectedRows[0].Index;

                        using (SqlConnection conn = Connection.GetDataConnection())
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.CommandTimeout = 60000;
                            cmd.CommandText = "UPDATE DTI SET RDate = '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")+".000" + "', QPost = 1, ReceivingBy = '" + Settings.getSetting("userId") + "', PostedBy = '" + Settings.getSetting("user") + "' WHERE BLNO = '" + blno + "'";
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            dataGrid.Rows.RemoveAt(idx);
                            MessageBox.Show("تم الإستلام بنجاح");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("يوجد أصناف غير مطابقة");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة "+er.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGrid.SelectedRows[0].Cells[0].Value != null)
                {
                    string blno = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                    int idx = dataGrid.SelectedRows[0].Index;

                    using (SqlConnection conn = Connection.GetDataConnection())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandTimeout = 60000;
                        cmd.CommandText = "UPDATE DTI SET RDate = '" + DateTime.Now.ToString() + "', QPost = 1, ReceivingBy = '" + Settings.getSetting("userId") + "', PostedBy = '" + Settings.getSetting("user") + "' WHERE BLNO = '" + blno + "'";
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        dataGrid.Rows.RemoveAt(idx);
                        MessageBox.Show("تم الإستلام بنجاح");
                    }
                }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }
    }
}
