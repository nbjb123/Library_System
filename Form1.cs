using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryPrototype
{
    public partial class Form1 : Form
    {
        private bool LibraryButtonClick = false;
        private bool StudyHallButtonClick = false;
        private bool TutorButtonClick = false;
        DateTime time = DateTime.Now;              // Use current time
        string format = "yyyy-MM-dd HH:mm:ss";    // modify the format depending upon input required in the column in database 

        public Form1()
        {
            InitializeComponent();
            btnCheckIn.Hide();
            btnCheckOut.Hide();
            tbxStudentID.Hide();
            btnBack.Hide();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            LibraryButtonClick = true;
            btnCheckIn.Show();
            btnCheckOut.Show();
            tbxStudentID.Show();
            btnBack.Show();
            btnTutoring.Hide();
            btnStudyHall.Hide();

        }

        private void btnStudyHall_Click(object sender, EventArgs e)
        {
            StudyHallButtonClick = true;
            btnCheckIn.Show();
            btnCheckOut.Show();
            tbxStudentID.Show();
            btnBack.Show();
            btnTutoring.Hide();
            btnLibrary.Hide();
        }

        private void btnTutoring_Click(object sender, EventArgs e)
        {
            TutorButtonClick = true;
            btnCheckIn.Show();
            btnCheckOut.Show();
            tbxStudentID.Show();
            btnBack.Show();
            btnStudyHall.Hide();
            btnLibrary.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnCheckIn.Hide();
            btnCheckOut.Hide();
            tbxStudentID.Hide();
            btnBack.Hide();
            btnStudyHall.Show();
            btnLibrary.Show();
            btnTutoring.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

            int studentID = int.Parse(tbxStudentID.Text); 
            AC.sql2 = "SELECT [SportID] FROM Student WHERE [StudentID] = '"+studentID+"'";

            // Getting SportID out of Database 
            AC.cmd.Parameters.Clear();
            AC.cmd.CommandType = CommandType.Text;
            AC.cmd.CommandText = AC.sql2;

            AC.OpenConnectionString();

            AC.rd = AC.cmd.ExecuteReader();

            if (AC.rd.HasRows)
            {
                while (AC.rd.Read())
                {
                    AC.SportID = (int)AC.rd[0];
                    MessageBox.Show("Worked");
                }
            }

            AC.rd.Close();
            AC.CloseConnectionString();


            int SessionID;
            if(LibraryButtonClick == true)
            {
                SessionID = 1;
            }
            else if (StudyHallButtonClick == true)
            {
                SessionID = 2;
            }
            else
            {
                SessionID = 3;
            }


            int ID = AC.SportID;
            int CourseID = 2;

            
            AC.sql = "INSERT INTO Attends ([StudentID], [SessionID], [CourseID], [SportID], TimeIn) VALUES ('"+studentID+"', '"+SessionID+"', '"+CourseID+"', '"+ID+ "', '"+time.ToString(format)+"')";

            AC.cmd.CommandText = AC.sql;

            AC.OpenConnectionString();

            AC.cmd.ExecuteNonQuery();
            MessageBox.Show("You are checked in.");

            AC.CloseConnectionString();


            /*

            int ID = int.Parse(tbxStudentID.Text);
            AC.sql = "INSERT INTO Attends ([StudentID], [SessionID], [CourseID], [ReviewerID], [Time In], [Time Out]) VALUES (@StudentID, @SessionID, @CourseID, @ReviewerID, @Time_In, @Time_Out)";  
            AC.sql2 = "SELECT [SportsID] FROM Student WHERE [StudentID] = @StuID";
            AC.cmd.Parameters.Clear();
            AC.cmd.CommandType = CommandType.Text;
            AC.cmd.CommandText = AC.sql;
            AC.OpenConnectionString();

            if (LibraryButtonClick == true)
            { 
                AC.cmd.Parameters.AddWithValue("@StudentID", ID);
                AC.cmd.Parameters.AddWithValue("@SessionID", 1);
                AC.cmd.Parameters.AddWithValue("@ReviewerID", DBNull.Value);
                AC.cmd.Parameters.AddWithValue("@CourseID", 2);
                AC.cmd.Parameters.AddWithValue("@Time_In", time.ToString());
                AC.cmd.Parameters.AddWithValue("@Time_Out", DBNull.Value);
            }

            else if (StudyHallButtonClick == true)
            {
                AC.cmd.Parameters.AddWithValue("@StudentID", this.tbxStudentID.Text.ToString());
                AC.cmd.Parameters.AddWithValue("@SessionID", 2);
                AC.cmd.Parameters.AddWithValue("@CourseID", null);
                AC.cmd.Parameters.AddWithValue("@Time_In", time);
                AC.cmd.Parameters.AddWithValue("@Time_Out", null);
            }
            else
            {
                AC.cmd.Parameters.AddWithValue("@StudentID", tbxStudentID.Text.ToString());
                AC.cmd.Parameters.AddWithValue("@SessionID", 3);
                AC.cmd.Parameters.AddWithValue("@CourseID", null);
                AC.cmd.Parameters.AddWithValue("@Time_In", time);
                AC.cmd.Parameters.AddWithValue("@Time_Out", null);
            }



            AC.rd = AC.cmd.ExecuteReader();
            AC.cmd.CommandText = AC.sql2;

            if (AC.rd.HasRows)
            {
                while (AC.rd.Read())
                {
                    AC.SportID = (int)AC.rd[6];
                }
                AC.cmd.Parameters.AddWithValue("@ReviewerID", AC.SportID);
            }


                    AC.CloseConnectionString();



            MessageBox.Show("You are Checked In!");

            */
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int studentID = int.Parse(tbxStudentID.Text); 

            AC.sql = "SELECT TOP 1 AttendID FROM Attends WHERE StudentID = '"+studentID+ "' ORDER BY TimeIn DESC;";

            AC.cmd.Parameters.Clear();
            AC.cmd.CommandType = CommandType.Text;
            AC.cmd.CommandText = AC.sql;

            AC.OpenConnectionString();

            AC.rd = AC.cmd.ExecuteReader();

            if (AC.rd.HasRows)
            {
                while (AC.rd.Read())
                {
                    AC.AttendID = (int)AC.rd[0];
                }
            }

            AC.rd.Close();
            AC.CloseConnectionString();

            AC.sql2 = "UPDATE Attends SET TimeOut = '" + time.ToString(format) + "' WHERE AttendID = '" + AC.AttendID + "';"; 

            AC.cmd.Parameters.Clear();
            AC.cmd.CommandType = CommandType.Text;
            AC.cmd.CommandText = AC.sql2;
            AC.OpenConnectionString();

            AC.cmd.ExecuteNonQuery();
            MessageBox.Show("You are checked out.");

            AC.CloseConnectionString();

        }
    }
}


