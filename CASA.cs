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
    public partial class CASA : Form
    {
        public CASA()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void CASA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Attends' table. You can move, or remove it, as needed.
            this.attendsTableAdapter.Fill(this.libraryDBDataSet.Attends);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Attends WHERE SessionID = 1;", "Data Source=DESKTOP-HI0FVC7;Initial Catalog=LibraryDB;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds, "Attends");
            dataGridView1.DataSource = ds.Tables["Attends"].DefaultView;
        }

        private void btnStudyHall_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Attends WHERE SessionID = 2;", "Data Source=DESKTOP-HI0FVC7;Initial Catalog=LibraryDB;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds, "Attends");
            dataGridView1.DataSource = ds.Tables["Attends"].DefaultView;
        }

        private void btnTutoring_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Attends WHERE SessionID = 3;", "Data Source=DESKTOP-HI0FVC7;Initial Catalog=LibraryDB;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds, "Attends");
            dataGridView1.DataSource = ds.Tables["Attends"].DefaultView;
        }
    }
}
