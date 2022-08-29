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
    public partial class CustomerReservation : Form
    {
        public CustomerReservation()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestListR gl = new GuestListR();
            gl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvailableRoomR ar = new AvailableRoomR();
            ar.Show();
        }
    }
}
