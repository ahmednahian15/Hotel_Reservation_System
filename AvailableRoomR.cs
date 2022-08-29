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
    public partial class AvailableRoomR : Form
    {
        public AvailableRoomR()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerReservation cr = new CustomerReservation();
            cr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionistsLogIn rli = new ReceptionistsLogIn();
            rli.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckOut co = new CheckOut();
            co.Show();
        }
    }
}
