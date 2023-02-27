using POSSystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class TransfersForm : Form
    {

        int CurrentLine = 0;
        double totalValue = 0;
        double totalQty = 0;
        string BLNO = "";
        string blnoPrefix = "";
        string toBranchId = "";
        string dontAllowMinus = "";
        RawPrinterHelper rawPrinter = new RawPrinterHelper();
        public TransfersForm()
        {
            InitializeComponent();



            try
            {
                dataGrid.RowCount = 100;
                dataGrid.DefaultCellStyle.Font = new Font("Tahoma", 15);
                dataGrid.RowTemplate.Height = 35;
                Text = "مناقلة من فرع " + Settings.getSetting("branch");

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Branches WHERE BranchId <> " + Settings.getSetting("branchId");
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
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

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT * FROM BSR WHERE BLID = " + Settings.getSetting("dtiId");
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        {
                            blnoPrefix = reader["BillNo"].ToString();
                            dontAllowMinus = reader["Fld0"].ToString();
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
                    cmd.CommandText = "SELECT MAX(CAST(BLNO AS INT))+1 AS BLID FROM DTI WHERE BLID = '" + Settings.getSetting("dtiId") + "'";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "EmpID";
                        dt.Columns.Add().ColumnName = "EmpName1";
                        reader.Read();
                        if (reader["BLID"].ToString() != "")
                        {
                            blnoLabel.Text = reader["BLID"].ToString();
                            BLNO = reader["BLID"].ToString();
                        }
                        else
                        {
                            BLNO = blnoPrefix;
                            blnoLabel.Text = BLNO;
                        }
                    }
                    else
                    {
                        BLNO = blnoPrefix;
                        blnoLabel.Text = BLNO;
                    }
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }

        private void barcodeText_KeyUp(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                try { 
                    using (SqlConnection conn = Connection.GetDataConnection())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        if (dontAllowMinus != "True")
                            cmd.CommandText = "SELECT * FROM QMTS WHERE Barcode = '" + barcodeText.Text + "'";
                        else
                            cmd.CommandText = "SELECT * FROM QMTS WHERE BranchId = '"+Settings.getSetting("branchId")+"' AND QTY > 0 AND Barcode = '" + barcodeText.Text + "'";

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();

                            dataGrid.Rows[CurrentLine].Cells[0].Value = reader["ComputerNo"].ToString();
                            dataGrid.Rows[CurrentLine].Cells[1].Value = reader["ColorEName"].ToString();
                            dataGrid.Rows[CurrentLine].Cells[2].Value = reader["SizeName"].ToString();
                            dataGrid.Rows[CurrentLine].Cells[4].Value = reader["Barcode"].ToString();
                            dataGrid.Rows[CurrentLine].Cells[5].Value = reader["Code"].ToString();

                            string computerNo = reader["ComputerNo"].ToString();
                            string priceValue = "";

                            if (Settings.getSetting("isAdditionallPrice") == "false")
                            {
                                if (Settings.getSetting("priceType") == "endUser")
                                    priceValue = reader["EndUser"].ToString();
                                else
                                    if (Settings.getSetting("priceType") == "sale")
                                    priceValue = reader["Sale"].ToString();
                                else
                                        if (Settings.getSetting("priceType") == "clearance")
                                    priceValue = reader["Clearance"].ToString();
                                else
                                            if (Settings.getSetting("priceType") == "special")
                                    priceValue = reader["Special"].ToString();

                                if (priceValue == "0")
                                    priceValue = reader["EndUser"].ToString();
                            }
                            else
                            {
                                reader.Close();
                                cmd.CommandText = "SELECT * FROM MatrialPrices WHERE PriceId = '" + Settings.getSetting("additionallPriceId") + "' AND ComputerNo = '" + computerNo + "'";
                                reader = cmd.ExecuteReader();
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    if (Settings.getSetting("priceType") == "endUser")
                                        priceValue = reader["Price"].ToString();
                                    else
                                        if (Settings.getSetting("priceType") == "sale")
                                        priceValue = reader["Sale"].ToString();
                                    else
                                            if (Settings.getSetting("priceType") == "clearance")
                                        priceValue = reader["Clearance"].ToString();
                                    else
                                                if (Settings.getSetting("priceType") == "special")
                                        priceValue = reader["Special"].ToString();
                                    if (priceValue == "0")
                                        priceValue = reader["EndUser"].ToString();

                                }
                            }

                            dataGrid.Rows[CurrentLine].Cells[3].Value = priceValue;

                            CurrentLine = CurrentLine + 1;
                            totalValue = totalValue + Convert.ToDouble(priceValue);
                            totalQty = totalQty + 1;



                            totalValueLabel.Text = "الإجمالي : " + totalValue.ToString();
                            totalQtyLabel.Text = "العدد : " + totalQty.ToString();

                            try
                            {
                                pictureBox.LoadAsync("http://192.99.16.179:9022/Photos/" + computerNo + ".jpg");
                            }
                            catch
                            {
                                pictureBox.Image = null;
                                pictureBox.InitialImage = null;
                            }

                            barcodeText.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("هذه المادة ليست متوفرة ضمن المخزون او غير معرفة ");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
                }
            }

        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    if (dataGrid.SelectedRows[0].Cells[4].Value != null)
                    {
                        string priceValue = dataGrid.SelectedRows[0].Cells[3].Value.ToString();
                        int idx = dataGrid.SelectedRows[0].Index;

                        totalValue = totalValue - Convert.ToDouble(priceValue);
                        totalQty = totalQty - 1;

                        totalValueLabel.Text = "الإجمالي : " + totalValue.ToString();
                        totalQtyLabel.Text = "العدد : " + totalQty.ToString();
                        dataGrid.Rows.RemoveAt(idx);
                    }
                }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }

        private void branchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView oDataRowView = branchComboBox.SelectedItem as DataRowView;
                toBranchId = string.Empty;

                if (oDataRowView != null)
                {
                    toBranchId = oDataRowView.Row["BranchId"] as string;
                }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public DataTable getDti(string invBLNO)
        {
            try
            {
                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    using (SqlDataAdapter ds1 = new SqlDataAdapter("SELECT * FROM QDTI WHERE BLNO = " + invBLNO + " AND BLID = " + Settings.getSetting("dtiId"), conn))
                    {
                        DataSet ds = new DataSet();
                        ds1.Fill(ds);
                        DataTable dt = new DataTable();
                        dt = ds.Tables[0];
                        conn.Close();
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not get Data");
            }
        }

        public DataTable getDtd(string invBLNO)
        {
            try
            {
                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    using (SqlDataAdapter ds1 = new SqlDataAdapter("SELECT * FROM QDTD WHERE BLNO = " + invBLNO + " AND BLID = " + Settings.getSetting("dtiId"), conn))
                    {
                        DataSet ds = new DataSet();
                        ds1.Fill(ds);
                        DataTable dt = new DataTable();
                        dt = ds.Tables[0];
                        conn.Close();
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not get Data");
            }
        }

        PrintDocument pdoc = null;
        DataTable dtdData;
        DataTable dtiData;

        private void cashButton_Click(object sender, EventArgs e)
        {
            if (CurrentLine > 0)
            {
                try
                {
                    using (SqlConnection conn = Connection.GetDataConnection())
                    {
                        DateTime d = DateTime.Now;
                        string currentblDate = d.Year.ToString() + "-" + d.Month.ToString() + "-" + d.Day.ToString();
                        string currentblTime = "1900-01-01 " + d.Hour.ToString() + ":" + d.Minute.ToString() + ":" + d.Second.ToString() + ".000";
                        string currentRDate = currentblDate + " " + d.Hour.ToString() + ":" + d.Minute.ToString() + ":" + d.Second.ToString() + ".000";
                        string currentBlno = BLNO;
                        string currentBlid = Settings.getSetting("dtiId");
                        string currentTotalValue = totalValue.ToString();
                        string currentQty = totalQty.ToString();
                        string currentBranchId = Settings.getSetting("branchId");
                        string currentCurrencyId = Settings.getSetting("currencyId");
                        string currentRate = "1";
                        string currentUsername = Settings.getSetting("user");
                        string currentToBranch = toBranchId;
                        string currentUserCode = Settings.getSetting("userId");
                        string currentSysUser = Settings.getSetting("userId");


                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.CommandTimeout = 60000;

                        cmd.CommandText = "INSERT INTO DTI(BLID, BLNO, From_Br, To_Br, BLDate, TotalQty, User_Code, BPost, QPost, UserSys, BLTime, FullUserName, IsOrder) " +
                            "VALUES(" + currentBlid + "," + currentBlno + "," + currentBranchId + "," + currentToBranch + ",'" + currentblDate + "'," + totalQty.ToString() + "," + currentUserCode + ",0,0," + currentSysUser + ",'" + currentblTime + "','" + currentUsername + "'," + "0)";
                        string c = cmd.CommandText;
                        cmd.ExecuteNonQuery();
                        conn.Close();


                        DataTable dtdDataTable;
                        using (dtdDataTable = new DataTable())
                        {
                            dtdDataTable.Columns.Add("BLNO", typeof(int));
                            dtdDataTable.Columns.Add("BLID", typeof(int));
                            dtdDataTable.Columns.Add("Number", typeof(int));
                            dtdDataTable.Columns.Add("Code", typeof(int));
                            dtdDataTable.Columns.Add("Qty", typeof(int));
                            dtdDataTable.Columns.Add("Price", typeof(float));
                            dtdDataTable.Columns.Add("CostPrice", typeof(float));
                            dtdDataTable.Columns.Add("ComputerNo", typeof(string));
                            dtdDataTable.Columns.Add("From_Br", typeof(string));
                            dtdDataTable.Columns.Add("To_Br", typeof(int));
                            dtdDataTable.Columns.Add("PriceType", typeof(int));

                            for (int i = 0; i < CurrentLine; i++)
                            {
                                string computerNo = dataGrid.Rows[i].Cells[0].Value.ToString();
                                string code = dataGrid.Rows[i].Cells[5].Value.ToString();
                                string price = dataGrid.Rows[i].Cells[3].Value.ToString();

                                dtdDataTable.Rows.Add(currentBlno, currentBlid, i + 1, code, 1, Convert.ToDouble(price), 0.0, computerNo, currentBranchId, currentToBranch, 0);
                            }

                        }
                        conn.Open();
                        var pList = new SqlParameter("@dtd", SqlDbType.Structured);
                        pList.Value = dtdDataTable;
                        pList.TypeName = "dbo.dtdType";
                        cmd.Parameters.Add(pList);
                        cmd.Connection = conn;
                        cmd.CommandTimeout = 60000;
                        cmd.CommandText = @"insert into DTD(BLNO, BLID, Number, Code, Qty, Price, CostPrice, ComputerNo, From_Br, To_Br, PriceType) " +
                            " SELECT BLNO, BLID, Number, Code, Qty, Price, CostPrice, ComputerNo, From_Br, To_Br, PriceType FROM @dtd as x";
                        cmd.ExecuteNonQuery();
                        conn.Close();



                        if (Settings.getSetting("printer") != "")
                        {
                            printInvoice();
                        }

                        dataGrid.Rows.Clear();
                        BLNO = Convert.ToString(int.Parse(BLNO) + 1);
                        currentBlno = BLNO;
                        blnoLabel.Text = BLNO;
                        totalValueLabel.Text = "الإجمالي : 0";
                        totalQtyLabel.Text = "العدد : 0";
                        totalValue = 0;
                        totalQty = 0;
                        pictureBox.Image = null;
                        pictureBox.InitialImage = null;
                        dataGrid.RowCount = 100;
                        CurrentLine = 0;
                        MessageBox.Show("تمت عملية حفظ المناقلة بنجاح");
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("حصل خطأ يرجى اعادة المحاولة " + er.Message);
                }
            }
        }

        void dailyDep(object sender, PrintPageEventArgs e)
        {
            try
            {
                string iBLNO = dtiData.Rows[0]["BLNO"].ToString();
                string iDate = dtiData.Rows[0]["BLDate"].ToString();
                string iFromBranch = dtiData.Rows[0]["From_BranchName"].ToString();
                string iToBranch = dtiData.Rows[0]["To_BranchName"].ToString();
                //-----------
                Graphics graphics = e.Graphics;
                Font font = new Font("calibri", 10);
                float fontHeight = font.GetHeight();
                String underLine = "-------------------------------------------------------------";
                int startX = 10;
                int startY = 20;
                int Offset = 10;
                Offset += 0;
                Offset = Offset + 15;
                graphics.DrawString("Transfer NO : " + iBLNO, new Font("calibri", 10), new SolidBrush(Color.Black), 15, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString("From Branch : " + iFromBranch, new Font("calibri", 10), new SolidBrush(Color.Black), 15, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString("To Branch : " + iToBranch, new Font("calibri", 10), new SolidBrush(Color.Black), 15, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString("CLOI - Transfer", new Font("Calibri", 20), new SolidBrush(Color.Black), startX + 15, startY + Offset);
                Offset = Offset + 30;
                graphics.DrawString(underLine, new Font("calibri", 10), new SolidBrush(Color.Black), 0, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString(DateTime.Now.ToString("d, MMMM, yyyy"), new Font("Calibri", 10), new SolidBrush(Color.Black), startX + 15, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString(underLine, new Font("calibri", 10), new SolidBrush(Color.Black), 0, startY + Offset);

                Offset = Offset + 10;
                graphics.DrawString("Item                               Quantity", new Font("Calibri", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 10;
                graphics.DrawString(underLine, new Font("calibri", 10), new SolidBrush(Color.Black), 0, startY + Offset);
                Offset = Offset + 10;
                int totalQty = 0;
                for (int i = 0; i < dtdData.Rows.Count; i++)
                {

                    string item = (i + 1) + " - " + dtdData.Rows[i]["Barcode"].ToString();
                    string quantity = dtdData.Rows[i]["Qty"].ToString();
                    totalQty = totalQty + Convert.ToInt32(dtdData.Rows[i]["Qty"].ToString());
                    graphics.DrawString(item, new Font("Calibri", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                    graphics.DrawString(quantity, new Font("Calibri", 8), new SolidBrush(Color.Black), startX + 180, startY + Offset);

                    Offset = Offset + 15;
                }
                graphics.DrawString(underLine, new Font("calibri", 10), new SolidBrush(Color.Black), 0, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString("Total Quantity: " + totalQty.ToString(), new Font("Calibri", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 15;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة " + ex.ToString());
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGrid.Rows.Clear();
                BLNO = Convert.ToString(int.Parse(BLNO));
                totalValueLabel.Text = "الإجمالي : 0";
                totalQtyLabel.Text = "العدد : 0";
                totalValue = 0;
                totalQty = 0;
                pictureBox.Image = null;
                pictureBox.InitialImage = null;
                dataGrid.RowCount = 100;
                CurrentLine = 0;
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }


        private void printInvoice()
        {
            try
            {
                dtiData = this.getDti(BLNO);
                dtdData = this.getDtd(BLNO);
                string iBLNO = dtiData.Rows[0]["BLNO"].ToString();
                string iFromBranch = dtiData.Rows[0]["From_BranchName"].ToString();
                string iToBranch = dtiData.Rows[0]["To_BranchName"].ToString();
                string iDate = dtiData.Rows[0]["BLDate"].ToString();

                rawPrinter.OpenPrint(Settings.getSetting("printer"));

                rawPrinter.SendStringToPrinter("CLOI - Transfer" + Environment.NewLine);
                rawPrinter.SendStringToPrinter("www.cloistore.com" + Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter("-----------------------------------------" + Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter("From: " + iFromBranch + Environment.NewLine);
                rawPrinter.SendStringToPrinter("To: " + iToBranch + Environment.NewLine);
                rawPrinter.SendStringToPrinter("Transfer NO.: " + iBLNO + Environment.NewLine);
                rawPrinter.SendStringToPrinter("Date: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter("-----------------------------------------" + Environment.NewLine);
                rawPrinter.SendStringToPrinter("Item                  Qty         " + Environment.NewLine);
                rawPrinter.SendStringToPrinter("-----------------------------------------" + Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                for (int i = 0; i < dtdData.Rows.Count; i++)
                {
                    string item = (i + 1) + " - " + dtdData.Rows[i]["Barcode"].ToString();
                    string quantity = dtdData.Rows[i]["Qty"].ToString();
                    rawPrinter.SendStringToPrinter(item + "   -   " + quantity  + Environment.NewLine);
                    rawPrinter.SendStringToPrinter(Environment.NewLine);
                }
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.ClosePrint();
            }
            catch
            {
                MessageBox.Show("حصل خطأ اثناء عملية الطباعة");
            }
        }
    }
}
