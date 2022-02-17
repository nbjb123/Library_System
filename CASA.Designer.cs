
namespace LibraryPrototype
{
    partial class CASA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnTutoring = new System.Windows.Forms.Button();
            this.btnStudyHall = new System.Windows.Forms.Button();
            this.lblCoachName = new System.Windows.Forms.Label();
            this.lblCoach = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.libraryDBDataSet = new LibraryPrototype.LibraryDBDataSet();
            this.attendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendsTableAdapter = new LibraryPrototype.LibraryDBDataSetTableAdapters.AttendsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTutoring
            // 
            this.btnTutoring.Location = new System.Drawing.Point(628, 175);
            this.btnTutoring.Name = "btnTutoring";
            this.btnTutoring.Size = new System.Drawing.Size(92, 35);
            this.btnTutoring.TabIndex = 15;
            this.btnTutoring.Text = "Tutoring";
            this.btnTutoring.UseVisualStyleBackColor = true;
            this.btnTutoring.Click += new System.EventHandler(this.btnTutoring_Click);
            // 
            // btnStudyHall
            // 
            this.btnStudyHall.Location = new System.Drawing.Point(473, 175);
            this.btnStudyHall.Name = "btnStudyHall";
            this.btnStudyHall.Size = new System.Drawing.Size(92, 35);
            this.btnStudyHall.TabIndex = 14;
            this.btnStudyHall.Text = "Study Hall";
            this.btnStudyHall.UseVisualStyleBackColor = true;
            this.btnStudyHall.Click += new System.EventHandler(this.btnStudyHall_Click);
            // 
            // lblCoachName
            // 
            this.lblCoachName.AutoSize = true;
            this.lblCoachName.Location = new System.Drawing.Point(528, 106);
            this.lblCoachName.Name = "lblCoachName";
            this.lblCoachName.Size = new System.Drawing.Size(24, 20);
            this.lblCoachName.TabIndex = 12;
            this.lblCoachName.Text = "---";
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Location = new System.Drawing.Point(453, 106);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(67, 20);
            this.lblCoach.TabIndex = 10;
            this.lblCoach.Text = "Falculty:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(155, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(745, 353);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(20, 19);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(109, 39);
            this.btnSignOut.TabIndex = 8;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Library";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendsBindingSource
            // 
            this.attendsBindingSource.DataMember = "Attends";
            this.attendsBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // attendsTableAdapter
            // 
            this.attendsTableAdapter.ClearBeforeFill = true;
            // 
            // CASA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 676);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTutoring);
            this.Controls.Add(this.btnStudyHall);
            this.Controls.Add(this.lblCoachName);
            this.Controls.Add(this.lblCoach);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSignOut);
            this.Name = "CASA";
            this.Text = "CASA";
            this.Load += new System.EventHandler(this.CASA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTutoring;
        private System.Windows.Forms.Button btnStudyHall;
        private System.Windows.Forms.Label lblCoachName;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button button1;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource attendsBindingSource;
        private LibraryDBDataSetTableAdapters.AttendsTableAdapter attendsTableAdapter;
    }
}