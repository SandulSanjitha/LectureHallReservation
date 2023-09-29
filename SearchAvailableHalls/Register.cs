using Login_Placeholder;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

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
                conn.Close();
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
            //Validation
            if (mTxtLecID.Text.Length != 7)
            {
                MessageBox.Show("The lecturer ID is not valid. Please check and try again.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mTxtLecID.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Your name is required!", "Missing required information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (txtPass.Text.Length < 8)
            {
                MessageBox.Show("Your password needs to be at least 8 characters long!", "Password is too short", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }

            if (String.Compare(txtPass.Text, txtConfirm.Text) != 0)
            {
                MessageBox.Show("The password does not match.", "Password not confirmed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirm.Focus();
                return;
            }

            //New user adding
            try
            {
                conn.Open();
                String SqlString = "insert into Lecturer values ('" + mTxtLecID.Text + "', '" + txtName.Text + "', '" + txtPass.Text + "');";
                MySqlCommand command = new MySqlCommand(SqlString, conn);
                MySqlDataReader rdr = command.ExecuteReader();
                conn.Close();
                MessageBox.Show("New user Added: " + txtName.Text + "!");

                frmLogIn nextForm = new frmLogIn();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            catch (MySqlException ex)
            {
                //Exeption handelling
                if (ex.Message.Contains("Duplicate entry"))
                {
                    // Handle the duplicate entry error
                    MessageBox.Show("A user with this ID already exists!", "Account exisits", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Handle any other exception
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
