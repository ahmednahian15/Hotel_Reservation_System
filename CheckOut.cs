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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestBillInfoR gbl = new GuestBillInfoR();
            gbl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvailableRoomR ar = new AvailableRoomR();
            ar.Show();
        }
    }
}
