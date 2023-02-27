using POSSystem.Common;
using POSSystem.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class posForm : Form
    {
        int CurrentLine = 0;
        double totalValue = 0.0;
        bool isReturn = false;
        bool searchForClient = false;
        string customerId = "";
        string BLNO = "";
        string salesManId = "";
        int totalQty = 0;
        string ACID = "";
        string returnACID = "";
        string ShiftNo = "";
        string shiftPrefix = "";
        string blnoPrefix = "";
        string DontAllowMinus = "";
        RawPrinterHelper rawPrinter = new RawPrinterHelper();
        public posForm()
        {
            try
            {
                InitializeComponent();
                
                dataGrid.RowCount = 100;
                dataGrid.DefaultCellStyle.Font = new Font("Tahoma", 15);
                dataGrid.RowTemplate.Height = 35;
                branchNameLbl.Text = Settings.getSetting("branch");
                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT * FROM BSR WHERE BLID = " + Settings.getSetting("bliId");
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        {
                            ACID = reader["Mat"].ToString();
                            returnACID = reader["ReturnItemID"].ToString();
                            shiftPrefix = reader["CacheNo"].ToString();
                            blnoPrefix = reader["BillNo"].ToString();
                            DontAllowMinus = reader["Fld0"].ToString();
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
                    cmd.CommandText = "SELECT * FROM CSI WHERE CloseState = 1 AND BranchId = " + Settings.getSetting("branchId");
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        {
                            ShiftNo = reader["Cash_Number"].ToString();
                        }

                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "SELECT max(Cash_Number) as LastCashNo FROM CSI WHERE BranchId = " + Settings.getSetting("branchId");
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            {
                                ShiftNo = reader["LastCashNo"].ToString();
                            }
                        }


                        if (ShiftNo == "")                        
                        {
                            conn.Close();
                            conn.Open();
                            cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.CommandText = "INSERT INTO CSI (Cash_Number, BranchId, EmpNr, Start_Date, CloseState, SubmitState, CurrencyId, TShiftValue, TDisc, TExtra, TCredit, TCV, TRCV, TExpenses, TOtherCurrencies, Actual_Credit, Actual_CV, Actual_RCV, Actual_OtherCurrencies, RSV, CRSV, More, Short, TCorrection, RBalance, ModifyDate) " +
                                "VALUES(" + shiftPrefix + ", '" + Settings.getSetting("branchId") + "'," + Settings.getSetting("salesManId") + ", '" + DateTime.Now.ToString() + "', 1, 0, " + Settings.getSetting("currencyId") + ", 0, 0, 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'" + DateTime.Now.ToString() + "')";

                            reader = cmd.ExecuteReader();
                            ShiftNo = shiftPrefix;
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
                    cmd.CommandText = "SELECT * FROM EmployeeAff WHERE BranchId = " + Settings.getSetting("branchId");
                    SqlDataReader reader = cmd.ExecuteReader();
                    salesManComboBox.Items.Clear();
                    if (reader.HasRows)
                    {
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
                        salesManComboBox.SelectedItem = null;
                        salesManComboBox.Text = "";
                    }
                    conn.Close();
                }

                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT MAX(CAST(BLNO AS INT))+1 AS BLID FROM BLI WHERE BLID = '" + Settings.getSetting("bliId") + "'";
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

        private void posText_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void posText_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    using (SqlConnection conn = Connection.GetDataConnection())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        if (!isReturn)
                        {
                            if (DontAllowMinus != "True")
                                cmd.CommandText = "SELECT * FROM QMTS WHERE Barcode = '" + posText.Text + "'";
                            else
                                cmd.CommandText = "SELECT * FROM QMTS WHERE BranchId = '" + Settings.getSetting("branchId") + "' AND Qty > 0 AND Barcode = '" + posText.Text + "'";
                        }
                        else
                        {
                            cmd.CommandText = "SELECT * FROM QMTS WHERE Barcode = '" + posText.Text + "'";
                        }
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            if (isReturn)
                            {
                                dataGrid.Rows[CurrentLine].Cells[0].Value = "مرتجع";

                                dataGrid.Rows[CurrentLine].Cells[0].Style.BackColor = Color.Green;
                                dataGrid.Rows[CurrentLine].Cells[1].Style.BackColor = Color.Green;
                                dataGrid.Rows[CurrentLine].Cells[2].Style.BackColor = Color.Green;
                                dataGrid.Rows[CurrentLine].Cells[3].Style.BackColor = Color.Green;
                                dataGrid.Rows[CurrentLine].Cells[4].Style.BackColor = Color.Green;
                                dataGrid.Rows[CurrentLine].Cells[5].Style.BackColor = Color.White;
                                dataGrid.Rows[CurrentLine].Cells[6].Style.BackColor = Color.White;

                            }
                            else
                            {
                                dataGrid.Rows[CurrentLine].Cells[0].Value = "مبيع";

                                dataGrid.Rows[CurrentLine].Cells[0].Style.BackColor = Color.White;
                                dataGrid.Rows[CurrentLine].Cells[1].Style.BackColor = Color.White;
                                dataGrid.Rows[CurrentLine].Cells[2].Style.BackColor = Color.White;
                                dataGrid.Rows[CurrentLine].Cells[3].Style.BackColor = Color.White;
                                dataGrid.Rows[CurrentLine].Cells[4].Style.BackColor = Color.White;
                                dataGrid.Rows[CurrentLine].Cells[5].Style.BackColor = Color.White;
                                dataGrid.Rows[CurrentLine].Cells[6].Style.BackColor = Color.White;
                            }
                            dataGrid.Rows[CurrentLine].Cells[1].Value = reader["ComputerNo"].ToString();
                            dataGrid.Rows[CurrentLine].Cells[2].Value = reader["ColorEName"].ToString();
                            dataGrid.Rows[CurrentLine].Cells[3].Value = reader["SizeName"].ToString();
                            dataGrid.Rows[CurrentLine].Cells[5].Value = reader["Barcode"].ToString();
                            dataGrid.Rows[CurrentLine].Cells[6].Value = reader["Code"].ToString();

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

                            if (isReturn)
                                dataGrid.Rows[CurrentLine].Cells[4].Value = "-" + priceValue;
                            else
                                dataGrid.Rows[CurrentLine].Cells[4].Value = priceValue;

                            CurrentLine = CurrentLine + 1;
                            if (!isReturn)
                            {
                                totalValue = totalValue + Convert.ToDouble(priceValue);
                                totalQty = totalQty + 1;
                            }
                            else
                            {
                                totalValue = totalValue + Convert.ToDouble("-" + priceValue);
                                totalQty = totalQty - 1;
                            }



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

                            posText.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("هذه المادة ليست متوفرة ضمن المخزون او غير معرفة ");
                        }
                    }
                }
            } catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            try
            {
                isReturn = !isReturn;
                if (isReturn)
                {
                    returnButton.BackColor = Color.Green;
                    cashButton.Enabled = false;
                    customerButton.Enabled = false;
                    customerButton.BackColor = Color.Gray;
                    returnButton.Text = "إنهاء المرتجع F5";
                    posTextLabel.Text = "ادخل باركود القطعة المرتجعة";
                }
                else
                {
                    returnButton.Text = "مرتجع F5";
                    returnButton.BackColor = Color.Gray;
                    cashButton.Enabled = true;
                    customerButton.Enabled = true;
                    if (searchForClient)
                    {
                        posTextLabel.Text = "أدخل رقم العميل";
                        customerButton.Text = "بحث عن العميل F6";
                        customerButton.BackColor = Color.Green;
                    }
                    else
                    {
                        posTextLabel.Text = "أدخل الباركود";
                        customerButton.BackColor = Color.Gray;
                        customerButton.Text = "تحديد العميل F6";
                    }
                }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            try
            {
                searchForClient = !searchForClient;
                if (searchForClient)
                {
                    returnButton.BackColor = Color.Gray;
                    returnButton.Enabled = false;
                    cashButton.Enabled = false;
                    posTextLabel.Text = "ادخل رقم العميل";
                    customerButton.Text = "بحث عن العميل F6";
                    customerButton.BackColor = Color.Green;
                }
                else
                {
                    if (posText.Text.Trim() != "")
                    {
                        bool found = false;

                        using (SqlConnection conn = Connection.GetDataConnection())
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.CommandText = "SELECT CustomerName, CustomerId FROM PosCustomers WHERE MobilePhone = '" + posText.Text + "'";
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                customerId = reader["CustomerId"].ToString();
                                customerNameLabel.Text = reader["CustomerName"].ToString();
                                found = true;
                                posText.Text = "";
                            }
                            conn.Close();
                        }


                        if (!found)
                        {
                            createCustomerForm frm = new createCustomerForm();
                            frm.fillCustomerNumber(posText.Text);
                            frm.ShowDialog(this);
                            string name = frm.name;
                            string id = frm.id;
                            customerNameLabel.Text = name;
                            customerId = id;
                            posText.Text = "";
                            frm.Dispose();
                        }

                        returnButton.Enabled = true;
                        cashButton.Enabled = true;
                        customerButton.BackColor = Color.Gray;
                        customerButton.Text = "تحديد العميل F6";
                        if (isReturn)
                        {
                            returnButton.BackColor = Color.Green;
                            posTextLabel.Text = "ادخل باركود القطعة المرتجعة";
                        }
                        else
                        {
                            returnButton.BackColor = Color.Gray;
                            posTextLabel.Text = "ادخل الباركود";
                        }
                    }
                    else
                    {
                        MessageBox.Show("يرجى إدخال رقم موبايل العميل");
                    }
                }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة");
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
                        string priceValue = dataGrid.SelectedRows[0].Cells[4].Value.ToString();
                        int idx = dataGrid.SelectedRows[0].Index;

                        if (!isReturn)
                        {
                            totalValue = totalValue - Convert.ToDouble(priceValue);
                            totalQty = totalQty - 1;
                        }
                        else
                        {
                            totalValue = totalValue + Convert.ToDouble(priceValue);
                            totalQty = totalQty + 1;
                        }
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

        private void cashButton_Click(object sender, EventArgs e)
        {
            bool isValid = false;

            if (CurrentLine > 0)
                if (salesManId != "")
                    if (customerId != "")
                        isValid = true;

            if (isValid)
            {
                int line = 0;
                if (CurrentLine > 0)
                {
                    try
                    {
                        using (SqlConnection conn = Connection.GetDataConnection())
                        {
                            conn.Open();
                            SqlTransaction trans = null;
                            trans = conn.BeginTransaction();

                            DateTime d = DateTime.Now;

                            string currentblDate = d.Year.ToString() + "-" + d.Month.ToString() + "-" + d.Day.ToString();

                            string currentblTime = "1900-01-01 " + d.Hour.ToString() + ":" + d.Minute.ToString() + ":" + d.Second.ToString() + ".000";

                            string currentRDate = currentblDate + " " + d.Hour.ToString() + ":" + d.Minute.ToString() + ":" + d.Second.ToString() + ".000";

                            string currentCustimerId = customerId;

                            string currentBlno = BLNO;

                            string currentBlid = Settings.getSetting("bliId");

                            string currentTotalValue = totalValue.ToString();

                            string currentQty = totalQty.ToString();

                            string currentBranchId = Settings.getSetting("branchId");

                            string currentCurrencyId = Settings.getSetting("currencyId");

                            string currentACID = ACID;

                            string currentReturnACID = returnACID;

                            string currentShiftNo = ShiftNo;

                            string currentRate = "1";

                            string currentUsername = Settings.getSetting("user");                            

                            SqlCommand cmd1 = new SqlCommand();

                            cmd1.Connection = conn;

                            cmd1.CommandType = System.Data.CommandType.Text;

                            cmd1.CommandTimeout = 60000;

                            cmd1.CommandText = "INSERT INTO BLI(BLNO, BLID, ACID, BLDATE, BLTIME, BranchId, CurrencyId, EmpNr, FinalValue, FullUserName, IsPoint, IsPosted, " +
                            "PayType, POSCustId, PostedBy, Profits, Rate, RcpnValue, RDate, ReturnCash, ReturnMaster, ReturnVisa, ShiftNo, Tax, TotalDisc, TotalExtra, " +
                            "TotalQty, TotalVal, FirstPay, CvID, CvValue) VALUES(" + currentBlno + "," + currentBlid + "," + currentACID + ",'" + currentblDate + "','" + currentblTime + "'," + currentBranchId + ", " +
                            currentCurrencyId + ", " + salesManId + "," + totalValue.ToString() + ",'" + currentUsername + "',0,1,0," + currentCustimerId + ",'" +
                            currentUsername + "',0,1,0,'" + currentRDate + "',0,0,0," + currentShiftNo + ",0,0,0," + totalQty.ToString() + "," + totalValue.ToString() + ", NULL, NULL, NULL)";

                            cmd1.Transaction = trans;

                            string c = cmd1.CommandText;

                            DataTable bldDataTable;

                            using (bldDataTable = new DataTable())
                            {

                                bldDataTable.Columns.Add("BLNO", typeof(int));

                                bldDataTable.Columns.Add("BLID", typeof(int));

                                bldDataTable.Columns.Add("Number", typeof(int));

                                bldDataTable.Columns.Add("Code", typeof(int));

                                bldDataTable.Columns.Add("IsOutput", typeof(bool));

                                bldDataTable.Columns.Add("Qty", typeof(float));

                                bldDataTable.Columns.Add("Cost", typeof(float));

                                bldDataTable.Columns.Add("Price", typeof(float));

                                bldDataTable.Columns.Add("PriceType", typeof(int));

                                bldDataTable.Columns.Add("Discount", typeof(float));

                                bldDataTable.Columns.Add("CurrencyId", typeof(int));

                                bldDataTable.Columns.Add("Rate", typeof(float));

                                bldDataTable.Columns.Add("BranchId", typeof(string));

                                bldDataTable.Columns.Add("Profits", typeof(float));

                                bldDataTable.Columns.Add("ComputerNo", typeof(string));

                                bldDataTable.Columns.Add("FinalPrice", typeof(float));

                                bldDataTable.Columns.Add("ReternQty", typeof(int));

                                bldDataTable.Columns.Add("CurrentPrice", typeof(float));

                                bldDataTable.Columns.Add("EmpNr", typeof(int));

                                for (int i = 0; i < CurrentLine; i++)
                                {

                                    string isOutputText = dataGrid.Rows[i].Cells[0].Value.ToString();

                                    string computerNo = dataGrid.Rows[i].Cells[1].Value.ToString();

                                    string code = dataGrid.Rows[i].Cells[6].Value.ToString();

                                    string price = dataGrid.Rows[i].Cells[4].Value.ToString();


                                    bool isOutput = true;

                                    if (isOutputText == "مرتجع")
                                        isOutput = false;

                                    if (!isOutput)
                                        price = (Convert.ToDouble(price) * (-1)).ToString();

                                    bldDataTable.Rows.Add(currentBlno, currentBlid, i + 1, code, isOutput, 1, 0.0, Convert.ToDouble(price), 1, 0.0, int.Parse(currentCurrencyId),
                                        1, currentBranchId, 0.0, computerNo, Convert.ToDouble(price), 0, Convert.ToDouble(price), salesManId);
                                }

                            }


                            var pList = new SqlParameter("@bld", SqlDbType.Structured);

                            pList.Value = bldDataTable;

                            pList.TypeName = "dbo.BldType";

                            SqlCommand cmd2 = new SqlCommand();

                            cmd2.Connection = conn;

                            cmd2.CommandType = System.Data.CommandType.Text;

                            cmd2.CommandTimeout = 60000;

                            cmd2.Parameters.Add(pList);

                            cmd2.Connection = conn;

                            cmd2.CommandText = @"insert into BLD(BLNO, BLID, Number, Code, IsOutput, Qty, Cost, Price, PriceType, Discount, CurrencyId, Rate, BranchId, Profits, ComputerNo, FinalPrice, ReternQty, CurrentPrice, EmpNr) " +
                                " SELECT BLNO, BLID, Number, Code, IsOutput, Qty, Cost, Price, PriceType, Discount, CurrencyId, Rate, BranchId, Profits, ComputerNo, FinalPrice, ReternQty, CurrentPrice, EmpNr FROM @bld as x";
                            
                            cmd2.CommandTimeout = 60000;
                            cmd2.Transaction = trans;

                            SqlCommand cmd3 = new SqlCommand();

                            if (totalValue > 0)
                            {
                                

                                cmd3.Connection = conn;

                                cmd3.CommandType = System.Data.CommandType.Text;

                                cmd3.CommandTimeout = 60000;


                                cmd3.CommandText = @"insert into BLP(BLID, BLNO, Number, PayTypeId, Val, ApprovalNo, CardNo, CustName) " +
                                    "VALUES(" + currentBlid + ", " + currentBlno + ", 1, 1, " + totalValue.ToString() + ", NULL, 0, 0)";
                                cmd3.Transaction = trans;
                            }

                            try
                            {
                                cmd1.ExecuteNonQuery();
                                cmd2.ExecuteNonQuery();
                                if (totalValue > 0)
                                    cmd3.ExecuteNonQuery();
                                trans.Commit();

                                if (Settings.getSetting("printer") != "")
                                {

                                    printInvoice();


                                    /*PrintDialog pd = new PrintDialog();

                                    pdoc = new PrintDocument();

                                    PrinterSettings ps = new PrinterSettings();

                                    Font font = new Font("Simplified Arabic Fixed", 15);

                                    PaperSize psize = new PaperSize("Custom", 200, 500);

                                    pd.Document = pdoc;

                                    pd.Document.DefaultPageSettings.PaperSize = psize;

                                    pdoc.DefaultPageSettings.PaperSize.Height = 500;

                                    pdoc.DefaultPageSettings.PaperSize.Width = 200;

                                    pdoc.PrintPage += new PrintPageEventHandler(dailyDep);

                                    pdoc.PrinterSettings.PrinterName = Settings.getSetting("printer");

                                    pdoc.Print(); */
                                }

                                dataGrid.Rows.Clear();

                                BLNO = Convert.ToString(int.Parse(BLNO) + 1);

                                currentBlno = BLNO;

                                blnoLabel.Text = BLNO;

                                totalValueLabel.Text = "الإجمالي : 0";

                                totalQtyLabel.Text = "العدد : 0";

                                totalValue = 0;

                                totalQty = 0;

                                customerId = "";

                                customerNameLabel.Text = "";

                                pictureBox.Image = null;

                                pictureBox.InitialImage = null;

                                dataGrid.RowCount = 100;

                                CurrentLine = 0;

                                MessageBox.Show("تمت عملية حفظ الفاتورة بنجاح");
                            }
                            catch (Exception ee)
                            {
                                MessageBox.Show(ee.Message);
                                if (ee.InnerException != null)
                                    MessageBox.Show(ee.InnerException.Message);
                                trans.Rollback();
                            }
                            finally
                            {
                                conn.Close();
                            }

                        }
                    }
                    catch (Exception er)
                    {
                        

                        string error = "حصل خطأ يرجى اعادة المحاولة" + " " +line.ToString() + " : " + er.Message;
                        if (er.InnerException != null)
                            error = error + " --- " + er.InnerException;
                        MessageBox.Show(error);
                    }
                }
            }
            else
            {
                MessageBox.Show("يرجى تحديد البائع و العميل و التأكد من وجود أصناف في الفاتورة");
            }
        }

        private void printInvoice()
        {
            try
            {
                bliData = this.getBli(BLNO);

                bldData = this.getBld(BLNO);
                double total = 0;
                string iBLNO = bliData.Rows[0]["BLNO"].ToString();
                string iSalesMan = bliData.Rows[0]["EmpName1"].ToString();
                string iCustomer = bliData.Rows[0]["CustomerName"].ToString() + " - " + bliData.Rows[0]["MobilePhone"].ToString();
                string iDate = bliData.Rows[0]["BLDate"].ToString();

                rawPrinter.OpenPrint(Settings.getSetting("printer"));

                rawPrinter.SendStringToPrinter(branchNameLbl.Text + Environment.NewLine);
                rawPrinter.SendStringToPrinter("www.cloistore.com" + Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter("-----------------------------------------" + Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter("Customer: " + iCustomer + Environment.NewLine);
                rawPrinter.SendStringToPrinter("Sales Man: " + iSalesMan + Environment.NewLine);
                rawPrinter.SendStringToPrinter("Invoice NO.: " + iBLNO + Environment.NewLine);
                rawPrinter.SendStringToPrinter("Date: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                rawPrinter.SendStringToPrinter("-----------------------------------------" + Environment.NewLine);
                rawPrinter.SendStringToPrinter("Item                  Qty         Price" + Environment.NewLine);
                rawPrinter.SendStringToPrinter("-----------------------------------------" + Environment.NewLine);
                rawPrinter.SendStringToPrinter(Environment.NewLine);
                for (int i = 0; i < bldData.Rows.Count; i++)
                {
                    string item = (i + 1) + " - " + bldData.Rows[i]["Barcode"].ToString();
                    string quantity = bldData.Rows[i]["Qty"].ToString();
                    string price = bldData.Rows[i]["FinalPrice"].ToString();
                    total = total + Convert.ToDouble(bldData.Rows[i]["FinalPrice"].ToString());
                    rawPrinter.SendStringToPrinter(item + "   -   " + quantity + "   -  " + price + " SYP" + Environment.NewLine);
                    rawPrinter.SendStringToPrinter(Environment.NewLine);
                }
                rawPrinter.SendStringToPrinter("-----------------------------------------" + Environment.NewLine);
                rawPrinter.SendStringToPrinter("Total : " + total.ToString() + " SYP" + Environment.NewLine);
                rawPrinter.SendStringToPrinter("-----------------------------------------" + Environment.NewLine);
                rawPrinter.SendStringToPrinter("Thanks for your visit" + Environment.NewLine);
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

        private void salesManComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void salesManComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView oDataRowView = salesManComboBox.SelectedItem as DataRowView;
                salesManId = string.Empty;

                if (oDataRowView != null)
                {
                    salesManId = oDataRowView.Row["EmpId"] as string;
                }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة ");
            }
        }

        private void posText_TextChanged(object sender, EventArgs e)
        {

        }


        public DataTable getBli(string invBLNO)
        {
            try
            {
                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    using (SqlDataAdapter ds1 = new SqlDataAdapter("SELECT * FROM QBLI WHERE BLNO = " + invBLNO + " AND BLID = " + Settings.getSetting("bliId"), conn))
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
                throw new Exception("حصل خطأ يرجى اعادة المحاولة");
            }
        }

        public DataTable getBld(string invBLNO)
        {
            try
            {
                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    conn.Open();
                    using (SqlDataAdapter ds1 = new SqlDataAdapter("SELECT * FROM QBLD WHERE BLNO = "+ invBLNO + " AND BLID = "+ Settings.getSetting("bliId"), conn))
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
                throw new Exception("حصل خطأ يرجى اعادة المحاولة");
            }
        }

        PrintDocument pdoc = null;
        DataTable bldData;
        DataTable bliData;



        void dailyDep(object sender, PrintPageEventArgs e)
        {
            try
            {
                
                string iBLNO = bliData.Rows[0]["BLNO"].ToString();
                string iSalesMan = bliData.Rows[0]["EmpName1"].ToString();
                string iCustomer = bliData.Rows[0]["CustomerName"].ToString() + " - " + bliData.Rows[0]["MobilePhone"].ToString();
                string iDate = bliData.Rows[0]["BLDate"].ToString();

                //-----------
                Graphics graphics = e.Graphics;

                graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(10, 10, 50, 50));
                
                /*Font font = new Font("Simplified Arabic Fixed", 10);
                float fontHeight = font.GetHeight();
                String underLine = "-------------------------------------------------------------";
                int startX = 10;
                int startY = 20;
                int Offset = 10;
                Offset += 0;
                Offset = Offset + 15;
                graphics.DrawString("Invoice NO : " + iBLNO, new Font("Simplified Arabic Fixed", 10), new SolidBrush(Color.Black), 15, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString("Sales Man : " + iSalesMan, new Font("Simplified Arabic Fixed", 10), new SolidBrush(Color.Black), 15, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString("Customer : " + iCustomer, new Font("Simplified Arabic Fixed", 10), new SolidBrush(Color.Black), 15, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString("CLOI - Invoice", new Font("Simplified Arabic Fixed", 20), new SolidBrush(Color.Black), startX + 15, startY + Offset);
                Offset = Offset + 30;
                graphics.DrawString(underLine, new Font("Simplified Arabic Fixed", 10), new SolidBrush(Color.Black), 0, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString(DateTime.Now.ToString("d, MMMM, yyyy"), new Font("Simplified Arabic Fixed", 10), new SolidBrush(Color.Black), startX + 15, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString(underLine, new Font("Simplified Arabic Fixed", 10), new SolidBrush(Color.Black), 0, startY + Offset);

                Offset = Offset + 10;
                graphics.DrawString("Item                       Quantity          Price", new Font("Simplified Arabic Fixed", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 10;
                graphics.DrawString(underLine, new Font("Simplified Arabic Fixed", 10), new SolidBrush(Color.Black), 0, startY + Offset);
                Offset = Offset + 10;
                int totalQty = 0;
                double totalVal = 0;
                for (int i = 0; i < bldData.Rows.Count; i++)
                {

                    string item = (i + 1) + " - " + bldData.Rows[i]["Barcode"].ToString();
                    string quantity = bldData.Rows[i]["Qty"].ToString();
                    string price = bldData.Rows[i]["FinalPrice"].ToString();
                    totalQty = totalQty + Convert.ToInt32(bldData.Rows[i]["Qty"].ToString());
                    totalVal = totalVal + Convert.ToDouble(bldData.Rows[i]["FinalPrice"].ToString());
                    graphics.DrawString(item, new Font("Simplified Arabic Fixed", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                    graphics.DrawString(quantity, new Font("Simplified Arabic Fixed", 8), new SolidBrush(Color.Black), startX + 120, startY + Offset);
                    graphics.DrawString(price, new Font("Simplified Arabic Fixed", 8), new SolidBrush(Color.Black), startX + 180, startY + Offset);

                    Offset = Offset + 15;
                }
                graphics.DrawString(underLine, new Font("Simplified Arabic Fixed", 10), new SolidBrush(Color.Black), 0, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString("Total Quantity: " + totalQty.ToString(), new Font("Simplified Arabic Fixed", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString("Total Value: " + totalVal.ToString() +" "+ Settings.getSetting("currency"), new Font("Simplified Arabic Fixed", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 15;*/
            }
            catch (Exception ex)
            {                
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة " + ex.ToString());
            }

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
                customerId = "";
                customerNameLabel.Text = "";
                pictureBox.Image = null;
                pictureBox.InitialImage = null;
                dataGrid.RowCount = 100;
                CurrentLine = 0;
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Connection.GetDataConnection())
                {
                    double total = 0;
                    string msgText = "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT SUM(FinalValue) AS Total, ISNULL(EmpName1, 'NA') AS EmpName1 FROM QBLI WHERE BLDate = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND BLID = " + Settings.getSetting("bliId") + " GROUP BY EmpName1";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add().ColumnName = "Total";
                        dt.Columns.Add().ColumnName = "EmpName1";
                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["Total"] = reader["Total"].ToString();
                            row["EmpName1"] = reader["EmpName1"].ToString();
                            total = total + Convert.ToDouble(reader["Total"].ToString());

                            msgText = msgText + reader["EmpName1"].ToString() + " : " + reader["Total"].ToString() + Environment.NewLine;
                        }

                        msgText = msgText + "----------------- " + total.ToString();
                        MessageBox.Show(msgText);
                    }
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("حصل خطأ يرجى اعادة المحاولة");
            }
        }

        private void posForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                cashButton.PerformClick();
            }
            else
            {
                if (e.KeyCode == Keys.F5)
                {
                    returnButton.PerformClick();
                }
                else
                {
                    if (e.KeyCode == Keys.F6)
                    {
                        customerButton.PerformClick();
                    }
                    else
                    {
                        if (e.KeyCode == Keys.F7)
                        {
                            removeItemButton.PerformClick();
                        }
                    }
                }
            }
        }
    }
}
