using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SA46Team05BESNETProject
{
    public partial class BookingForm : Form
    {
        //To create new Entity class:
        SA46Team05BESNETProjectEntities context = new SA46Team05BESNETProjectEntities();
        Member m = new Member();
        MemberQueryForm memberQueryForm ;

        string name="";
        string nric;

        public string NAME
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

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


        public BookingForm()
        {
            InitializeComponent();
            TomorrowDateLabel.Text = DateTime.Today.AddDays(1).ToString("dd-MM-yyyy");
        }

        private void MemberNameTextBox_TextChanged(object sender, EventArgs e)
        {
            MemberFINTextBox.Clear();

            string memNameText = MemberNameTextBox.Text;

            if (memNameText == "")
            {
                MemberFINTextBox.Text = "";
            }
            else
            {
                foreach (Member mem in context.Members)
                {
                    if (mem.MemberName.Equals(memNameText))
                    {
                        MemberFINTextBox.Text = mem.NRIC.ToString();
                        break;
                    }
                    else
                    {
                        MemberFINTextBox.Text = "NRIC not found. Search-->";
                    }
                }
            }

        }

        private void ClearFormButton_Click(object sender, EventArgs e)
        {
            foreach(Control g in this.Controls)
            {
               if(g is GroupBox)
                {
                    foreach (Control c in g.Controls)
                    {
                        if (c is TextBox)
                            c.Text = String.Empty;
                        if (c is ComboBox)
                            c.Text = String.Empty;
                    }
                }
            }
        }

        private void ActivityNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string activity = ActivityNameComboBox.Text;
            List<Facility> facilityList = context.Facilities.Where(x => x.Activity == activity).ToList();
            List<string> comboBoxList= new List<string>();

            foreach(Facility f in facilityList)
            {
                comboBoxList.Add(f.FacilityID.ToString());
            }
            FacilityIDComboBox.DataSource = comboBoxList;

        }

        private void EditBookingButton_Click(object sender, EventArgs e)
        {
            CancelBookingForm Form = new CancelBookingForm();
            Form.Show();
        }

        private void SearchFINButton_Click(object sender, EventArgs e)
        {

            memberQueryForm = new MemberQueryForm(this);
            memberQueryForm.ShowDialog();
            MemberNameTextBox.Text = this.NAME;

        }


        private void BookButton_Click(object sender, EventArgs e)
        {
            //check for empty fields and valid member entries
            bool fieldsEmpty = false;
            bool correctMember = false;
            int availabilityofFacility = 0;

            List<Member> mCorrect = context.Members.Where(x => x.NRIC != String.Empty).ToList();

            foreach (Control g in this.Controls)
            {
                if (g is GroupBox)
                {
                    foreach (Control c in g.Controls)
                    {
                        if (c is TextBox && c.Text.Equals(String.Empty))
                            fieldsEmpty = true;
                        if (c is ComboBox && c.Text.Equals(String.Empty))
                            fieldsEmpty = true;
                    }
                }
            }

            foreach (Member m in mCorrect)
            {
                if (m.NRIC.ToString() == MemberFINTextBox.Text && m.MemberName.ToString() == MemberNameTextBox.Text)
                {
                    correctMember = true;
                }
            }

            //Add entry into Transactions Table if all fields are filled
            if (!fieldsEmpty && correctMember == true)
            {

                //string to store the input
                string bookingDetails = "";
                //Get last Transaction ID
                int lastID = int.Parse(context.Transactions.OrderByDescending(x => x.TransactionID).Select(y => y.TransactionID).First().ToString());

                //Create new Transaction
                Transaction t = new Transaction();

                t.TransactionID = lastID + 1;
                t.NRIC = MemberFINTextBox.Text;
                t.FacilityID = FacilityIDComboBox.Text;
                t.BookingDate = DateTime.Today.AddDays(1);
                t.Timeslot = TimeSlotComboBox.Text;

                Facility f = context.Facilities.Where(x => x.FacilityID == t.FacilityID).FirstOrDefault();
                t.Price = f.Price;

                availabilityofFacility = CheckAvailabilityTable(t.FacilityID, t.Slot);

                if(availabilityofFacility == 1)
                {
                    //Get SlotNumber from the selected time option in combobox
                    switch (TimeSlotComboBox.Text)
                    {
                        case "09:00-10:00":
                            t.Slot = "Slot1"; break;
                        case "10:00-11:00":
                            t.Slot = "Slot2"; break;
                        case "11:00-12:00":
                            t.Slot = "Slot3"; break;
                        case "12:00-13:00":
                            t.Slot = "Slot4"; break;
                        case "13:00-14:00":
                            t.Slot = "Slot5"; break;
                        case "14:00-15:00":
                            t.Slot = "Slot6"; break;
                        case "15:00-16:00":
                            t.Slot = "Slot7"; break;
                        case "16:00-17:00":
                            t.Slot = "Slot8"; break;
                    }

                    foreach (PropertyInfo propertyInfo in t.GetType().GetProperties())
                    {
                        if (propertyInfo.Name.ToString() != "Facility" && propertyInfo.Name.ToString() != "Member")
                        {
                            bookingDetails += propertyInfo.Name.ToString() + " : " + propertyInfo.GetValue(t, null) + Environment.NewLine;
                        }
                    }
                    DialogResult dialogResult = MessageBox.Show(bookingDetails, "Confirm Booking", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Update Availability Table---Availability = 1 is place is available

                        UpdateAvailabilityTable(t.FacilityID, t.Slot, 0);

                        //Save Changes in database
                        context.Transactions.Add(t);
                        context.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Slot not available!");
                }
            }
            else if (fieldsEmpty && correctMember == true)
            {
                //If there are empty fields, remind user
                MessageBox.Show("Please fill in all fields before booking");
            }
            else
            {
                MessageBox.Show("Please key in correct member details");
            }


        }

        protected void UpdateAvailabilityTable(string FacilityID,string Slot,int availability)
        {
            Availability a = context.Availabilities.Where(x => x.FacilityID == FacilityID).FirstOrDefault();

            switch (Slot)
            {
                case "Slot1":
                    a.Slot1 = availability; break;
                case "Slot2":
                    a.Slot2 = availability; break;
                case "Slot3":
                    a.Slot3 = availability; break;
                case "Slot4":
                    a.Slot4 = availability; break;
                case "Slot5":
                    a.Slot5 = availability; break;
                case "Slot6":
                    a.Slot6 = availability; break;
                case "Slot7":
                    a.Slot7 = availability; break;
                case "Slot8":
                    a.Slot8 = availability; break;
            }
        }

        private int CheckAvailabilityTable(string FacilityID, string Slot)
        {
            int availability;
            Availability a = context.Availabilities.Where(x => x.FacilityID == FacilityID).FirstOrDefault();

            switch (Slot)
            {
                case "Slot1":
                    availability = Convert.ToInt32(a.Slot1); break;
                case "Slot2":
                    availability = Convert.ToInt32(a.Slot2); break;
                case "Slot3":
                    availability = Convert.ToInt32(a.Slot3); break;
                case "Slot4":
                    availability = Convert.ToInt32(a.Slot4); break;
                case "Slot5":
                    availability = Convert.ToInt32(a.Slot5); break;
                case "Slot6":
                    availability = Convert.ToInt32(a.Slot6); break;
                case "Slot7":
                    availability = Convert.ToInt32(a.Slot7); break;
                case "Slot8":
                    availability = Convert.ToInt32(a.Slot8); break;
                default:
                    availability = 0; break;
            }

            return availability;
        }


    }
}
