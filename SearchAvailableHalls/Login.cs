using MySql.Data.MySqlClient;
using SearchAvailableHalls;
using System;
using System.Windows.Forms;

namespace Login_Placeholder
{

    public partial class frmLogIn : Form
    {
        MySqlConnection conn = new MySqlConnection();
        //public static String logedUser = "";

        public frmLogIn()
        {
            InitializeComponent();
            this.AcceptButton = BtnLogIn;
        }

        public void openSearch(object obj)
        {
            //Application.Run(new frmSearchHalls());
        }

        public void frmLogIn_Load(object sender, EventArgs e)
        {
            TxtBoxPass.UseSystemPasswordChar = true;

            String server = "localhost";
            String uid = "root";
            String pwd = "root";
            String db = "lechallres";

            String connString = ("server=" + server + ";" + "uid=" + uid + ";" + "pwd=" + pwd + ";" + "database=" + db);

            //Exeption handling
            try
            {
                conn.ConnectionString = connString;
                conn.Open();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public void BtnLogIn_Click(object sender, EventArgs e)
        {
            //Validation - User id_1
            if (string.IsNullOrEmpty(txtBoxUserId.Text) || txtBoxUserId.Text.Length != 7)
            {
                MessageBox.Show("Check you user ID and try again.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxUserId.Focus();
                return;
            }
            
            String SqlOutput = null;
            String UserName = "";

            //Exeption handling
            try
            {
                String SqlString = "select LecName, PassHash from lecturer where LecID = @id";
                MySqlCommand command = new MySqlCommand(SqlString, conn);
                command.Parameters.AddWithValue("id", txtBoxUserId.Text.Trim());
                conn.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    SqlOutput = dataReader["PassHash"].ToString();
                    UserName = dataReader["LecName"].ToString();

                }
                dataReader.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Validation - User id_2
            if (string.IsNullOrEmpty(SqlOutput))
            {
                MessageBox.Show("That user id dosen't exist. Enter a different id or create a new one.", "User does not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxUserId.Focus();
                return;
            }

            //Validate - Password
            if (String.Compare(SqlOutput, TxtBoxPass.Text) != 0)
            {
                MessageBox.Show("The password you entered is incorrect. Please try again.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBoxPass.Focus();
                return;
            }

            frmSearchHalls nextForm = new frmSearchHalls();
            nextForm.userID = txtBoxUserId.Text.Trim();
            nextForm.userName = UserName;
            this.Hide();
            nextForm.ShowDialog();
            this.Close();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmRegister nextForm = new frmRegister();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void ckBxShow_CheckedChanged(object sender, EventArgs e)
        {
            TxtBoxPass.UseSystemPasswordChar = ckBxShow.Checked ? false : true;
        }

    }
}
