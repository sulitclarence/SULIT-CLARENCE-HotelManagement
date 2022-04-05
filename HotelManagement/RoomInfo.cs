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
    public partial class RoomInfo : Form
    {
        public RoomInfo()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clark\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "Select * from Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (Yesradio.Checked == true)
                isfree = "free";
            else
                isfree = "Busy";

            Con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Room_tbl values(" + Roomnumtbl.Text + ",'" + Roomphonetbl.Text + "','" + isfree + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Added");
            Con.Close();
            populate();
        }

        private void RoomInfo_Load(object sender, EventArgs e)
        {
            populate();
            Datelbl.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
        }

        private void RoomGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Roomnumtbl.Text = RoomGridView.SelectedRows[0].Cells[0].Value.ToString();
            Roomphonetbl.Text = RoomGridView.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void RoomDeletebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String query = "delete from Room_tbl where RoomId = " + Roomnumtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Deleted");
            Con.Close();
            populate();
        }

        private void RoomEditbtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (Yesradio.Checked == true)
                isfree = "free";
            else
                isfree = "Busy";
            Con.Open();
            String myquery = "UPDATE Room_tbl set RoomPhone = '" + Roomphonetbl.Text + "' ,RoomFree = '" + isfree +  "' where RoomId = " + Roomnumtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Edited");
            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "Select * from Room_tbl where RoomId = '" + RoomSearchtb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate(); 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mform = new MainForm();
            mform.Show();
            this.Hide();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
