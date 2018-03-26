using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team05BESNETProject
{
    public partial class totalsalesform : Form
    {
        public totalsalesform()
        {
            InitializeComponent();
        }

        private void totalsalesform_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.DataTable1TableAdapter ma = new DataSet1TableAdapters.DataTable1TableAdapter();
            ma.Fill(ds.DataTable1);

            TotalSalesReport cr = new TotalSalesReport();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
