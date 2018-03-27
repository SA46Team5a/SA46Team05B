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
    public partial class MemberMaintenanceForm :Form
    {
        int posn = 0;
      

        public MemberMaintenanceForm()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(this.timer1_Tick);
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var timenow = DateTime.Now;


            label1.Text = timenow.ToString();
        }

        private void MemberMaintenanceForm_Load(object sender, EventArgs e)
        {

        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SA46Team05BESNETProjectEntities context = new SA46Team05BESNETProjectEntities();
                Member M = context.Members.Where(X => X.NRIC == NRICTextBox.Text).First();
                M.MemberName = MemberNameTextBox.Text;
                M.Gender = GenderComboBox.Text;
                M.Age = Convert.ToInt32(AgeTextBox.Text);
                M.Phone = PhoneNumberTextBox.Text;
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Error!\nPlease try again.");
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {


                SA46Team05BESNETProjectEntities context = new SA46Team05BESNETProjectEntities();
                Member M = new Member();
                M.MemberName = MemberNameTextBox.Text;
                M.NRIC = NRICTextBox.Text;
                M.Gender = GenderComboBox.Text;
                M.Age = Convert.ToInt32(AgeTextBox.Text);
                M.Phone = PhoneNumberTextBox.Text;
                context.Members.Add(M);

                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Error!\nPlease try again.");
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                SA46Team05BESNETProjectEntities context = new SA46Team05BESNETProjectEntities();
                Member M = context.Members.Where(x => x.NRIC == NRICTextBox.Text).First();

                context.Members.Remove(M);
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Error!\nPlease try again.");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the NRIC/FIN");
                }
                else
                {
                    SA46Team05BESNETProjectEntities context = new SA46Team05BESNETProjectEntities();
                    Member M = context.Members.Where(x => x.NRIC == SearchTextBox.Text.Trim()).First();

                    Show(M);
                    List<Member> SortList = context.Members.ToList();
                    for (int i = 0; i < SortList.Count(); i++)
                    {
                        M = SortList[i];
                        if (M.NRIC == SearchTextBox.Text)
                        {
                            posn = i;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a correct NRIC/FIN");
            }
        }

        private void Show(Member M)
        {
            NRICTextBox.Text = M.NRIC;
            MemberNameTextBox.Text = M.MemberName;
            GenderComboBox.Text = M.Gender;
            AgeTextBox.Text = M.Age.ToString();
            PhoneNumberTextBox.Text = M.Phone;
        }

        private void PreviousButton_Click_1(object sender, EventArgs e)
        {
            if (posn > 0)
            {
                posn--;
            }

            SA46Team05BESNETProjectEntities context = new SA46Team05BESNETProjectEntities();
            Member M = new Member();

            List<Member> cLst = context.Members.ToList();
            if (posn >= 0)
            {
                M = cLst[posn];
                Show(M);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            SA46Team05BESNETProjectEntities context = new SA46Team05BESNETProjectEntities();
            List<Member> cLst = context.Members.ToList();
            if (posn < cLst.Count() - 1)
            {
                posn++;
            }


            Member M = new Member();


            if (posn < cLst.Count())
            {
                M = cLst[posn];
                Show(M);
            }
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            SA46Team05BESNETProjectEntities context = new SA46Team05BESNETProjectEntities();
            Member M = new Member();

            List<Member> cLst = context.Members.ToList();
            posn = 0;
            M = cLst[posn];
            Show(M);
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            SA46Team05BESNETProjectEntities context = new SA46Team05BESNETProjectEntities();
            Member M = new Member();

            List<Member> cLst = context.Members.ToList();
            posn = cLst.Count() - 1;
            M = cLst[posn];
            Show(M);
        }


        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {


        }
    }
}
