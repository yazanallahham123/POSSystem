using POSSystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();

            try
            {
                sqlServerTextBox.Text = Settings.getSetting("server");
                sqlUserTextBox.Text = Settings.getSetting("serverUser");
                sqlPasswordTextBox.Text = Settings.getSetting("serverPassword");
                databaseComboBox.Text = Settings.getSetting("database");

                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    printersComboBox.DataSource = null;
                    printersComboBox.Items.Clear();
                    printersComboBox.Items.Add(printer);
                }

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM sys.databases";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        databaseComboBox.DataSource = null;
                        databaseComboBox.Items.Clear();
                        while (reader.Read())
                        {
                            databaseComboBox.Items.Add(reader["name"].ToString());
                        }
                    }
                    conn.Close();
                }

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
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
                    }
                    conn.Close();
                }


                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM BSR WHERE BSTID = 4";
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        dtiComboBox.DataSource = null;
                        dtiComboBox.Items.Clear();

                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "BLID";
                        dt.Columns.Add().ColumnName = "ArName";

                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["BLID"] = reader["BLID"].ToString();
                            row["ArName"] = reader["ArName"].ToString();
                            dt.Rows.InsertAt(row, 0);
                        }

                        dtiComboBox.DataSource = dt;
                        dtiComboBox.DisplayMember = "ArName";
                        dtiComboBox.ValueMember = "BLID";
                    }
                    conn.Close();
                }

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM BSR WHERE BSTID = 5";
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        bliComboBox.DataSource = null;
                        bliComboBox.Items.Clear();

                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "BLID";
                        dt.Columns.Add().ColumnName = "ArName";
                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["BLID"] = reader["BLID"].ToString();
                            row["ArName"] = reader["ArName"].ToString();
                            dt.Rows.InsertAt(row, 0);
                        }

                        bliComboBox.DataSource = dt;
                        bliComboBox.DisplayMember = "ArName";
                        bliComboBox.ValueMember = "BLID";
                    }
                    conn.Close();
                }

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM USI";
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        userComboBox.DataSource = null;
                        userComboBox.Items.Clear();

                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "USID";
                        dt.Columns.Add().ColumnName = "UsName";
                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["USID"] = reader["USID"].ToString();
                            row["UsName"] = reader["UsName"].ToString();
                            dt.Rows.InsertAt(row, 0);
                        }

                        userComboBox.DataSource = dt;
                        userComboBox.DisplayMember = "UsName";
                        userComboBox.ValueMember = "USID";
                    }
                    conn.Close();
                }


                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM AdditionallPrices";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        additionallPricesComboBox.DataSource = null;
                        additionallPricesComboBox.Items.Clear();

                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "PriceId";
                        dt.Columns.Add().ColumnName = "PriceName";

                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["PriceId"] = reader["PriceID"].ToString();
                            row["PriceName"] = reader["PriceName"].ToString();
                            dt.Rows.InsertAt(row, 0);
                        }

                        additionallPricesComboBox.DataSource = dt;
                        additionallPricesComboBox.DisplayMember = "PriceName";
                        additionallPricesComboBox.ValueMember = "PriceId";
                    }
                    conn.Close();
                }

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM Currencies";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        currencyComboBox.DataSource = null;
                        currencyComboBox.Items.Clear();
                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "CurrencyId";
                        dt.Columns.Add().ColumnName = "CurrencyName";

                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["CurrencyId"] = reader["CurrencyID"].ToString();
                            row["CurrencyName"] = reader["CurrencyName"].ToString();
                            dt.Rows.InsertAt(row, 0);
                        }

                        currencyComboBox.DataSource = dt;
                        currencyComboBox.DisplayMember = "CurrencyName";
                        currencyComboBox.ValueMember = "CurrencyId";
                    }
                    conn.Close();
                }


                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM EmployeeAff";
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {

                        salesManComboBox.DataSource = null;
                        salesManComboBox.Items.Clear();

                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "EmpID";
                        dt.Columns.Add().ColumnName = "EmpName1";
                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["EmpID"] = reader["EmpID"].ToString();
                            row["EmpName1"] = reader["EmpName1"].ToString();
                            dt.Rows.InsertAt(row, 0);
                        }

                        salesManComboBox.DataSource = dt;
                        salesManComboBox.DisplayMember = "EmpName1";
                        salesManComboBox.ValueMember = "EmpID";
                    }
                    conn.Close();
                }

                printersComboBox.Text = Settings.getSetting("printer");

                branchComboBox.Text = Settings.getSetting("branch");
                branchComboBox.SelectedValue = Settings.getSetting("branchId");

                bliComboBox.Text = Settings.getSetting("bli");
                bliComboBox.SelectedValue = Settings.getSetting("bliId");

                dtiComboBox.Text = Settings.getSetting("dti");
                dtiComboBox.SelectedValue = Settings.getSetting("dtiId");

                userComboBox.Text = Settings.getSetting("user");
                userComboBox.SelectedValue = Settings.getSetting("userId");

                salesManComboBox.Text = Settings.getSetting("salesMan");
                salesManComboBox.SelectedValue = Settings.getSetting("salesManId");

                currencyComboBox.Text = Settings.getSetting("currency");
                currencyComboBox.SelectedValue = Settings.getSetting("currencyId");

                additionallPricesComboBox.Text = Settings.getSetting("additionallPrice");
                additionallPricesComboBox.SelectedValue = Settings.getSetting("additionallPriceId");

                if (Settings.getSetting("isAdditionallPrice") == "true")
                    additionallPricesCheckBox.Checked = true;
                else
                    additionallPricesCheckBox.Checked = false;


                if (Settings.getSetting("priceType") == "endUser")
                {
                    endUserRadioButton.Checked = true;
                    saleRadioButton.Checked = false;
                    clearanceRadioButton.Checked = false;
                    specialRadioButton.Checked = false;
                }
                else
                {
                    if (Settings.getSetting("priceType") == "sale")
                    {
                        endUserRadioButton.Checked = false;
                        saleRadioButton.Checked = true;
                        clearanceRadioButton.Checked = false;
                        specialRadioButton.Checked = false;
                    }
                    else
                    {
                        if (Settings.getSetting("priceType") == "clearance")
                        {
                            endUserRadioButton.Checked = false;
                            saleRadioButton.Checked = false;
                            clearanceRadioButton.Checked = true;
                            specialRadioButton.Checked = false;
                        }
                        else
                        if (Settings.getSetting("priceType") == "special")
                        {
                            endUserRadioButton.Checked = false;
                            saleRadioButton.Checked = false;
                            clearanceRadioButton.Checked = false;
                            specialRadioButton.Checked = true;
                        }

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية حفظ الإعدادات" + " " + ex.Message);
            }

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {

                Settings.saveSetting("server", sqlServerTextBox.Text);
                Settings.saveSetting("serverUser", sqlUserTextBox.Text);
                Settings.saveSetting("serverPassword", sqlPasswordTextBox.Text);
                Settings.saveSetting("database", databaseComboBox.Text);

                Settings.saveSetting("printer", printersComboBox.Text);

                Settings.saveSetting("branch", branchComboBox.Text);
                Settings.saveSetting("branchId", branchComboBox.SelectedValue.ToString());

                Settings.saveSetting("bli", bliComboBox.Text);
                Settings.saveSetting("bliId", bliComboBox.SelectedValue.ToString());

                Settings.saveSetting("dti", dtiComboBox.Text);
                Settings.saveSetting("dtiId", dtiComboBox.SelectedValue.ToString());

                Settings.saveSetting("user", userComboBox.Text);
                Settings.saveSetting("userId", userComboBox.SelectedValue.ToString());

                Settings.saveSetting("salesMan", salesManComboBox.Text);
                Settings.saveSetting("salesManId", salesManComboBox.SelectedValue.ToString());

                Settings.saveSetting("currency", currencyComboBox.Text);
                Settings.saveSetting("currencyId", currencyComboBox.SelectedValue.ToString());

                Settings.saveSetting("additionallPrice", additionallPricesComboBox.Text);
                Settings.saveSetting("additionallPriceId", additionallPricesComboBox.SelectedValue.ToString());

                if (additionallPricesCheckBox.Checked)
                    Settings.saveSetting("isAdditionallPrice", "true");
                else
                    Settings.saveSetting("isAdditionallPrice", "false");


                if (endUserRadioButton.Checked)
                    Settings.saveSetting("priceType", "endUser");
                else
                    if (saleRadioButton.Checked)
                    Settings.saveSetting("priceType", "sale");
                else
                        if (clearanceRadioButton.Checked)
                    Settings.saveSetting("priceType", "clearance");
                else
                            if (specialRadioButton.Checked)
                    Settings.saveSetting("priceType", "special");


                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية حفظ الإعدادات" + " " + ex.Message);
            }
        }



        private void testConnectionButton_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void loadDatabasesButton_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.saveSetting("server", sqlServerTextBox.Text);
                Settings.saveSetting("serverUser", sqlUserTextBox.Text);
                Settings.saveSetting("serverPassword", sqlPasswordTextBox.Text);


                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT * FROM sys.databases";
                    cmd.CommandTimeout = 60000;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        databaseComboBox.DataSource = null;
                        databaseComboBox.Items.Clear();

                        while (reader.Read())
                        {
                            databaseComboBox.Items.Add(reader["name"].ToString());
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية حفظ الإعدادات" + " " + ex.Message);
            }
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {

        }

        private void currencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.saveSetting("server", sqlServerTextBox.Text);
                Settings.saveSetting("serverUser", sqlUserTextBox.Text);
                Settings.saveSetting("serverPassword", sqlPasswordTextBox.Text);
                Settings.saveSetting("database", databaseComboBox.Text);


                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    printersComboBox.Items.Clear();
                    printersComboBox.Items.Add(printer);
                }

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM sys.databases";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        databaseComboBox.Items.Clear();
                        while (reader.Read())
                        {
                            databaseComboBox.Items.Add(reader["name"].ToString());
                        }
                    }
                    conn.Close();
                }

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
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
                    }
                    conn.Close();
                }


                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM BSR WHERE BSTID = 4";
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        dtiComboBox.DataSource = null;
                        dtiComboBox.Items.Clear();

                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "BLID";
                        dt.Columns.Add().ColumnName = "ArName";

                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["BLID"] = reader["BLID"].ToString();
                            row["ArName"] = reader["ArName"].ToString();
                            dt.Rows.InsertAt(row, 0);
                        }

                        dtiComboBox.DataSource = dt;
                        dtiComboBox.DisplayMember = "ArName";
                        dtiComboBox.ValueMember = "BLID";
                    }
                    conn.Close();
                }

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM BSR WHERE BSTID = 5";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        bliComboBox.DataSource = null;
                        bliComboBox.Items.Clear();

                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "BLID";
                        dt.Columns.Add().ColumnName = "ArName";
                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["BLID"] = reader["BLID"].ToString();
                            row["ArName"] = reader["ArName"].ToString();
                            dt.Rows.InsertAt(row, 0);
                        }

                        bliComboBox.DataSource = dt;
                        bliComboBox.DisplayMember = "ArName";
                        bliComboBox.ValueMember = "BLID";
                    }
                    conn.Close();
                }

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM USI";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        userComboBox.DataSource = null;
                        userComboBox.Items.Clear();

                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "USID";
                        dt.Columns.Add().ColumnName = "UsName";
                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["USID"] = reader["USID"].ToString();
                            row["UsName"] = reader["UsName"].ToString();
                            dt.Rows.InsertAt(row, 0);
                        }

                        userComboBox.DataSource = dt;
                        userComboBox.DisplayMember = "UsName";
                        userComboBox.ValueMember = "USID";
                    }
                    conn.Close();
                }


                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM AdditionallPrices";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        additionallPricesComboBox.DataSource = null;
                        additionallPricesComboBox.Items.Clear();

                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "PriceId";
                        dt.Columns.Add().ColumnName = "PriceName";

                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["PriceId"] = reader["PriceID"].ToString();
                            row["PriceName"] = reader["PriceName"].ToString();
                            dt.Rows.InsertAt(row, 0);
                        }

                        additionallPricesComboBox.DataSource = dt;
                        additionallPricesComboBox.DisplayMember = "PriceName";
                        additionallPricesComboBox.ValueMember = "PriceId";
                    }
                    conn.Close();
                }

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM Currencies";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        currencyComboBox.DataSource = null;
                        currencyComboBox.Items.Clear();
                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "CurrencyId";
                        dt.Columns.Add().ColumnName = "CurrencyName";

                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["CurrencyId"] = reader["CurrencyID"].ToString();
                            row["CurrencyName"] = reader["CurrencyName"].ToString();
                            dt.Rows.InsertAt(row, 0);
                        }

                        currencyComboBox.DataSource = dt;
                        currencyComboBox.DisplayMember = "CurrencyName";
                        currencyComboBox.ValueMember = "CurrencyId";
                    }
                    conn.Close();
                }


                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 60000;
                    cmd.CommandText = "SELECT * FROM EmployeeAff";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {

                        salesManComboBox.DataSource = null;
                        salesManComboBox.Items.Clear();

                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "EmpID";
                        dt.Columns.Add().ColumnName = "EmpName1";
                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["EmpID"] = reader["EmpID"].ToString();
                            row["EmpName1"] = reader["EmpName1"].ToString();
                            dt.Rows.InsertAt(row, 0);
                        }

                        salesManComboBox.DataSource = dt;
                        salesManComboBox.DisplayMember = "EmpName1";
                        salesManComboBox.ValueMember = "EmpID";
                    }
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }
    }
}
