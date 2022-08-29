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
    public partial class ReceptionistsLogIn : Form
    {
        public ReceptionistsLogIn()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.ToLower().Equals("bruce") && this.textBox2.Text.Equals("123"))
            {
                MessageBox.Show("Login Valid");
                this.Hide();
                AvailableRoomR ar = new AvailableRoomR();
                ar.Show();
            }
            else
            {

                MessageBox.Show("Login Invalid");


                this.Hide();
                ReceptionistsLogIn rl = new ReceptionistsLogIn();
                rl.Show();
                //this.ClearContent(); //When invalid then window clear.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RForgotPass rp = new RForgotPass();
            rp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }
    }
}
