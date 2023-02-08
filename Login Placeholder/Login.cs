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
        MySqlDataReader dataReader;

        Thread th;

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
                //msg = "Connection is opend";
                //MessageBox.Show(msg);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            

        }

        public void BtnLogIn_Click(object sender, EventArgs e)
        {
                
            

            //this.Close();
            /*var formLogin = new frmLogIn();
            formLogin.Closed += (s, args) => this.Close();
            formLogin.Close();*/
            //new frmSearchHalls().Show();
            String SqlString = "select PassHash from lecturer where LecID = '" + txtBoxUserId + "';" ;


            MySqlCommand command = new MySqlCommand(SqlString, conn);
            dataReader = command.ExecuteReader();
            //String SqlOutput = 
            //MessageBox.Show(SqlOutput);

            if (SqlOutput == null)
            {
                MessageBox.Show("The user ID doesn't exist.");
            }
            else if( String.Compare( SqlOutput, txtBoxPass.Text) != 0)
            {
                MessageBox.Show("Incorrect Password.");
            }
            else
            {
                conn.Close();
                this.Close();
                th = new Thread(openSearch);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
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
