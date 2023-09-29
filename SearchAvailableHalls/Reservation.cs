using Login_Placeholder;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SearchAvailableHalls
{

    public partial class frmSearchHalls : Form
    {
        public string userID { get; set; }
        public string userName { get; set; }

        public Boolean endNotChanged = true;
        public DataTable dT1 = new DataTable();

        MySqlConnection conn = new MySqlConnection();

        public static frmSearchHalls frmSearchHallsInstance;

        public frmSearchHalls()
        {
            InitializeComponent();
            frmSearchHallsInstance = this;

            //Set Today as the date
            DateTimePicker dtpDate = new DateTimePicker();
            dtpDate.Value = DateTime.Now;

            btnReserve.Enabled = false;
            this.AcceptButton = BtnSearch;

            //Auto set the lables to correct position
            //btnLogOut.Dock = DockStyle.Right;
            lblWelcome.Dock = DockStyle.Right;

        }

        public void BtnSearch_Click(object sender, EventArgs e)
        {
            //All the lecture halls that can be seated needed students
            String SqlString1 = "select HallID, HallName, MaxStudents from LectureHalls where MaxStudents >= @stuCount ORDER BY MaxStudents";

            try
            {
                conn.Open();
                MySqlCommand command1 = new MySqlCommand(SqlString1, conn);
                command1.Parameters.AddWithValue("stuCount", numUpDownNoOFStu.Value);

                MySqlDataAdapter dA1 = new MySqlDataAdapter(command1);
                dT1.Rows.Clear();   //clear the previous results
                dA1.Fill(dT1);

                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Find already reserved lecture halls
            String SqlString2 = "select HallID from Reserved where ResDate = @resDate and ((StartTime between @startTime and @endTime) or (EndTime between @startTime and @endTime))";
            DataTable dT2 = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand command2 = new MySqlCommand(SqlString2, conn);

                command2.Parameters.Add("@resDate", MySqlDbType.Date).Value = dtpDate.Value.Date;
                command2.Parameters.Add("@startTime", MySqlDbType.Time).Value = dtpStart.Value.TimeOfDay;
                command2.Parameters.Add("@endTime", MySqlDbType.Time).Value = dtpEnd.Value.TimeOfDay;

                MySqlDataAdapter dA2 = new MySqlDataAdapter(command2);

                dA2.Fill(dT2);

                conn.Close();
            }
            catch (MySqlException ex1)
            {
                MessageBox.Show(ex1.Message);
            }


            //remove unavailable lecture halls
            String com1ID;
            String com2ID;

            foreach (DataRow reservedRow in dT2.Rows)
            {

                foreach (DataRow hallRow in dT1.Rows)
                {
                    com1ID = hallRow["HallID"].ToString();
                    com2ID = reservedRow["HallID"].ToString();

                    if (String.Compare(com1ID, com2ID) == 0)
                    {
                        //MessageBox.Show(com1ID + " vs " + com2ID);

                        hallRow.Delete();
                        hallRow.AcceptChanges();
                        dT1.AcceptChanges();
                        break;
                    }
                }
            }

            dT1.AcceptChanges(); //maybe redundent
            dataGridViewResults.DataSource = dT1;

            //SelectedHall ComboBox
            cmbSelectedHall.Items.Clear();
            foreach (DataRow hall in dT1.Rows)
            {
                cmbSelectedHall.Items.Add(hall["HallName"].ToString());
            }
            if(cmbSelectedHall.Items.Count>0)
            {
                cmbSelectedHall.SelectedIndex = 0;
            }
            

            btnReserve.Enabled = true;
            this.AcceptButton = btnReserve;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            numUpDownNoOFStu.Value = 0;
            dtpDate.Value = DateTime.Now;
            dtpStart.Value = new DateTime(2023, 2, 6, 8, 0, 0, 0);
            dtpEnd.Value = new DateTime(2023, 2, 6, 9, 59, 0, 0);
            dT1.Rows.Clear();
            cmbSelectedHall.Items.Clear();
            cmbSelectedHall.Text = "";
            btnReserve.Enabled = false;
            this.AcceptButton = BtnSearch;
        }


        public void frmSearchHalls_Load(object sender, EventArgs e)
        {

            lblWelcome.Text = "Welcome, " + userName + "!";

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
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            result = MessageBox.Show("Would you like to make this reservation?", "Confirm Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    String SqlString = "insert into Reserved (ResDate, StartTime, EndTime, LecID, HallID, NoOfStudents) values (@resDate, @startTime, @endTime,  @userID, @hallID, @stuNo)";

                    MySqlCommand command = new MySqlCommand(SqlString, conn);

                    string hallName = cmbSelectedHall.SelectedItem.ToString();
                    String hallID = hallName.Replace(" ", "");

                    command.Parameters.Add("@resDate", MySqlDbType.Date).Value = dtpDate.Value.Date;
                    command.Parameters.Add("@startTime", MySqlDbType.Time).Value = dtpStart.Value.TimeOfDay;
                    command.Parameters.Add("@endTime", MySqlDbType.Time).Value = dtpEnd.Value.TimeOfDay;
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@hallID", hallID);
                    command.Parameters.AddWithValue("stuNo", numUpDownNoOFStu.Value);

                    MySqlDataReader rdr = command.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Lecture Hall " + hallName + " is Reserved", "Reservation Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnClear.PerformClick();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            //set minutes to 00 and 30
            var diff = dtpStart.Value.TimeOfDay.Minutes % 30;
            if (diff != 0)
            {
                dtpStart.Value = dtpStart.Value.AddMinutes(30 - diff);
            }

            //change the value relatively
            if (endNotChanged)
            {
                dtpEnd.Value = dtpStart.Value.AddHours(1).AddMinutes(59);
            }

        }

        private void dtpEnd_Enter(object sender, EventArgs e)
        {
            //stop the relative change of value
            if (endNotChanged)
            {
                endNotChanged = false;
            }

        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {

            //set minutes to 29 and 59 to avoid errors when checking available time slots
            if (dtpEnd.Value.TimeOfDay.Minutes != 29 || dtpEnd.Value.TimeOfDay.Minutes != 59)
            {
                var diff = dtpEnd.Value.TimeOfDay.Minutes % 30;
                dtpEnd.Value = dtpEnd.Value.AddMinutes(30 - diff - 1);
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogIn nextForm = new frmLogIn();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
