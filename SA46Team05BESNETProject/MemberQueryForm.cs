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
    public partial class MemberQueryForm : Form
    {
        SA46Team05BESNETProjectEntities context = new SA46Team05BESNETProjectEntities();
        BindingList<Member> MemberList = new BindingList<Member>();

        BookingForm frm;
        CancelBookingForm frm2;

        public MemberQueryForm()
        {
            InitializeComponent();
        }

        public MemberQueryForm(BookingForm callingForm):this()
        {
            frm = callingForm;

        }

        public MemberQueryForm(CancelBookingForm callingForm) : this()
        {
            frm2 = callingForm;

        }

        private void MemberQueryForm_Load(object sender, EventArgs e)
        {
            MemberQueryDataGridView.AutoGenerateColumns = false;
            var q = from x in context.Members select x;

            foreach(Member member in q)
            {
                MemberList.Add(member);
            }

            MemberQueryDataGridView.DataSource = MemberList;
            
        }

        private void SelectMemberButton_Click(object sender, EventArgs e)
        {


            if (MemberQueryDataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < MemberQueryDataGridView.Rows.Count; i++)
                {
                    int NameColumn = 0;
                    int NRICcolumn = 1;
                    string IC = MemberQueryDataGridView.SelectedRows[i].Cells[NRICcolumn].Value.ToString();
                    string Name = MemberQueryDataGridView.SelectedRows[i].Cells[NameColumn].Value.ToString();

                    PopulateNameAndIC(IC, Name);
                    this.Close();
                    break;
                }
            }
            else
            {
                MessageBox.Show("Please Select One Member!");
            }
           
        }

        private void PopulateNameAndIC(string IC, string Name)
        {
            if (frm is null)
            {
                frm2.NRIC = IC;
            }
            else
            {
                frm.NAME = Name;
            }

        }


    }
}
