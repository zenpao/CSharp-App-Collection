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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            DatabaseCheck();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit(); //EXIT THE PROGRAM
        } 

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Feature available soon.");
        }

        //**************************************METHODS**************************************

        public void DatabaseCheck()
        {
            string executablepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string basepath = (System.IO.Path.GetDirectoryName(executablepath));
            string file = @"\HRMS.mdb"; //DATABASE NAME & EXTENSION
            string dbpath = string.Concat(basepath, file);

            OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath + ";Persist Security Info = False;");
            OleDbCommand objComm = new OleDbCommand();
            OleDbDataAdapter objAdap = new OleDbDataAdapter();
            DataTable objDt = new DataTable();

            try
            {
                objConn.Open();
                MessageBox.Show("√ Connection established at \n\n" + dbpath, "Database Connection", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ӽ WARNING: Database missing or corrupt at \n" + dbpath + "\n\n Application will not work properly. Closing application.", "Database Connection", MessageBoxButtons.OK);
                Application.Exit(); //EXIT THE PROGRAM
            }

            if (objConn.State == ConnectionState.Open) //CLOSE DB CONNECTION AFTER USE
            {
                objConn.Close();
            }
        }

        public void LogIn()
        {
            string executablepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string basepath = (System.IO.Path.GetDirectoryName(executablepath));
            string file = @"\HRMS.mdb"; //DATABASE NAME & EXTENSION
            string dbpath = string.Concat(basepath, file);

            OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath + ";Persist Security Info = False;");
            OleDbCommand objComm = new OleDbCommand("SELECT * FROM tblSuperUsers WHERE user_name='" + textUsername.Text + "' AND user_password ='" + textPassword.Text + "'", objConn);
            OleDbDataAdapter objAdap = new OleDbDataAdapter();
            DataTable objDt = new DataTable();

            string first_name;
            string user_name;
            string user_password;
            string privilage;

            try
            {
                objConn.Open();
                OleDbDataReader objRead = objComm.ExecuteReader();

                if (objRead.Read() == true)
                {
                    first_name = objRead.GetString(2);
                    user_name = objRead.GetString(5);
                    user_password = objRead.GetString(6);
                    privilage = objRead.GetString(7);
                    //MessageBox.Show(first_name + "\n" + user_name + "\n" + user_password);
                    MessageBox.Show("Welcome back! " + privilage + " - " + first_name, "Log-in");
                    textUsername.Text = "";
                    textPassword.Text = "";
                    new Dashboard().Show();
                }
                else
                {
                    MessageBox.Show("Ӽ WARNING: Username or password is incorrect.", "Log-in", MessageBoxButtons.OK);
                    textUsername.Text = "";
                    textPassword.Text = "";
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
    }
}
