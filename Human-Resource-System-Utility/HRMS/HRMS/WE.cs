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
    public partial class WE : Form
    {
        public WE()
        {
            InitializeComponent();
        }

        private void WE_Load(object sender, EventArgs e)
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
            Global.GlobalVar10 = ""; //RESET DESIGNATION
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex]; //USE COLUMN NAME ACCORDING TO DATAGRID

                Global.GlobalVar10 = row.Cells["DESIGNATION"].Value.ToString();
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        //**************************************BUTTONS**************************************

        private void btnAddWE_Click(object sender, EventArgs e)
        {
            CreateNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + Global.GlobalVar9 + "?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DeleteWE(); //DELETE A ROW     
            }
        }

        //**************************************METHODS**************************************

        public void ClearFields()
        {
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
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
                string selectQuery = "SELECT designation AS [DESIGNATION], name_company AS [COMPANY], name_department AS [DEPARTMENT], date_start AS [START DATE], date_end AS [END DATE], base_salary AS [SALARY], ID_assoc FROM tblWE WHERE ID_assoc =" + Global.GlobalVar1 + " ORDER BY date_start";
                OleDbDataAdapter objAdap = new OleDbDataAdapter(selectQuery, objConn);
                DataTable objDt = new DataTable();
                DataSet objDs = new DataSet();
                objAdap.Fill(objDs, "tblWE");

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
                string createQuery = "INSERT INTO tblWE (ID_assoc, designation, name_company, name_department, base_salary, date_start, date_end) VALUES (?,?,?,?,?,?,?)";
                using (OleDbCommand objComm = new OleDbCommand(createQuery, objConn))
                {
                    objComm.CommandType = CommandType.Text;
                    objComm.Parameters.AddWithValue("ID_assoc", Global.GlobalVar1);
                    objComm.Parameters.AddWithValue("designation", textBox5.Text);
                    objComm.Parameters.AddWithValue("name_company", textBox7.Text);
                    objComm.Parameters.AddWithValue("name_department", textBox6.Text);
                    objComm.Parameters.AddWithValue("base_salary", textBox8.Text);
                    objComm.Parameters.AddWithValue("date_start", dateTimePicker1.Text);
                    objComm.Parameters.AddWithValue("date_end", dateTimePicker2.Text);
                    objConn.Open();
                    objComm.ExecuteNonQuery();

                    MessageBox.Show("Record saved!", "Work Experience");
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

        public void DeleteWE() //DELETE A ROW IN THE TABLE
        {
            try
            {
                string executablepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string basepath = (System.IO.Path.GetDirectoryName(executablepath));
                string file = @"\HRMS.mdb"; //DATABASE NAME & EXTENSION
                string dbpath = string.Concat(basepath, file);

                OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath + ";Persist Security Info = False;");

                objConn.Open();
                string deleteQuery = "DELETE * FROM tblWE WHERE designation ='" + Global.GlobalVar10 + "'";
                OleDbCommand objComm = new OleDbCommand(deleteQuery, objConn);
                objComm.ExecuteNonQuery();
                MessageBox.Show("Record deleted!", "Work Experience");
                DisplayTable(); //REFRESH THE DATAGRID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please contact the administrator. \n\n ERROR CODE: \n" + ex.ToString());
            }
        }

    }
}
