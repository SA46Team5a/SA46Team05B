﻿using System;
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
    public partial class BookingForm : TemplateForm
    {
        //To create new Entity class:
        SA46Team05BESNETProjectEntities context = new SA46Team05BESNETProjectEntities();
        Member m = new Member();
        MemberQueryForm memberQueryForm ;

        string name="";

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
            bool fieldsEmpty = CheckEmptyFields();
            bool correctMember = CheckCorrectMembers();
            int availabilityofFacility = 0;


            //Add entry into Transactions Table if all fields are filled and correct
            if (!fieldsEmpty && correctMember == true)
            {
                //Get last Transaction ID
                int lastID = int.Parse(context.Transactions.OrderByDescending(x => x.TransactionID).Select(y => y.TransactionID).First().ToString());

                //Create new Transaction and Facility
                Transaction t = new Transaction();
                

                t.TransactionID = lastID + 1;
                t.NRIC = MemberFINTextBox.Text;
                t.FacilityID = FacilityIDComboBox.Text;

                Facility f = context.Facilities.Where(x => x.FacilityID == t.FacilityID).FirstOrDefault();
                t.BookingDate = DateTime.Today.AddDays(1);
                t.Timeslot = TimeSlotComboBox.Text;
                t.Price = f.Price;

                //Get t.SlotNumber from the selected time option in combobox
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

                //CheckAvailabilty method inherit from Template Form
                availabilityofFacility = CheckAvailabilityTable(t.FacilityID, t.Slot);

                if(availabilityofFacility == 1)
                {
                    ConfirmBooking(t);
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

        private void ConfirmBooking(Transaction t)
        {
            //string to store the input
            string bookingDetails = "";

            

            //Get Booking details
            foreach (PropertyInfo propertyInfo in t.GetType().GetProperties())
            {
                if (propertyInfo.Name.ToString() != "Facility" && propertyInfo.Name.ToString() != "Member")
                {
                    bookingDetails += propertyInfo.Name.ToString() + " : " + propertyInfo.GetValue(t, null) + Environment.NewLine;
                }
            }

            //Confirm Booking
            DialogResult dialogResult = MessageBox.Show(bookingDetails, "Confirm Booking", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Update Availability Table---Availability = 1 is place is available (inherit from templateform)

                UpdateAvailabilityTable(t.FacilityID, t.Slot, 0);

                //Save Changes in database
                context.Transactions.Add(t);
                context.SaveChanges();
            }
        }

        

        private bool CheckEmptyFields()
        {
            bool fieldsEmpty = false;
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

            return fieldsEmpty;
        }

        private bool CheckCorrectMembers()
        {
            bool correctMember = false;
            List<Member> mCorrect = context.Members.Where(x => x.NRIC != String.Empty).ToList();

            foreach (Member m in mCorrect)
            {
                if (m.NRIC.ToString() == MemberFINTextBox.Text && m.MemberName.ToString() == MemberNameTextBox.Text)
                {
                    correctMember = true;
                }
            }

            return correctMember;
        }
    }
}
