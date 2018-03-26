using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team05BESNETProject
{
    public partial class SportsFacilitiesMaintenanceForm : Form
    {
        SqlConnection con;
        SqlDataAdapter adap;
        System.Data.DataSet ds;
        SqlCommandBuilder cmb;
        SqlCommand cm;
        public SportsFacilitiesMaintenanceForm()
        {
            InitializeComponent();
        }

        private void SportsFacilitiesMaintenanceForm_Load(object sender, EventArgs e)
        {
            var today = DateTime.Now;
            
            TomorrowDateLabel.Text =today .ToString("dd/MM/yyyy");
            this.KeyPreview = true;
        }
        private void SportsFacilitiesMaintenanceForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.D)
            {
                DisplayFacilityButton.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.U)
            {
                UpdateAvailiabilityButton.PerformClick();
            }
        }

        private void DisplayFacilityButton_Click_1(object sender, EventArgs e)
        {
            string updateFacility = "select * from Facilities";
            con = new SqlConnection();
            con.ConnectionString = @"data source=(local); initial catalog=SA46Team05BESNETProject;integrated security=SSPI";
            cm = new SqlCommand();
            cm.CommandText = updateFacility;
            cm.Connection = con;
            con.Open();
            adap = new SqlDataAdapter(cm);
            ds = new DataSet();
            adap.Fill(ds, "1");
            FacilitiesDataGridView.DataSource = ds.Tables[0];
        }

        private void UpdateAvailiabilityButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                cmb = new SqlCommandBuilder(adap);
                adap.Update(ds, "1");
            }
            catch
            {
                MessageBox.Show("Please search the facility table before click update");
            }
        }
    }
}
