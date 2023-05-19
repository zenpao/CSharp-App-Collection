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
    public partial class PDS : Form
    {
        public PDS()
        {
            InitializeComponent();
        }

        private void PDS_Load(object sender, EventArgs e)
        {
            Application.OpenForms["Dashboard"].Hide(); //HIDE DASHBOARD FORM

            if (Global.GlobalVar7 == "t0kenCR3ATE" | Global.GlobalVar7 == "") //DISTINGUISH USAGE OF FORM BASED ON THE TOKEN
            {
                ClearFields();
                textBox4.Text = "-";
                textBox19.Text = "-";
                textBox20.Text = "-";
                comboBox1.Text = "-";
                comboBox2.Text = "-";
                comboBox3.Text = "-";
                comboBox4.Text = "-";
            }
            else if (Global.GlobalVar7 == "t0kenUPD4TE")//DISTINGUISH USAGE OF FORM BASED ON THE TOKEN
            {
                btnClear.Enabled = false;
                FetchUpdate(); //LOAD THE SELECTED ROW
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e) 
        {
            base.OnFormClosing(e);
            Application.OpenForms["Dashboard"].Show(); //SHOW DASHBOARD FORM
            Global.GlobalVar7 = ""; //RESET TOKEN
        }

        private void textBox8_TextChanged(object sender, EventArgs e) //ONLY ACCEPT NUMBERS IN TEXTBOX
        {
            string append = "";
            foreach (char c in textBox8.Text)
            {
                if ((!Char.IsNumber(c)) && (c != Convert.ToChar(Keys.Back)))
                {

                }
                else
                {
                    append += c;
                }
            }

            textBox8.Text = append;
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e) //ONLY ACCEPT DECIMALS IN TEXTBOX
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        //**************************************BUTTONS**************************************

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "All Files (*.*)|*.*";
            browseFile.FilterIndex = 1;
            browseFile.Multiselect = false;

            if (browseFile.ShowDialog() == DialogResult.OK)
            {
                textBox19.Text = browseFile.FileName;
                //string[] arrAllFiles = browseFile.FileNames; //used when Multiselect = true           
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "All Files (*.*)|*.*";
            browseFile.FilterIndex = 1;
            browseFile.Multiselect = false;

            if (browseFile.ShowDialog() == DialogResult.OK)
            {
                textBox20.Text = browseFile.FileName;
                //string[] arrAllFiles = browseFile.FileNames; //used when Multiselect = true           
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Global.GlobalVar7 == "t0kenCR3ATE" | Global.GlobalVar7 == "") //DISTINGUISH USAGE OF FORM BASED ON THE TOKEN
            {
                CreateNew(); //SAVE CREATED ENTRY
            }
            else if (Global.GlobalVar7 == "t0kenUPD4TE") //DISTINGUISH USAGE OF FORM BASED ON THE TOKEN
            {
                UpdateNew(); //UPDATE THE ENTRY
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        //**************************************METHODS**************************************

        public void ClearFields()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>()) //CLEAR ALL TEXTBOX
                textBox.Text = "";

            foreach (ComboBox comboBox in Controls.OfType<ComboBox>()) //CLEAR ALL COMBOBOX
                comboBox.Text = "";

            foreach (RadioButton radio in Controls.OfType<RadioButton>()) //CLEAR ALL RADIO BUTTON
                radio.Text = "";
        }

        public void FetchUpdate() //LOAD THE SELECTED ROW
        {
            string executablepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string basepath = (System.IO.Path.GetDirectoryName(executablepath));
            string file = @"\HRMS.mdb"; //DATABASE NAME & EXTENSION
            string dbpath = string.Concat(basepath, file);

            OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath + ";Persist Security Info = False;");
            OleDbCommand objComm = new OleDbCommand("SELECT * FROM tblPDS WHERE ID_pds =" + Global.GlobalVar1 + "", objConn);
            OleDbDataAdapter objAdap = new OleDbDataAdapter();
            DataTable objDt = new DataTable();

            try
            {
                objConn.Open();
                OleDbDataReader objRead = objComm.ExecuteReader();

                if (objRead.Read() == true)
                {
                    //Global.GlobalVar1 = objRead.GetString(0); 
                     textBox1.Text = objRead.GetString(1);
                     textBox2.Text = objRead.GetString(2);
                     textBox3.Text = objRead.GetString(3);
                     textBox4.Text = objRead.GetString(4);
                     dateTimePicker1.Text = objRead.GetString(5);
                     textBox5.Text = objRead.GetString(6);
                     textBox6.Text = objRead.GetString(7);
                     textBox7.Text = objRead.GetString(8);
                     comboBox1.Text = objRead.GetString(9);
                     comboBox2.Text = objRead.GetString(10);
                     comboBox3.Text = objRead.GetString(11);
                     comboBox4.Text = objRead.GetString(12);
                     textBox8.Text = objRead.GetString(13);
                     textBox9.Text = objRead.GetString(14);
                     textBox10.Text = objRead.GetString(15);
                     textBox11.Text = objRead.GetString(16);
                     textBox12.Text = objRead.GetString(17);
                     textBox13.Text = objRead.GetString(18);
                     textBox14.Text = objRead.GetString(19);
                     textBox15.Text = objRead.GetString(20);
                     textBox16.Text = objRead.GetString(21);
                     textBox17.Text = objRead.GetString(22);
                     textBox18.Text = objRead.GetString(23);
                     textBox19.Text = objRead.GetString(24);
                     textBox20.Text = objRead.GetString(25);
                }
                else
                {
                    MessageBox.Show("Ӽ WARNING: Make sure you selected from the table for updating \n or create a new entry else close this form.", "Personal Data Sheet", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Make sure you selected thoroughly from the table for updating \n or create a new entry else close this form. \n\n ERROR CODE: \n" + ex.ToString());
            }

            if (objConn.State == ConnectionState.Open) //CLOSE DB CONNECTION AFTER USE
            {
                objConn.Close();
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
                string createQuery = "INSERT INTO tblPDS (last_name, first_name, middle_name, suffix_name, date_birth, address_birth, address_permanent, address_present, citizenship, status_civil, sex, type_blood, number_contact, address_email, number_tin, number_gsis, number_pagibig, number_philhealth, number_sss, number_id, designation, grade_salary_increment, base_salary, link_pds, link_saln) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
                using (OleDbCommand objComm = new OleDbCommand(createQuery, objConn)){
                    objComm.CommandType = CommandType.Text;
                    objComm.Parameters.AddWithValue("last_name", textBox1.Text);
                    objComm.Parameters.AddWithValue("first_name", textBox2.Text);
                    objComm.Parameters.AddWithValue("middle_name", textBox3.Text);
                    objComm.Parameters.AddWithValue("suffix_name", textBox4.Text);
                    objComm.Parameters.AddWithValue("date_birth", dateTimePicker1.Text);
                    objComm.Parameters.AddWithValue("address_birth", textBox5.Text);
                    objComm.Parameters.AddWithValue("address_permanent", textBox6.Text);
                    objComm.Parameters.AddWithValue("address_present", textBox7.Text);
                    objComm.Parameters.AddWithValue("citizenship", comboBox1.Text);
                    objComm.Parameters.AddWithValue("status_civil", comboBox2.Text);
                    objComm.Parameters.AddWithValue("sex", comboBox3.Text);
                    objComm.Parameters.AddWithValue("type_blood", comboBox4.Text);
                    objComm.Parameters.AddWithValue("number_contact", textBox8.Text);
                    objComm.Parameters.AddWithValue("address_email", textBox9.Text);
                    objComm.Parameters.AddWithValue("number_tin", textBox10.Text);
                    objComm.Parameters.AddWithValue("number_gsis", textBox11.Text);
                    objComm.Parameters.AddWithValue("number_pagibig", textBox12.Text);
                    objComm.Parameters.AddWithValue("number_philhealth", textBox13.Text);
                    objComm.Parameters.AddWithValue("number_sss", textBox14.Text);
                    objComm.Parameters.AddWithValue("number_id", textBox15.Text);
                    objComm.Parameters.AddWithValue("designation", textBox16.Text);
                    objComm.Parameters.AddWithValue("grade_salary_increment", textBox17.Text);
                    objComm.Parameters.AddWithValue("base_salary", textBox18.Text);
                    objComm.Parameters.AddWithValue("link_pds", textBox19.Text);
                    objComm.Parameters.AddWithValue("link_saln", textBox20.Text);
                    objConn.Open();
                    objComm.ExecuteNonQuery();

                    CloneFile(); //UPLOAD FILE IN FOLDER

                    MessageBox.Show("Personnel saved! Please refresh the table to reflect changes.", "Personal Data");
                    Application.OpenForms["Dashboard"].Show(); //SHOW DASHBOARD FORM
                    this.Hide(); //HIDE FORM
                    Global.GlobalVar7 = ""; //RESET TOKEN
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

        public void UpdateNew()
        {
            string executablepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string basepath = (System.IO.Path.GetDirectoryName(executablepath));
            string file = @"\HRMS.mdb"; //DATABASE NAME & EXTENSION
            string dbpath = string.Concat(basepath, file);

            OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath + ";Persist Security Info = False;");

            try
            {
                string updateQuery = "UPDATE tblPDS SET last_name = @last_name, first_name = @first_name, middle_name = @middle_name, suffix_name = @suffix_name, date_birth = @date_birth, address_birth = @address_birth, address_permanent = @address_permanent, address_present = @address_present, citizenship = @citizenship, status_civil = @status_civil, sex = @sex, type_blood = @type_blood, number_contact = @number_contact, address_email = @address_email, number_tin = @number_tin, number_gsis = @number_gsis, number_pagibig = @number_pagibig, number_philhealth = @number_philhealth, number_sss = @number_sss, number_id = @number_id, designation = @designation, grade_salary_increment = @grade_salary_increment, base_salary = @base_salary, link_pds = @link_pds, link_saln = @link_saln WHERE ID_pds =" + Global.GlobalVar1 + "";
                using (OleDbCommand objComm = new OleDbCommand(updateQuery, objConn))
                {
                    objComm.CommandType = CommandType.Text;
                    objComm.Parameters.AddWithValue("@last_name", textBox1.Text);
                    objComm.Parameters.AddWithValue("@first_name", textBox2.Text);
                    objComm.Parameters.AddWithValue("@middle_name", textBox3.Text);
                    objComm.Parameters.AddWithValue("@suffix_name", textBox4.Text);
                    objComm.Parameters.AddWithValue("@date_birth", dateTimePicker1.Text);
                    objComm.Parameters.AddWithValue("@address_birth", textBox5.Text);
                    objComm.Parameters.AddWithValue("@address_permanent", textBox6.Text);
                    objComm.Parameters.AddWithValue("@address_present", textBox7.Text);
                    objComm.Parameters.AddWithValue("@citizenship", comboBox1.Text);
                    objComm.Parameters.AddWithValue("@status_civil", comboBox2.Text);
                    objComm.Parameters.AddWithValue("@sex", comboBox3.Text);
                    objComm.Parameters.AddWithValue("@type_blood", comboBox4.Text);
                    objComm.Parameters.AddWithValue("@number_contact", textBox8.Text);
                    objComm.Parameters.AddWithValue("@address_email", textBox9.Text);
                    objComm.Parameters.AddWithValue("@number_tin", textBox10.Text);
                    objComm.Parameters.AddWithValue("@number_gsis", textBox11.Text);
                    objComm.Parameters.AddWithValue("@number_pagibig", textBox12.Text);
                    objComm.Parameters.AddWithValue("@number_philhealth", textBox13.Text);
                    objComm.Parameters.AddWithValue("@number_sss", textBox14.Text);
                    objComm.Parameters.AddWithValue("@number_id", textBox15.Text);
                    objComm.Parameters.AddWithValue("@designation", textBox16.Text);
                    objComm.Parameters.AddWithValue("@grade_salary_increment", textBox17.Text);
                    objComm.Parameters.AddWithValue("@base_salary", textBox18.Text);
                    objComm.Parameters.AddWithValue("@link_pds", textBox19.Text);
                    objComm.Parameters.AddWithValue("@link_saln", textBox20.Text);
                    objConn.Open();
                    objComm.ExecuteNonQuery();

                    CloneFile(); //UPLOAD FILE IN FOLDER

                    MessageBox.Show("Personnel updated! Please refresh the table to reflect changes.", "Personal Data");
                    Application.OpenForms["Dashboard"].Show(); //SHOW DASHBOARD FORM
                    this.Hide(); //HIDE FORM
                    Global.GlobalVar7 = ""; //RESET TOKEN
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

        public void CloneFile()
        {
            try
            {
                string exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string exefolder = (System.IO.Path.GetDirectoryName(exepath));
                string pdsfolder = @"\pds\"; //FOLDER NAME
                string salnfolder = @"\saln\"; //FOLDER2 NAME
                string folderpath = string.Concat(exefolder, pdsfolder);
                string folderpath2 = string.Concat(exefolder, salnfolder);

                FileInfo file = new FileInfo(textBox19.Text);
                string filetofolderpath = string.Concat(folderpath, file.Name);
                //MessageBox.Show(filetofolderpath);

                FileInfo file2 = new FileInfo(textBox20.Text);
                string filetofolderpath2 = string.Concat(folderpath2, file2.Name);
                //MessageBox.Show(filetofolderpath2);

                File.Copy(textBox19.Text, filetofolderpath, true);
                File.Copy(textBox20.Text, filetofolderpath2, true);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

    }
}
