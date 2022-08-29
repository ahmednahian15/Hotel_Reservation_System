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
    public partial class HelpContacts : Form
    {
        public HelpContacts()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerHome f2 = new ManagerHome();
            f2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void fullTableView()
        {
            dataGridView1.DataSource = da.ExecuteQueryTable("select * from HelpContacts");
        }

        private void HelpContacts_Load(object sender, EventArgs e)
        {
            this.fullTableView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.fullTableView();
            String src = textBox1.Text;
            dataGridView1.DataSource = da.ExecuteQueryTable("SELECT * FROM HelpContacts WHERE Name = '" + src + "'");
        }
    }
}
