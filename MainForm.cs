using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POSSystem
{
    public partial class mainForm : Form
    {



        public mainForm()
        {
            InitializeComponent();
        }

        private void settingsMenuItem_Click(object sender, EventArgs e)
        {
            String output = "";

            DialogResult result = System.Windows.Forms.DialogResult.None;

            result = InputBox.Show(
                "Enter Password",
                "Please enter password to show settings",
                "Password",
                out output);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (output == "cloiP@ss123")
                {
                    var settings = new settingsForm();
                    settings.MdiParent = this;
                    settings.Show();
                }
                else
                    MessageBox.Show("Password is incorrect");
            }

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void posMenuItem_Click(object sender, EventArgs e)
        {
            var pos = new posForm();
            pos.MdiParent = this;
            pos.Show();

        }

        private void receiveItemsMenuItem_Click(object sender, EventArgs e)
        {
            var receivedItems = new receiveItemsForm();
            receivedItems.MdiParent = this;
            receivedItems.Show();
        }

        private void transferItemsMenuItem_Click(object sender, EventArgs e)
        {
            var transfers = new TransfersForm();
            transfers.MdiParent = this;
            transfers.Show();
        }

        private void searchItemsMenuItem_Click(object sender, EventArgs e)
        {
            var search = new SearchItemForm();
            search.MdiParent = this;
            search.Show();
        }

        private void تقريرالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customersReport = new CustomersReportForm();
            customersReport.MdiParent = this;
            customersReport.Show();
        }

        private void salesReportMenuItem_Click(object sender, EventArgs e)
        {
            var salesReportForm = new SalesReportForm();
            salesReportForm.MdiParent = this;
            salesReportForm.Show();
        }
    }
}
