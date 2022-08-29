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
    public partial class AvailableRoomM : Form
    {
        public AvailableRoomM()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();

        private void fullTableView()
        {
            dataGridView1.DataSource = da.ExecuteQueryTable("select * from AvailableRoom");
        }

        private void AvailableRoomM_Load(object sender, EventArgs e)
        {
             this.fullTableView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateRoom cr = new CreateRoom();
            cr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvailableRoomM ar = new AvailableRoomM();
            ar.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.fullTableView();
            String src = textBox1.Text;
            dataGridView1.DataSource = da.ExecuteQueryTable("select * from AvailableRoom where RoomNumber = ('" + src + " '");
        }


        

    }
}
