using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryPrototype
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*
            //Open Connection
            LibraryPrototype.AC.OpenConnectionString();

            MessageBox.Show("The connection is " +
            LibraryPrototype.AC.con.State.ToString(), "Test Connection",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close Connection
            LibraryPrototype.AC.CloseConnectionString();

            MessageBox.Show("The connection is " +
                LibraryPrototype.AC.con.State.ToString(), "Test Connection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            if (string.IsNullOrEmpty(this.tbxUsername.Text.Trim()) || string.IsNullOrEmpty(this.tbxPassword.Text.Trim()))
            {
                MessageBox.Show("The Username or Password Entered is Incorrect.");

                if (this.tbxUsername.CanSelect)
                {
                    this.tbxUsername.Select();
                }

                return;
            }
            AC.sql = "SELECT [First Name], [Last Name], [SportID], [Occupation] FROM Employee WHERE [Username] = '"+username+"' AND [Password] = '"+password+"'";

            AC.cmd.Parameters.Clear();
            AC.cmd.CommandType = CommandType.Text;
            AC.cmd.CommandText = AC.sql;

            AC.OpenConnectionString();

            AC.rd = AC.cmd.ExecuteReader();

            if (AC.rd.HasRows)
            {
                while (AC.rd.Read())
                { 
                    AC.currentFirstName = AC.rd[0].ToString();
                    AC.currentLastName = AC.rd[1].ToString();
                    MessageBox.Show("Hello " + AC.currentFirstName + " " + AC.currentLastName);

                    lblAthletics.CoachName = AC.rd[0].ToString();
                    lblAthletics.Sport = AC.rd[2].ToString();


                    this.tbxUsername.Text = string.Empty;
                    this.tbxPassword.Text = string.Empty;

                    if (AC.rd[2].ToString() != "0")
                    {
                        this.Hide();
                        lblAthletics Ath = new lblAthletics();
                        Ath.ShowDialog();
                        Ath = null;

                        this.Show();
                    }
                    else
                    {

                        this.Hide();
                        CASA ca = new CASA();
                        ca.ShowDialog();
                        ca = null;

                        this.Show();
                        
                    }
                    
                }

                
            }

            else
            {
                MessageBox.Show("Invaild Username or Password.");

                if (this.tbxUsername.CanSelect)
                {
                    this.tbxUsername.Select();
                    
                }
                
            }
            AC.CloseConnectionString();
            this.Hide();
        }

        

    }
}
