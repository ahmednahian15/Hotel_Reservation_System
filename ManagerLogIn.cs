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
    public partial class ManagerLogIn : Form
    {
        public ManagerLogIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text.ToLower().Equals("bruce") && this.textBox2.Text.Equals("12345"))
            {
                MessageBox.Show("Login Valid");
                this.Hide();
                ManagerHome f2 = new ManagerHome();
                f2.Show();
            }
            else
            {
               
                MessageBox.Show("Login Invalid");


                this.Hide();
                ManagerLogIn f1 = new ManagerLogIn();
                f1.Show();
                //this.ClearContent(); //When invalid then window clear.
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }
    }
}
