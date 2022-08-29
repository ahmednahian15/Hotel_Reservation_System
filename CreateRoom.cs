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
    public partial class CreateRoom : Form
    {
        public CreateRoom()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void image1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerHome f2 = new ManagerHome();
            f2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string sql = "insert into AvailableRoom(RoomNumber, RoomType, MaximumGuest, Bed, Price, Date) values('" + this.textBox1.Text + "','" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.comboBox3.Text + "', '" + this.textBox2.Text + "', '" + this.dateTimePicker1.Text + "')";

            if (db.ExecuteUpdateQuery(sql) == 1)
            {
                MessageBox.Show("Room Created successfully");
            }


            this.Hide();
            AvailableRoomM ar = new AvailableRoomM();
            ar.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
