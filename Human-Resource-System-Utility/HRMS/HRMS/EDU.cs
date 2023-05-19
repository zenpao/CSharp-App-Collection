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
    public partial class EDU : Form
    {
        public EDU()
        {
            InitializeComponent();
        }

        private void EDU_Load(object sender, EventArgs e)
        {
            Application.OpenForms["Dashboard"].Hide(); //HIDE DASHBOARD FORM

            textBox1.Text = Global.GlobalVar2;
            textBox2.Text = Global.GlobalVar3;
            textBox3.Text = Global.GlobalVar4;
            textBox4.Text = Global.GlobalVar5;

            ClearFields();
            DisplayTable();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["Dashboard"].Show(); //SHOW DASHBOARD FORM
            Global.GlobalVar7 = ""; //RESET TOKEN
            Global.GlobalVar8 = 0; //RESET ID_ASSOC
            Global.GlobalVar9 = ""; //RESET SCHOOL NAME
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //GET SELECTED ROW VALUES
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex]; //USE COLUMN NAME ACCORDING TO DATAGRID

                Global.GlobalVar9 = row.Cells["TITLE"].Value.ToString();
            }
        }

        //**************************************BUTTONS**************************************

        private void btnAddEDU_Click(object sender, EventArgs e)
        {
            CreateNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + Global.GlobalVar9 + "?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DeleteEDU(); //DELETE A ROW     
            }
        }

        //**************************************METHODS**************************************

        public void ClearFields()
        {
            comboBox1.Text = "-";
            textBox5.Text = "";
        }

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
                string selectQuery = "SELECT level_school AS [LEVEL], name_school AS [TITLE], date_start AS [START DATE], date_end AS [END DATE], ID_assoc FROM tblEDU WHERE ID_assoc =" + Global.GlobalVar1 + " ORDER BY date_start";
                OleDbDataAdapter objAdap = new OleDbDataAdapter(selectQuery, objConn);
                DataTable objDt = new DataTable();
                DataSet objDs = new DataSet();
                objAdap.Fill(objDs, "tblEDU");

                dataGridView1.DataSource = objDs.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact the administrator. \n\n ERROR CODE: \n" + ex.ToString());
            }
        }

        public void CreateNew()
        {
            string executablepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string basepath = (System.IO.Path.GetDirectoryName(executablepath));
            string file = @"\HRMS.mdb"; //DATABASE NAME & EXTENSION
            string dbpath = string.Concat(basepath, file);

            OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath + ";Persist Security Info = False;");

            try
            {
                string createQuery = "INSERT INTO tblEDU (ID_assoc, level_school, name_school, date_start, date_end) VALUES (?,?,?,?,?)";
                using (OleDbCommand objComm = new OleDbCommand(createQuery, objConn))
                {
                    objComm.CommandType = CommandType.Text;
                    objComm.Parameters.AddWithValue("ID_assoc", Global.GlobalVar1);
                    objComm.Parameters.AddWithValue("level_school", comboBox1.Text);
                    objComm.Parameters.AddWithValue("name_school", textBox5.Text);
                    objComm.Parameters.AddWithValue("date_start", dateTimePicker1.Text);
                    objComm.Parameters.AddWithValue("date_end", dateTimePicker2.Text);
                    objConn.Open();
                    objComm.ExecuteNonQuery();

                    MessageBox.Show("Record saved!", "Education, L&D");
                    ClearFields();
                    DisplayTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact the administrator. \n\n ERROR CODE: \n" + ex.ToString());
            }

            if (objConn.State == ConnectionState.Open) //CLOSE DB CONNECTION AFTER USE
            {
                objConn.Close();
            }
        }

        public void DeleteEDU() //DELETE A ROW IN THE TABLE
        {
            try
            {
                string executablepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string basepath = (System.IO.Path.GetDirectoryName(executablepath));
                string file = @"\HRMS.mdb"; //DATABASE NAME & EXTENSION
                string dbpath = string.Concat(basepath, file);

                OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath + ";Persist Security Info = False;");

                objConn.Open();
                string deleteQuery = "DELETE * FROM tblEDU WHERE name_school ='" + Global.GlobalVar9 + "'";
                OleDbCommand objComm = new OleDbCommand(deleteQuery, objConn);
                objComm.ExecuteNonQuery();
                MessageBox.Show("Record deleted!", "Education, L&D");
                DisplayTable(); //REFRESH THE DATAGRID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact the administrator. \n\n ERROR CODE: \n" + ex.ToString());
            }
        }

    }
}
