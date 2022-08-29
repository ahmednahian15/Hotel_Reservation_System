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
    public partial class GuestListR : Form
    {
        public GuestListR()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CancelReservation clr = new CancelReservation();
            clr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             this.Hide();
             AvailableRoomR ar = new AvailableRoomR();
             ar.Show();
        }
    }
}
