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
    public partial class RForgotPass : Form
    {
        public RForgotPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionistsLogIn rl = new ReceptionistsLogIn();
            rl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    this.Hide();
        //    RAVailableRoom ar = new RAVailableRoom();
        //    ar.Show();
        }

    }
}
