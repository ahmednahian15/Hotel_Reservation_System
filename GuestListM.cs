using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class GuestListM : Form
    {
        public GuestListM()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerHome mh = new ManagerHome();
            mh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestBillInfoM gbm = new GuestBillInfoM();
            gbm.Show();
        }
    }
}
