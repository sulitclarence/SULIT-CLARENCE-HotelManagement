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
using DGVPrinterHelper;

namespace HotelManagement
{
    public partial class ReservationInfo : Form
    {
        public ReservationInfo()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clark\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
        DateTime Today;
        private Bitmap bmp;

        public void populate()
        {
            Con.Open();
            string Myquery = "Select * from Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void fillRoomcombo()
        {
            Con.Open();
            string roomstate = "free";
            SqlCommand cmd = new SqlCommand("select RoomId from Room_tbl where RoomFree = '"+roomstate+"'", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomId", typeof(int));
            dt.Load(rdr);
            roomcb.ValueMember = "RoomId";
            roomcb.DataSource = dt;
            Con.Close();
        }
        public void fillClientcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ClientName from Client_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientName", typeof(string));
            dt.Load(rdr);
            Clientcb.ValueMember = "ClientName";
            Clientcb.DataSource = dt;
            Con.Close();

        }
        private void ReservationInfo_Load(object sender, EventArgs e)
        {
            
                // TODO: This line of code loads data into the 'hoteldbDataSet1.Reservation_tbl' table. You can move, or remove it, as needed.


                Today = Datein.Value;
            fillRoomcombo();
            fillClientcombo();
            populate();
            Datelbl.Text = DateTime.Today.Day.ToString() +"-" + DateTime.Today.Month.ToString()+"-" + DateTime.Today.Year.ToString();
           


        }

        private void Datein_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(Datein.Value, Today);
            if (res < 0)
                MessageBox.Show("Wrong date for reservation");
        }

        private void Dateout_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(Dateout.Value, Datein.Value);
            if (res < 0)
                MessageBox.Show("Wrong Dateout. Check once more");
        }
        public void updateroomstate()
        {
            Con.Open();
            string newstate = "busy";
            String myquery = "UPDATE Room_tbl set RoomFree = '" + newstate + "' where RoomId = " +Convert.ToInt32(roomcb.SelectedValue.ToString()) + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Reservation Successfully Edited");
            Con.Close();
            fillRoomcombo();
        }
        public void updateroomndelete()
        {
            Con.Open();
            string newstate = "free";
            int roomid = Convert.ToInt32(ReservationGridView.SelectedRows[0].Cells[2].Value.ToString());
            String myquery = "UPDATE Room_tbl set RoomFree = '" + newstate + "' where RoomId = " +roomid + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Reservation Successfully Edited");
            Con.Close();
            fillRoomcombo();
        }
        private void AddRoomBtn_Click(object sender, EventArgs e)
        {

            Con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Reservation_tbl values(" + ReserId.Text + ",'" + Clientcb.SelectedValue.ToString() + "','" + roomcb.SelectedValue.ToString() + "','" + Datein.Value + "','" + Dateout.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Successfully Added");
            Con.Close();
            updateroomstate();
            populate();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ReservationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ReserId.Text = ReservationGridView.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void RoomDeletebtn_Click(object sender, EventArgs e)
        {
            if (ReserId.Text == "")
            {
                MessageBox.Show("Enter the Reservation to be deleted");
            }
            else
            {
                Con.Open();
                String query = "delete from Reservation_tbl where ResId = " + ReserId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Deleted");
                Con.Close();
                updateroomndelete();
                populate();

            }
        }

        private void RoomEditbtn_Click(object sender, EventArgs e)
        {
            if (ReserId.Text == "")
            {
                MessageBox.Show("Empty ResId, Enter the Reservation Id");
            }
            else
            {
                Con.Open();
                String myquery = "UPDATE Reservation_tbl set Client = '" + Clientcb.SelectedValue.ToString() + "' ,Room = '" + roomcb.SelectedValue.ToString() + "',DateIn='" + Datein.Value.ToString() + "',DateOut = '" + Dateout.Value.ToString() + "' where ResId = " + ReserId.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Edited");
                Con.Close();
                populate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "Select * from Reservation_tbl where ResId = '" + ReserId.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mform = new MainForm();
            mform.Show();
            this.Hide();
        }


        
           

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Report";
            
            printer.SubTitle = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "FoxLearn";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(ReservationGridView);
        }

        private void Clientcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}