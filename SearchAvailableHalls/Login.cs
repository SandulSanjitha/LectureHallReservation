using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SearchAvailableHalls;

namespace Login_Placeholder
{
    
    public partial class frmLogIn : Form
    {
        MySqlConnection conn = new MySqlConnection();
        //public static String logedUser = "";

        public frmLogIn()
        {
            InitializeComponent();
        }

        public void openSearch(object obj)
        {
            //Application.Run(new frmSearchHalls());
        }

        public void frmLogIn_Load(object sender, EventArgs e)
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
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            

        }

        /*private void TxtBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogIn.PerformClick();
            }
        }*/

        public void BtnLogIn_Click(object sender, EventArgs e)
        {

            
            String SqlString = "select PassHash from lecturer where LecID = @id";


            MySqlCommand command = new MySqlCommand(SqlString, conn);
            command.Parameters.AddWithValue("id", txtBoxUserId.Text.Trim());
            MySqlDataReader dataReader = command.ExecuteReader();
            String SqlOutput = "";

            while(dataReader.Read())
            {
                SqlOutput = dataReader["PassHash"].ToString();
                
            }

            
            if ( String.Compare( SqlOutput, TxtBoxPass.Text) != 0)
            {
                MessageBox.Show("Incorrect Password.");
            }
            else
            {

                conn.Close();

                //frmSearchHalls.frmSearchHallsInstance.welcome.Text = txtBoxUserId.Text;


                frmSearchHalls nextForm = new frmSearchHalls();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            
            dataReader.Close();

        }

        public void frmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmRegister nextForm = new frmRegister();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
