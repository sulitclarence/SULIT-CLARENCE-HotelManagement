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

namespace HotelManagement
{
    public partial class StaffInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clark\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "Select * from Staff_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public StaffInfo()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "Select * from Staff_tbl where StaffName = '" + StaffSearchtb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void ClientSearchtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Staff_tbl values(" + Staffidtbl.Text + ",'" + Staffnametbl.Text + "','" + staffphonetb.Text + "','" + staffgendercb.SelectedItem.ToString() + "','"+passwordtb.Text+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Added");
            Con.Close();
            populate();
        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
            populate();
            Datelbl.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();

        }

        private void StaffEditbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String myquery = "UPDATE Staff_tbl set StaffName = '" + Staffnametbl.Text + "' ,staffPhone = '" + staffphonetb.Text + "',gender='" + staffgendercb.SelectedItem.ToString() + "',Staffpassword = '" + passwordtb.Text + "' where StaffId = " + Staffidtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Edited");
            Con.Close();
            populate();
        }

        private void StaffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Staffidtbl.Text = StaffGridView.SelectedRows[0].Cells[0].Value.ToString();
            Staffnametbl.Text = StaffGridView.SelectedRows[0].Cells[1].Value.ToString();
            staffphonetb.Text = StaffGridView.SelectedRows[0].Cells[2].Value.ToString();
            passwordtb.Text = StaffGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String query = "delete from Staff_tbl where StaffId = " + Staffidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Deleted");
            Con.Close();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mform = new MainForm();
            mform.Show();
            this.Hide();
        }

        private void staffphonetb_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Staffidtbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void Staffnametbl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
