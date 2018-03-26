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
    public partial class MainWindow : Form
    {
        BookingForm booking;
        QueryForm query;
        CancelBookingForm cancelBooking;
        SportsFacilitiesMaintenanceForm facilityMaintain;
        MemberMaintenanceForm memberMaintain;
        MemberListForm memberList;
        ReceiptForm receipt;
        totalsalesform totalSales;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            if(booking ==null)
            {
                booking = new BookingForm();
                booking.MdiParent = this;
                booking.Dock = DockStyle.Fill;
                booking.Show();
                booking.FormClosed += Booking_FormClosed;
            }
            else
            {
                booking.Activate();
            }
        }

        private void Booking_FormClosed(object sender, FormClosedEventArgs e)
        {
            booking = null;
        }

        private void AvailabilityQueryButton_Click(object sender, EventArgs e)
        {
            if(query ==null)
            {
                query = new QueryForm ();
                query.MdiParent = this;
                query.Dock = DockStyle.Fill;
                query.Show();
                query.FormClosed += Query_FormClosed;
            }
            else
            {
                query.Activate();
            }
        }

        private void Query_FormClosed(object sender, FormClosedEventArgs e)
        {
            query = null;
        }

        private void BookingCancellationButton_Click(object sender, EventArgs e)
        {
            if (cancelBooking == null)
            {
                cancelBooking  = new CancelBookingForm();
                cancelBooking.MdiParent = this;
                cancelBooking.Dock = DockStyle.Fill;
                cancelBooking.Show();
                cancelBooking.FormClosed += CancelBooking_FormClosed;
            }
            else
            {
                cancelBooking .Activate();
            }
        }

        private void CancelBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            cancelBooking = null;
        }

        private void FacilityMaintenanceButton_Click(object sender, EventArgs e)
        {
            if(facilityMaintain ==null)
            {
                facilityMaintain = new SportsFacilitiesMaintenanceForm();
                facilityMaintain.MdiParent = this;
                facilityMaintain.Dock = DockStyle.Fill;
                facilityMaintain.Show();
                facilityMaintain.FormClosed += FacilityMaintain_FormClosed;
            }
            else
            {
                facilityMaintain .Activate();
            }
        }

        private void FacilityMaintain_FormClosed(object sender, FormClosedEventArgs e)
        {
            facilityMaintain = null;
        }

        private void MemberMaintenanceButton_Click(object sender, EventArgs e)
        {
            if(memberMaintain ==null)
            {
                memberMaintain = new MemberMaintenanceForm();
                memberMaintain.MdiParent = this;
                memberMaintain.Dock = DockStyle.Fill;
                memberMaintain.Show();
                memberMaintain.FormClosed += MemberMaintain_FormClosed;
            }
            else
            {
                memberMaintain .Activate();
            }
        }

        private void MemberMaintain_FormClosed(object sender, FormClosedEventArgs e)
        {
            memberMaintain = null;
        }

        private void BookingButton_MouseEnter(object sender, EventArgs e)
        {
            if(BookingButton .Text==((Button)sender).Text )
            {
                toolStripStatusLabel1.Text = "Please click and fill up member,facilities and booking details to book a slot";
            }
            else if(AvailavbilityQueryButton .Text == ((Button)sender).Text)
            {
                toolStripStatusLabel1.Text = "Time slot availibility can be found based on activities and slots search";
            }
            else if (BookingCancellationButton .Text == ((Button)sender).Text)
            {
                toolStripStatusLabel1.Text = "Booking can be cancelled based on members' NRIC/FIN search";
            }
            else if (FacilityMaintenanceButton .Text == ((Button)sender).Text)
            {
                toolStripStatusLabel1.Text = "Facility name, activities booking price can be updated here";
            }
            else if (MemberMaintenanceButton .Text == ((Button)sender).Text)
            {
                toolStripStatusLabel1.Text = "Members' particulars can be created and updated here";
            }
            else if (CRMemberListButton .Text == ((Button)sender).Text)
            {
                toolStripStatusLabel1.Text = "Crystal Report containing members' particulars will be generated";
            }
            else if (CRReceiptButton .Text == ((Button)sender).Text)
            {
                toolStripStatusLabel1.Text = "A booking recipt Crystal Report will be generated ";
            }
            else if (CRTotalSalesButton.Text == ((Button)sender).Text)
            {
                toolStripStatusLabel1.Text = "Sales Crystal Report indicating total sales versus facilityID will be generated";
            }
        }

        private void BookingButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ready";
            KeyPreview = true;
            booking = new BookingForm();
            booking.MdiParent = this;
            booking.Dock = DockStyle.Fill;
            booking.Show();
            booking.FormClosed += Booking_FormClosed;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.B)
            {
                BookingButton .PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.A)
            {
                AvailavbilityQueryButton .PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                BookingCancellationButton .PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.F)
            {
                FacilityMaintenanceButton .PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.M)
            {
                MemberMaintenanceButton.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.R)
            {
                CRMemberListButton .PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.E)
            {
                CRReceiptButton.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.T)
            {
                CRTotalSalesButton.PerformClick();
            }
        }

        private void CRMemberListButton_Click(object sender, EventArgs e)
        {
            
            if (memberList == null)
            {
                memberList = new MemberListForm();
                memberList.MdiParent = this;
                memberList.Dock = DockStyle.Fill;
                memberList.Show();
                memberList.FormClosed += MemberList_FormClosed;
            }
            else
            {
                memberList.Activate();
            }


        }

        private void MemberList_FormClosed(object sender, FormClosedEventArgs e)
        {
            memberList = null;
        }

        private void CRReceiptButton_Click(object sender, EventArgs e)
        {
           
            if (receipt == null)
            {
                receipt = new ReceiptForm();
                receipt.MdiParent = this;
                receipt.Dock = DockStyle.Fill;
                receipt.Show();
                receipt.FormClosed += Receipt_FormClosed;
            }
            else
            {
                receipt.Activate();
            }
        }

        private void Receipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            receipt = null;
        }

        private void CRTotalSalesButton_Click(object sender, EventArgs e)
        {
          
            if (totalSales == null)
            {
                totalSales = new totalsalesform();
                totalSales.MdiParent = this;
                totalSales.Dock = DockStyle.Fill;
                totalSales.Show();
                totalSales.FormClosed += TotalSales_FormClosed;
            }
            else
            {
                totalSales.Activate();
            }
        }

        private void TotalSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            totalSales = null;
        }
    }
}
