using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_Placeholder;
using MySql.Data.MySqlClient;

namespace SearchAvailableHalls
{
    public partial class frmRegister : Form
    {
        MySqlConnection conn = new MySqlConnection();

        public frmRegister()
        {
            InitializeComponent();
            this.AcceptButton = btnAdd;
        }

        public void Register_Load(object sender, EventArgs e)
        {
            String server = "localhost";
            String uid = "root";
            String pwd = "root";
            String db = "lechallres";

            String connString = ("server=" + server + ";" + "uid=" + uid + ";" + "pwd=" + pwd + ";" + "database=" + db);

            try
            {
                conn.ConnectionString = connString;
                conn.Open();
                //msg = "Connection is opend";
                //MessageBox.Show(msg);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            txtPass.UseSystemPasswordChar = true;
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogIn nextForm = new frmLogIn();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mTxtLecID.Text = "";
            txtName.Text = "";
            txtPass.Text = "";
            txtConfirm.Text = "";
        }

        private void ckBxShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = ckBxShow.Checked ? false : true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (String.Compare(txtPass.Text, txtConfirm.Text) != 0)
            {
                MessageBox.Show("The password confirmation does not match.");
            }
            else
            {
                String SqlString = "insert into Lecturer values ('" + mTxtLecID.Text + "', '" + txtName.Text + "', '"+ txtPass.Text + "');";
                //String SqlOutput;
                MySqlCommand command = new MySqlCommand(SqlString,conn);
                MySqlDataReader rdr = command.ExecuteReader();
                conn.Close();
                MessageBox.Show("User : " + txtName.Text + " is added.");

                frmLogIn nextForm = new frmLogIn();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            
        }
    }
}
