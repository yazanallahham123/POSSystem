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
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }


        private void goBtn_Click(object sender, EventArgs e)
        {
            string fromDate = fromDatePicker.Text;
            string toDate = toDatePicker.Text;
            string blid = Settings.getSetting("bliId");

            
            {
                SqlConnection conn = Connection.GetDataConnection();               
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                if (blid == "91")
                {
                    cmd.CommandText = "select qbld.blno as [رقم الفاتورة], qbld.barcode as [الباركود], qbld.bldate as [التاريخ], " +
                    "mti.computerno as [رقم الكمبيوتر], isoutput as [مبيعات], qty as [الكمية], finalprice as [سعر البيع], finalprice* qty " +
"as [القيمة الإجمالية], mti.EndUser as [سعر البطاقة], 0 as [حقيبة] "+
" " +
"    from qbld inner join mti on mti.computerno = qbld.computerno " +
"     INNER JOIN BSR ON BSR.BLID = QBLD.BLID " +
"    where BSR.BSTID = 5 " +
"    AND BSR.BLID = 91 " +
"and BLDate between '" + fromDate + "' and '" + toDate + "'";

                }
                else
                {



                    cmd.CommandText =

"select qbld.blno as [رقم الفاتورة], qbld.barcode as [الباركود], qbld.bldate as [التاريخ], mti.computerno as [رقم الكمبيوتر], isoutput as [مبيعات], qty * (case when qbld.isOutput = 1 then 1 else -1 end) as [الكمية] , finalprice * (case when qbld.isOutput = 1 then 1 else -1 end) as [سعر القطعة], (finalprice * qty) * (case when qbld.isOutput = 1 then 1 else -1 end) as [القيمة الإجمالية], mti.EndUser * (case when qbld.isOutput = 1 then 1 else -1 end) " +
"as [سعر البطاقة],   " +
"(case when qbld.ItemName like '%bag%' then 1 else 0 end) as [حقيبة] " +
"                         " +

        "from qbld inner join mti on mti.computerno = qbld.computerno " +
        "where blid = " + blid + " " +
        "and BLDate between '" + fromDate + "' and '" + toDate + "'";



                }

                SqlDataReader rd = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandType = CommandType.Text;

                if (blid == "91")
                {
                    cmd2.CommandText =
                    "                    select total as [الإجمالي] from " +
                    "                    (select " +
"                    sum(case when isoutput = 1 then finalprice else (finalprice * -1) end) as total, " +
"sum( " +
"case when isoutput = 1 then " +
"(case when(((mti.enduser - finalprice) * 100) / mti.enduser) = 0 then((finalprice * qty)* 0.30) else " +
"                        ((finalprice * qty) * 0.25) end " +
") " +
"else " +
"                        ((case when(((mti.enduser - finalprice) * 100) / mti.enduser) = 0 then((finalprice * qty) * 0.30) else " +
"                        ((finalprice * qty) * 0.25) end " +
") *-1) " +
"end)     as agenttotal " +
" " +
"    from qbld inner join mti on mti.computerno = qbld.computerno " +
"     INNER JOIN BSR ON BSR.BLID = QBLD.BLID " +
"    where BSR.BSTID = 5 " +
" " +
"    AND BSR.BLID = 91" +
"and BLDate between '" + fromDate + "' and '" + toDate + "') as k";
                }
                else
                {
                    cmd2.CommandText =
"select * from " +
" (select sum((finalprice * qty) * (case when qbld.isOutput = 1 then 1 else -1 end)) as [الإجمالي] " +

        "from qbld inner join mti on mti.computerno = qbld.computerno " +
        "where blid = " + blid + " " +
        "and BLDate between '" + fromDate + " 00:00:00.000' and '" + toDate + " 23:59:59.999' ) as k";
                }
                SqlDataReader rd2 = cmd2.ExecuteReader();

                DataTable dt2 = new DataTable();
                dt2.Load(rd2);
                dataGridView2.DataSource = dt2;
                dataGridView2.ReadOnly = true;


                conn.Close();
            }
        }
    }
}
