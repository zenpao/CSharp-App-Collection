using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Required to access MS Database
using System.Data.OleDb;
//Required to open file explorer
using System.Diagnostics;
using System.IO;

namespace HRMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Application.OpenForms["Auth"].Hide(); //HIDE LOGIN FORM

            DisplayTable();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.OpenForms["Auth"].Show(); //SHOW DASHBOARD FORM
            Global.GlobalVar7 = ""; //RESET TOKEN
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //GET SELECTED ROW VALUES
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex]; //USE COLUMN NAME ACCORDING TO DATAGRID

                Global.GlobalVar1 = Convert.ToInt32(row.Cells["ID_pds"].Value.ToString()); //GET SELECTED ROW ID
                Global.GlobalVar2 = row.Cells["LAST NAME"].Value.ToString();
                Global.GlobalVar3 = row.Cells["FIRST NAME"].Value.ToString();
                Global.GlobalVar4 = row.Cells["MIDDLE"].Value.ToString();
                Global.GlobalVar5 = row.Cells["SUFFIX"].Value.ToString();
                Global.GlobalVar6 = row.Cells["DESIGNATION"].Value.ToString();
            }
        }

        //**************************************TOOLSTRIP**************************************

        private void addPersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.GlobalVar7 = "t0kenCR3ATE"; //THIS IS FOR TOKEN FOR FORMS TO DISTINGUISH USAGE.
            new PDS().Show(); //SHOW PDS FORM
        }

        private void deletePersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + Global.GlobalVar3 + "?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DeletePDS(); //DELETE A ROW
            }
        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.GlobalVar1 == 0)
            {
                MessageBox.Show("Ӽ WARNING: Make sure you selected from the table for updating \n or create a new entry else close this form.", "Personal Data Sheet", MessageBoxButtons.OK);
            }
            else
            {
                Global.GlobalVar7 = "t0kenUPD4TE"; //THIS IS FOR TOKEN FOR FORMS TO DISTINGUISH USAGE.
                new PDS().Show(); //SHOW PDS FORM
            }
        }

        private void educationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.GlobalVar1 == 0)
            {
                MessageBox.Show("Ӽ WARNING: Make sure you selected from the table for updating \n or create a new entry else close this form.", "Education", MessageBoxButtons.OK);
            }
            else
            {
                new WE().Show(); //SHOW EDU FORM
            }
        }

        private void workExperienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.GlobalVar1 == 0)
            {
                MessageBox.Show("Ӽ WARNING: Make sure you selected from the table for updating \n or create a new entry else close this form.", "Education", MessageBoxButtons.OK);
            }
            else
            {
                new WE().Show(); //SHOW Work Experience FORM
            }
        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature available soon.");
        }

        private void leaveCreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature available soon.");
        }

        private void pDSResumeFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string executablepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string basepath = (System.IO.Path.GetDirectoryName(executablepath));
            string folder = @"\pds"; //FOLDER NAME
            string folderpath = string.Concat(basepath, folder);
            
            Process.Start("explorer.exe", folderpath);
        }

        private void sALNFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string executablepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string basepath = (System.IO.Path.GetDirectoryName(executablepath));
            string folder = @"\saln"; //FOLDER NAME
            string folderpath = string.Concat(basepath, folder);

            Process.Start("explorer.exe", folderpath);
        }

        private void payrollFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string executablepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string basepath = (System.IO.Path.GetDirectoryName(executablepath));
            string folder = @"\payroll"; //FOLDER NAME
            string folderpath = string.Concat(basepath, folder);

            Process.Start("explorer.exe", folderpath);
        }

        //**************************************BUTTONS**************************************

        private void btnAddPDS_Click(object sender, EventArgs e)
        {
            Global.GlobalVar7 = "t0kenCR3ATE"; //THIS IS FOR TOKEN FOR FORMS TO DISTINGUISH USAGE.
            new PDS().Show(); //SHOW PDS FORM
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + Global.GlobalVar3 + "?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DeletePDS(); //DELETE A ROW     
            }
        }

        private void btnShowPDS_Click(object sender, EventArgs e)
        {
            if (Global.GlobalVar1 == 0)
            {
                MessageBox.Show("Ӽ WARNING: Make sure you selected from the table for updating \n or create a new entry else close this form.", "Personal Data Sheet", MessageBoxButtons.OK);
            }
            else
            {
                Global.GlobalVar7 = "t0kenUPD4TE"; //THIS IS FOR TOKEN FOR FORMS TO DISTINGUISH USAGE.
                new PDS().Show(); //SHOW PDS FORM
            }
        }

        private void btnEDU_Click(object sender, EventArgs e)
        {
            if (Global.GlobalVar1 == 0)
            {
                MessageBox.Show("Ӽ WARNING: Make sure you selected from the table for updating \n or create a new entry else close this form.", "Education", MessageBoxButtons.OK);
            }
            else
            {
                new EDU().Show(); //SHOW EDU FORM
            }
        }

        private void btnWE_Click(object sender, EventArgs e)
        {
            if (Global.GlobalVar1 == 0)
            {
                MessageBox.Show("Ӽ WARNING: Make sure you selected from the table for updating \n or create a new entry else close this form.", "Education", MessageBoxButtons.OK);
            }
            else
            {
                new WE().Show(); //SHOW Work Experience FORM
            }
        }

        private void btnShowSalary_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature available soon.");
        }

        private void btnShowLeave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature available soon.");
        }

        private void btnShowSALN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature available soon.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisplaySearch();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayTable();
        }

        //**************************************METHODS**************************************

        public void DisplayTable() //DISPLAY CONTENT OF A TABLE
        {
            try
            {
                string executablepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string basepath = (System.IO.Path.GetDirectoryName(executablepath));
                string file = @"\HRMS.mdb"; //DATABASE NAME & EXTENSION
                string dbpath = string.Concat(basepath, file);

                OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath + ";Persist Security Info = False;");

                objConn.Open();
                string selectQuery = "SELECT designation AS [DESIGNATION], last_name AS [LAST NAME], first_name AS [FIRST NAME], middle_name AS [MIDDLE], suffix_name AS [SUFFIX], ID_pds FROM tblPDS";
                OleDbDataAdapter objAdap = new OleDbDataAdapter(selectQuery, objConn);
                DataTable objDt = new DataTable();
                DataSet objDs = new DataSet();
                objAdap.Fill(objDs, "tblPDS");

                dataGridView1.DataSource = objDs.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact the administrator. \n\n ERROR CODE: \n" + ex.ToString());
            }
        }

        public void DisplaySearch() //DISPLAY SEARCH RESULT IN DATAGRID
        {
            try
            {
                string executablepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string basepath = (System.IO.Path.GetDirectoryName(executablepath));
                string file = @"\HRMS.mdb"; //DATABASE NAME & EXTENSION
                string dbpath = string.Concat(basepath, file);

                OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath + ";Persist Security Info = False;");

                objConn.Open();
                string selectQuery = "SELECT designation AS [DESIGNATION], last_name AS [LAST NAME], first_name AS [FIRST NAME], middle_name AS [MIDDLE], suffix_name AS [SUFFIX], ID_pds FROM tblPDS WHERE first_name LIKE '%" +
                textSearch.Text + "%' OR last_name LIKE '%" + textSearch.Text + "%' OR designation LIKE '%" + textSearch.Text + "%'";
                OleDbDataAdapter objAdap = new OleDbDataAdapter(selectQuery, objConn);
                DataTable objDt = new DataTable();
                DataSet objDs = new DataSet();
                objAdap.Fill(objDs, "tblPDS"); //TABLE NAME FROM THE DATABASE

                dataGridView1.DataSource = objDs.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact the administrator. \n\n ERROR CODE: \n" + ex.ToString());
            }
        }

        public void DeletePDS() //DELETE A ROW IN THE TABLE
        {
            try
            {
                string executablepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string basepath = (System.IO.Path.GetDirectoryName(executablepath));
                string file = @"\HRMS.mdb"; //DATABASE NAME & EXTENSION
                string dbpath = string.Concat(basepath, file);

                OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath + ";Persist Security Info = False;");

                objConn.Open();
                string deleteQuery = "DELETE * FROM tblPDS WHERE ID_pds =" + Global.GlobalVar1 + "";
                OleDbCommand objComm = new OleDbCommand(deleteQuery, objConn);
                objComm.ExecuteNonQuery();
                MessageBox.Show("Record deleted!", "Dashboard");
                DisplayTable(); //REFRESH THE DATAGRID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact the administrator. \n\n ERROR CODE: \n" + ex.ToString());
            }
        }
    }
}
