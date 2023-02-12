using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchAvailableHalls
{
    public partial class frmConfirm : Form
    {
        public DateTime Date { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public ComboBox LecHall { get; set; }
        public int NoOfStu { get; set; }
        public string UserID { get; set; }


        public frmConfirm()
        {
            
            InitializeComponent();
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {

        }
    }
}
