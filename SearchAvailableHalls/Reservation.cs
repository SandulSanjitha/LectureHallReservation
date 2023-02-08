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
    public partial class frmSearchHalls : Form
    {
        MySqlConnection conn = new MySqlConnection();

        public static frmSearchHalls frmSearchHallsInstance;
        //public String LoggedUser;
        public Label welcome;
        public frmSearchHalls()
        {
            InitializeComponent();
            frmSearchHallsInstance = this;
            welcome = lblWelcome;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String SqlString1 = "select HallName, MaxStudents from LectureHalls where MaxStudents >= @stuCount";


            MySqlCommand command1 = new MySqlCommand(SqlString1, conn);
            command1.Parameters.AddWithValue("stuCount", numericUpDown1.Value);

            MySqlDataAdapter dA1 = new MySqlDataAdapter(command1);
            DataTable dT1 = new DataTable();
            dA1.Fill(dT1);

            dataGridViewResults.DataSource = dT1;

            /*String SqlString2 = "select HallName, MaxStudents from LectureHalls where MaxStudents >= @stuCount";


            MySqlCommand command2 = new MySqlCommand(SqlString2, conn);
            command2.Parameters.AddWithValue("stuCount", numericUpDown1.Value);

            MySqlDataAdapter dA2 = new MySqlDataAdapter(command2);
            DataTable dT2 = new DataTable();
            dA1.Fill(dT2);

            dataGridViewResults.DataSource = dT1;*/



            conn.Close();

            /*MySqlDataReader dataReader = command.ExecuteReader();
            String SqlOutput = "";

            while (dataReader.Read())
            {
                SqlOutput = dataReader["HallID"].ToString();

            }*/
        }

        private void dataGridViewResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewResults.CurrentRow.Selected = true;
            dataGridViewResults.Rows.RemoveAt(dataGridViewResults.SelectedRows[0].Index);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            dtpDate.Text = null;
            dtpStart.Text = null;
            dtpEnd.Text = null;
            
        }


        public void frmSearchHalls_Load(object sender, EventArgs e)
        {
            
            //lblWelcome.Text = LoggedUser;

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
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogIn nextForm = new frmLogIn();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            var diff = dtpStart.Value.TimeOfDay.Minutes % 30;
            if (diff != 0)
            {
                dtpStart.Value = dtpStart.Value.AddMinutes(15 - diff);
            }
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            var diff = dtpEnd.Value.TimeOfDay.Minutes % 29;
            if (diff != 0)
            {
                dtpEnd.Value = dtpEnd.Value.AddMinutes(15 - diff);
            }
        }
    }
}
