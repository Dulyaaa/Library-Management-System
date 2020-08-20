using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class mainDashbboard : Form
    {
        public mainDashbboard()
        {
            InitializeComponent();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addMember A = new addMember();
            A.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reserveBook r = new reserveBook();
            r.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addBook D = new addBook();
            D.Show();
            this.Hide();
        }

        private void mainDashbboard_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            payment P = new payment();
            P.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            issueBook i = new issueBook();
            i.Show();
            this.Hide();
        }
    }
}
