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
    public partial class QueryForm : Form
    {

        public QueryForm()
        {
            InitializeComponent();

        }

        SA46Team05BESNETProjectEntities context = new SA46Team05BESNETProjectEntities();
        SqlConnection con;
        SqlDataAdapter adap;
        System.Data.DataSet ds;
        SqlCommandBuilder cmb;
        SqlCommand cm;
        private string Query(string activity, string slot)
        {
            string Query = "select FacilityID " + slot + " from Availabilities where " + activity;
            return Query;
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string activity = "";
            string slot = "";
            string tennis = " FacilityID= 'T-1' or FacilityID ='T-2' or FacilityID ='T-3' or FacilityID ='T-4'";
            string tableTennis = "FacilityID='TT-1' or FacilityID = 'TT-2' or FacilityID = 'TT-3'  or FacilityID = 'TT-4'";
            string badminton = "FacilityID='B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
            string basketBall = "FacilityID='BB-1' or FacilityID = 'BB-2' or FacilityID = 'BB-3'  or FacilityID = 'BB-4'";
            string allActivity = "FacilityID= 'T-1' or FacilityID ='T-2' or FacilityID ='T-3' or FacilityID ='T-4' or" +
                " FacilityID='TT-1' or FacilityID = 'TT-2' or FacilityID = 'TT-3'  or FacilityID = 'TT-4'" + " or FacilityID='B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'"
                + "or  FacilityID='BB-1' or FacilityID = 'BB-2' or FacilityID = 'BB-3'  or FacilityID = 'BB-4'";

            if (ActivityComboBox.Text == "Tennis")
            {
                activity = tennis;
            }
            else if (ActivityComboBox.Text == "Table Tennis")
            {
                activity = tableTennis;
            }
            else if (ActivityComboBox.Text == "Badminton")
            {
                activity = badminton;
            }
            else if (ActivityComboBox.Text == "Basketball")
            {
                activity = basketBall;
            }
            else if (ActivityComboBox.Text == "")
            {
                activity = allActivity;
            }
            if (TimeSlotComboBox.Text == "09:00-10:00")
            {
                slot = ",Slot1";
            }
            else if (TimeSlotComboBox.Text == "10:00-11:00")
            {
                slot = ",Slot2";
            }
            else if (TimeSlotComboBox.Text == "11:00-12:00")
            {
                slot = ",Slot3";
            }
            else if (TimeSlotComboBox.Text == "12:00-13:00")
            {
                slot = ",Slot4";
            }
            else if (TimeSlotComboBox.Text == "13:00-14:00")
            {
                slot = ",Slot5";
            }
            else if (TimeSlotComboBox.Text == "14:00-15:00")
            {
                slot = ",Slot6";
            }
            else if (TimeSlotComboBox.Text == "15:00-16:00")
            {
                slot = ",Slot7";
            }
            else if (TimeSlotComboBox.Text == "16:00-17:00")
            {
                slot = ",Slot8";
            }
            else if (TimeSlotComboBox.Text == "")
            {
                slot = ",Slot1,Slot2,Slot3,Slot4,Slot5,Slot6,Slot7,Slot8";
            }


            con = new SqlConnection();
            con.ConnectionString = @"data source=(local); initial catalog=SA46Team05BESNETProject;integrated security=SSPI";
            cm = new SqlCommand();

            cm.CommandText = Query(activity, slot);
            cm.Connection = con;
            con.Open();
            adap = new SqlDataAdapter(cm);
            ds = new DataSet();
            adap.Fill(ds, "1");
            FacilitiesDataGridView.DataSource = ds.Tables[0];
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmb = new SqlCommandBuilder(adap);
                adap.Update(ds, "1");
            }
            catch
            {
                MessageBox.Show("Please select criteria to search or diaplay the availability table before update");
            }
        }

        private void displayTableButton_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"data source=(local); initial catalog=SA46Team05BESNETProject;integrated security=SSPI";
            cm = new SqlCommand();
            cm.CommandText = "select * from Availabilities";
            cm.Connection = con;
            con.Open();
            adap = new SqlDataAdapter(cm);
            ds = new DataSet();
            adap.Fill(ds, "1");
            FacilitiesDataGridView.DataSource = ds.Tables[0];

        }

        private void QueryForm_KeyDown(object sender, KeyEventArgs e)
        {

        }


    }
}
