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
    public partial class CancelBookingForm : TemplateForm
    {

        SA46Team05BESNETProjectEntities context = new SA46Team05BESNETProjectEntities();
        BindingSource tList = new BindingSource();
        //List<Transaction> tList;

        string nric;

        public string NRIC
        {
            get
            {
                return nric;
            }
            set
            {
                nric = value;
            }
        }

        public CancelBookingForm()
        {
            InitializeComponent();
            BookedDataGridView.DataSource = tList;
            BookedDataGridView.AutoGenerateColumns = false;
        }


        private void SearchMemberBookingButton_Click(object sender, EventArgs e)
        {
            string s = MemberFINTextBox.Text; // try S2403293H
            DateTime today = DateTime.Today;
            DateTime tomorrowDate = today.AddDays(1);
            tomorrowDate = new DateTime(2018, 1, 31); // test using this date
            //tList = context.Transactions.Where(x => x.NRIC == s && x.BookingDate == date).ToList();
            //Transaction t = context.Transactions.FirstOrDefault(x => x.NRIC == s && x.BookingDate == date);
            Member m = context.Members.FirstOrDefault(x => x.NRIC == s);
            if (m is null)
            {
                throw new ItemNotFound(String.Format("No Member with NRIC/FIN {0} found", s));
            }

            foreach (Transaction t in m.Transactions)
            {
                if (t.BookingDate == tomorrowDate)
                {
                    tList.Add(t);
                    //MessageBox.Show(BookedDataGridView.Rows.Count.ToString()); 
                    //DataGridViewRow row = BookedDataGridView.Rows[BookedDataGridView.Rows.Count - 1];
                    //row.Cells["Activity"].Value = context.Facilities.First(x => x.FacilityID == t.FacilityID).Activity;
                    BookedDataGridView.Rows[BookedDataGridView.Rows.Count - 2].Cells["Activity"].Value = context.Facilities.First(x => x.FacilityID == t.FacilityID).Activity;
                }
            }
            //BookedDataGridView.Refresh();
            //BookedDataGridView.DataSource = tList;
        }


        private void BookedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BookedDataGridView.Columns[e.ColumnIndex].Name == "ToCancel" && e.RowIndex > -1)
            {
                DataGridViewCell cell = BookedDataGridView.Rows[e.RowIndex].Cells["ToCancel"];
                if (cell.Value is null)
                    cell.Value = "Cancel";
                else
                    cell.Value = null;
            }

        }

        private void ConfirmCancelBookingButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in BookedDataGridView.Rows)
            //foreach (Transaction t in tList)
            {
                if ((string)row.Cells["ToCancel"].Value == "Cancel")
                {
                    int transId = Int32.Parse(row.Cells["TransactionID"].Value.ToString());
                    Transaction t = context.Transactions.First(x => x.TransactionID == transId);

                    string slotNumber = t.Slot;

                    // Availability = 1 is place is available
                    UpdateAvailabilityTable(t.FacilityID, slotNumber, 1);
                 
                    //context.Transactions.Remove(t);
                    //t.BookingStatus = "Cancelled";

                    context.SaveChanges();
                    tList.Remove(t);
                }
            }
        }

        private void SearchMemberFINButton_Click(object sender, EventArgs e)
        {
            MemberQueryForm memberQueryForm = new MemberQueryForm(this);
            memberQueryForm.ShowDialog();
            MemberFINTextBox.Text = this.NRIC;
        }
    }
    
}
