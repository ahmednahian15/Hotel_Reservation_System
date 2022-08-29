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
    public partial class ReceptionistsInfo : Form
    {
        public ReceptionistsInfo()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerHome f2 = new ManagerHome();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         //   DataAccess da = new DataAccess();
           // dataGridView1.DataSource = da.ExecuteQueryTable("select * from RECEPTIONISTS");
         //   
            
        }

        private void ReceptionistsInfo_Load(object sender, EventArgs e)
        {
            //   DataAccess da = new DataAccess();
            //   dataGridView1.DataSource = da.ExecuteQueryTable("select * from RECEPTIONISTS");

            this.fullTableView();
        
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.fullTableView();
            String src = textBox1.Text;
            dataGridView1.DataSource = da.ExecuteQueryTable("SELECT * FROM RECEPTIONISTS WHERE Username = '"+ src +"'");
            

        }

        private void fullTableView() 
        {
            dataGridView1.DataSource = da.ExecuteQueryTable("select * from RECEPTIONISTS");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.fullTableView();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
