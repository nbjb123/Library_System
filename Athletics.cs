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

namespace LibraryPrototype
{
    public partial class lblAthletics : Form
    {

        public static string CoachName;
        public static string Sport; 
        public lblAthletics()
        {
            InitializeComponent();
            lblCoachName.Text = CoachName;
            lblSportName.Text = Sport; 
            
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void btnStudyHall_Click(object sender, EventArgs e)
        {
            int coachID = int.Parse(Sport); 
            SqlDataAdapter da = new SqlDataAdapter("SELECT [StudentID], [TimeIn], [TimeOut] FROM Attends WHERE SessionID = 2 AND SportID = " + coachID + ";", "Data Source=DESKTOP-HI0FVC7;Initial Catalog=LibraryDB;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds, "Attends");
            dataGridView1.DataSource = ds.Tables["Attends"].DefaultView;
        }

        private void btnTutoring_Click(object sender, EventArgs e)
        {
            int coachID = int.Parse(Sport);
            SqlDataAdapter da = new SqlDataAdapter("SELECT [StudentID], [TimeIn], [TimeOut] FROM Attends WHERE SessionID = 3 AND SportID = " + coachID + ";", "Data Source=DESKTOP-HI0FVC7;Initial Catalog=LibraryDB;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds, "Attends");
            dataGridView1.DataSource = ds.Tables["Attends"].DefaultView;
        }
    }
}
