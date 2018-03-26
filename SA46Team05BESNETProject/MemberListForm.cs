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
    public partial class MemberListForm : Form
    {
        public MemberListForm()
        {
            InitializeComponent();
        }

        private void MemberListForm_Load(object sender, EventArgs e)
        {
            DataSet2 ds = new DataSet2();
            DataSet2TableAdapters.MembersTableAdapter  ma = new DataSet2TableAdapters.MembersTableAdapter();
            ma.Fill(ds.Members);

            memberreport cr = new memberreport();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
