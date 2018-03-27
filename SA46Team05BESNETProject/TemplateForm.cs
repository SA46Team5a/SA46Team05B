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
    public partial class TemplateForm : Form
    {
        SA46Team05BESNETProjectEntities context = new SA46Team05BESNETProjectEntities();

        public TemplateForm()
        {
            InitializeComponent();
        }


        //To update availability table to 1 or 0 when booking or cancel
        protected void UpdateAvailabilityTable(string FacilityID, string Slot, int availability)
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

        //Check availability = 1 or 0 in Table
        protected int CheckAvailabilityTable(string FacilityID, string Slot)
        {
            int availability;
            Availability a = context.Availabilities.Where(x => x.FacilityID == FacilityID).FirstOrDefault();

            Dictionary<string, int> dict = new Dictionary<string, int>();

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
