
namespace SearchAvailableHalls
{
    partial class frmSearchHalls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchHalls));
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblInTime = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.numUpDownNoOFStu = new System.Windows.Forms.NumericUpDown();
            this.lblStuNum = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.cmbSelectedHall = new System.Windows.Forms.ComboBox();
            this.lblSelectedHall = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNoOFStu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(49, 35);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(82, 33);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(174, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // lblInTime
            // 
            this.lblInTime.AutoSize = true;
            this.lblInTime.BackColor = System.Drawing.Color.Transparent;
            this.lblInTime.Location = new System.Drawing.Point(49, 67);
            this.lblInTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInTime.Name = "lblInTime";
            this.lblInTime.Size = new System.Drawing.Size(32, 13);
            this.lblInTime.TabIndex = 2;
            this.lblInTime.Text = "Start:";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "HH:mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(82, 65);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Size = new System.Drawing.Size(66, 20);
            this.dtpStart.TabIndex = 3;
            this.dtpStart.Value = new System.DateTime(2023, 2, 6, 8, 0, 0, 0);
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.BackColor = System.Drawing.Color.Transparent;
            this.lblEndTime.Location = new System.Drawing.Point(158, 67);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(29, 13);
            this.lblEndTime.TabIndex = 4;
            this.lblEndTime.Text = "End:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "HH:mm";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(188, 65);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShowUpDown = true;
            this.dtpEnd.Size = new System.Drawing.Size(66, 20);
            this.dtpEnd.TabIndex = 5;
            this.dtpEnd.Value = new System.DateTime(2023, 2, 6, 9, 59, 0, 0);
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // numUpDownNoOFStu
            // 
            this.numUpDownNoOFStu.Location = new System.Drawing.Point(395, 33);
            this.numUpDownNoOFStu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numUpDownNoOFStu.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownNoOFStu.Name = "numUpDownNoOFStu";
            this.numUpDownNoOFStu.Size = new System.Drawing.Size(56, 20);
            this.numUpDownNoOFStu.TabIndex = 7;
            this.numUpDownNoOFStu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStuNum
            // 
            this.lblStuNum.AutoSize = true;
            this.lblStuNum.BackColor = System.Drawing.Color.Transparent;
            this.lblStuNum.Location = new System.Drawing.Point(287, 35);
            this.lblStuNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuNum.Name = "lblStuNum";
            this.lblStuNum.Size = new System.Drawing.Size(104, 13);
            this.lblStuNum.TabIndex = 6;
            this.lblStuNum.Text = "Number of Students:";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(314, 67);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(56, 19);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(386, 67);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(56, 19);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.BackColor = System.Drawing.Color.Transparent;
            this.lblResults.Location = new System.Drawing.Point(49, 99);
            this.lblResults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(118, 13);
            this.lblResults.TabIndex = 10;
            this.lblResults.Text = "Available Lecture Halls:";
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(335, 346);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(56, 19);
            this.btnReserve.TabIndex = 12;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Location = new System.Drawing.Point(480, 11);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 25, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(0, 3, 25, 0);
            this.lblWelcome.Size = new System.Drawing.Size(25, 16);
            this.lblWelcome.TabIndex = 14;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(51, 125);
            this.dataGridViewResults.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersWidth = 82;
            this.dataGridViewResults.RowTemplate.Height = 33;
            this.dataGridViewResults.Size = new System.Drawing.Size(399, 212);
            this.dataGridViewResults.TabIndex = 15;
            // 
            // cmbSelectedHall
            // 
            this.cmbSelectedHall.FormattingEnabled = true;
            this.cmbSelectedHall.Location = new System.Drawing.Point(221, 347);
            this.cmbSelectedHall.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectedHall.Name = "cmbSelectedHall";
            this.cmbSelectedHall.Size = new System.Drawing.Size(101, 21);
            this.cmbSelectedHall.TabIndex = 16;
            // 
            // lblSelectedHall
            // 
            this.lblSelectedHall.AutoSize = true;
            this.lblSelectedHall.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedHall.Location = new System.Drawing.Point(99, 349);
            this.lblSelectedHall.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedHall.Name = "lblSelectedHall";
            this.lblSelectedHall.Size = new System.Drawing.Size(112, 13);
            this.lblSelectedHall.TabIndex = 17;
            this.lblSelectedHall.Text = "Selected Lecture Hall:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImage = global::SearchAvailableHalls.Properties.Resources.logout;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.Location = new System.Drawing.Point(489, -1);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(20, 20);
            this.btnLogOut.TabIndex = 18;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmSearchHalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SearchAvailableHalls.Properties.Resources.resSysBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 381);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblSelectedHall);
            this.Controls.Add(this.cmbSelectedHall);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.lblStuNum);
            this.Controls.Add(this.numUpDownNoOFStu);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblInTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmSearchHalls";
            this.Text = "Search : Lecture Hall Reservation";
            this.Load += new System.EventHandler(this.frmSearchHalls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNoOFStu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblInTime;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.NumericUpDown numUpDownNoOFStu;
        private System.Windows.Forms.Label lblStuNum;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblWelcome;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.ComboBox cmbSelectedHall;
        private System.Windows.Forms.Label lblSelectedHall;
        private System.Windows.Forms.Button btnLogOut;
    }
}

