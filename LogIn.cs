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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogIn f1 = new ManagerLogIn();
            f1.Show();
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionistsLogIn RL = new ReceptionistsLogIn();
            RL.Show();
        }
    }
}
