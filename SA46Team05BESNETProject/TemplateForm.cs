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

        private void TemplateForm_Load(object sender, EventArgs e)
        {

        }

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
    }
}
