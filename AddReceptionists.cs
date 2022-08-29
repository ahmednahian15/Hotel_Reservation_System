using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelReservationSystem
{
    public partial class AddReceptionists : Form
    {
        public AddReceptionists()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string sql = "insert into RECEPTIONISTS(Name, Address,Username,PhoneNumber,Password) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "', '" + this.textBox5.Text + "')";

            if (db.ExecuteUpdateQuery(sql) == 1)
            {
                MessageBox.Show("Receptionist addedd successfully");
            }

            this.Hide();
            ReceptionistsInfo f5 = new ReceptionistsInfo();
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerHome f2 = new ManagerHome();
            f2.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ReceptionistsInfo f5 = new ReceptionistsInfo();
            f5.Show();
        }
    }
}
