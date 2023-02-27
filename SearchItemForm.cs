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
    public partial class SearchItemForm : Form
    {
        public SearchItemForm()
        {
            InitializeComponent();
            itemsGridView.DefaultCellStyle.Font = new Font("Tahoma", 13);
            itemsGridView.RowTemplate.Height = 35;

            try
            {
                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Branches";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        branchComboBox.DataSource = null;
                        branchComboBox.Items.Clear();
                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "BranchId";
                        dt.Columns.Add().ColumnName = "BranchName";

                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["BranchId"] = reader["BranchId"].ToString();
                            row["BranchName"] = reader["BranchName"].ToString();
                            dt.Rows.InsertAt(row, 0);
                        }

                        branchComboBox.DataSource = dt;
                        branchComboBox.DisplayMember = "BranchName";
                        branchComboBox.ValueMember = "BranchId";
                        branchComboBox.SelectedItem = null;
                        branchComboBox.Text = "";
                    }
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    search();
                }
            }
            catch {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }

        void search()
        {
            try
            {
                string searchText = searchTextBox.Text;
                    itemsGridView.Rows.Clear();
                    using (SqlConnection conn = Connection.GetDataConnection())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                    if (searchText.Trim() != "")
                        cmd.CommandText = "SELECT * FROM QMTS WHERE Qty > 0 AND Barcode LIKE '%" + searchText + "%'";
                    else
                        cmd.CommandText = "SELECT * FROM QMTS WHERE Qty > 0 ";
                        colorCheckBox.Checked = false;
                        sizeCheckBox.Checked = false;
                        filterBranchCheckBox.Checked = false;

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            itemsGridView.RowCount = 1000;
                            int currentRow = 0;
                            while (reader.Read())
                            {
                                itemsGridView.Rows[currentRow].HeaderCell.Value = currentRow.ToString();
                                itemsGridView.Rows[currentRow].Cells[0].Value = reader["BranchName"].ToString();
                                itemsGridView.Rows[currentRow].Cells[1].Value = reader["Barcode"].ToString();
                                itemsGridView.Rows[currentRow].Cells[2].Value = reader["ComputerNo"].ToString();
                                itemsGridView.Rows[currentRow].Cells[3].Value = reader["ColorEName"].ToString();
                                itemsGridView.Rows[currentRow].Cells[4].Value = reader["SizeName"].ToString();
                                itemsGridView.Rows[currentRow].Cells[5].Value = reader["Qty"].ToString();
                                currentRow += 1;
                            }
                            conn.Close();


                            conn.Open();
                            cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = System.Data.CommandType.Text;
                            if ((branchComboBox.Text != "") && (filterBranchCheckBox.Checked))
                                cmd.CommandText = "SELECT distinct ColorId, ColorEName FROM QMTS WHERE BranchId = '" + branchComboBox.SelectedValue.ToString() + "' AND Qty > 0 AND Barcode LIKE '%" + searchText + "%'";
                            else
                                cmd.CommandText = "SELECT distinct ColorId, ColorEName FROM QMTS WHERE Qty > 0 AND Barcode LIKE '%" + searchText + "%'";
                            reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                colorComboBox.DataSource = null;
                                colorComboBox.Items.Clear();
                                DataTable dt = new DataTable();
                                dt.Columns.Add().ColumnName = "ColorId";
                                dt.Columns.Add().ColumnName = "ColorEName";

                                while (reader.Read())
                                {
                                    DataRow row = dt.NewRow();
                                    row["ColorId"] = reader["ColorId"].ToString();
                                    row["ColorEName"] = reader["ColorEName"].ToString();
                                    dt.Rows.InsertAt(row, 0);
                                }

                                colorComboBox.DataSource = dt;
                                colorComboBox.DisplayMember = "ColorEName";
                                colorComboBox.ValueMember = "ColorId";
                                colorComboBox.SelectedItem = null;
                                colorComboBox.Text = "";
                        }

                        conn.Close();



                            conn.Open();
                            cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = System.Data.CommandType.Text;
                            if ((branchComboBox.Text != "") && (filterBranchCheckBox.Checked))
                                cmd.CommandText = "SELECT distinct SizeId, SizeName FROM QMTS WHERE BranchId = '" + branchComboBox.SelectedValue.ToString() + "' AND Qty > 0 AND Barcode LIKE '%" + searchText + "%'";
                            else
                                cmd.CommandText = "SELECT distinct SizeId, SizeName FROM QMTS WHERE Qty > 0 AND Barcode LIKE '%" + searchText + "%'";
                            reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                sizeComboBox.DataSource = null;
                                sizeComboBox.Items.Clear();
                                DataTable dt = new DataTable();
                                dt.Columns.Add().ColumnName = "SizeId";
                                dt.Columns.Add().ColumnName = "SizeName";

                                while (reader.Read())
                                {
                                    DataRow row = dt.NewRow();
                                    row["SizeId"] = reader["SizeId"].ToString();
                                    row["SizeName"] = reader["SizeName"].ToString();
                                    dt.Rows.InsertAt(row, 0);
                                }

                                sizeComboBox.DataSource = dt;
                                sizeComboBox.DisplayMember = "SizeName";
                                sizeComboBox.ValueMember = "SizeId";
                                sizeComboBox.SelectedItem = null;
                                sizeComboBox.Text = "";

                        }

                        conn.Close();
                        }
                        else
                        {
                            itemsGridView.Rows.Clear();
                            itemsGridView.RowCount = 100;
                            conn.Close();
                        }

                    }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = searchTextBox.Text;
                    itemsGridView.Rows.Clear();
                    using (SqlConnection conn = Connection.GetDataConnection())
                    {
                        string filter = "";
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        if ((branchComboBox.Text != "") && (filterBranchCheckBox.Checked))
                            filter = filter + " BranchId = '" + branchComboBox.SelectedValue.ToString() + "' AND ";

                        if ((colorComboBox.Text != "") && (colorCheckBox.Checked))
                            filter = filter + " ColorId = '" + colorComboBox.SelectedValue.ToString() + "' AND ";

                        if ((sizeComboBox.Text != "") && (sizeCheckBox.Checked))
                            filter = filter + " SizeId = '" + sizeComboBox.SelectedValue.ToString() + "' AND ";

                        if (searchText.Trim() != "")
                            cmd.CommandText = "SELECT * FROM QMTS WHERE " + filter + " Qty > 0 AND Barcode LIKE '%" + searchText + "%'";
                        else
                            cmd.CommandText = "SELECT * FROM QMTS WHERE " + filter + " Qty > 0";

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            itemsGridView.RowCount = 1000;
                            int currentRow = 0;
                            while (reader.Read())
                            {
                                itemsGridView.Rows[currentRow].HeaderCell.Value = currentRow.ToString();
                                itemsGridView.Rows[currentRow].Cells[0].Value = reader["BranchName"].ToString();
                                itemsGridView.Rows[currentRow].Cells[1].Value = reader["Barcode"].ToString();
                                itemsGridView.Rows[currentRow].Cells[2].Value = reader["ComputerNo"].ToString();
                                itemsGridView.Rows[currentRow].Cells[3].Value = reader["ColorEName"].ToString();
                                itemsGridView.Rows[currentRow].Cells[4].Value = reader["SizeName"].ToString();
                                itemsGridView.Rows[currentRow].Cells[5].Value = reader["Qty"].ToString();
                                currentRow += 1;
                            }
                            conn.Close();
                        }
                    }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }

        private void itemsGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string value = itemsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            Clipboard.SetText(value);
        }
    }
}
