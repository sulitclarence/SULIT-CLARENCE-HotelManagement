﻿using System;
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
    public partial class ClientInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clark\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "Select * from client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public ClientInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            //Datelbl.Text = DateTime.Now.ToLongTimeString();
            //timer1.Start();
            Datelbl.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Client_tbl values(" + clientidtbl.Text + ",'" + clientnametbl.Text + "','"+clientphonetb.Text+"','"+clientctrycb.SelectedItem.ToString()+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            Con.Close();
            populate();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clientidtbl.Text = ClientGridView.SelectedRows[0].Cells[0].Value.ToString();
            clientnametbl.Text = ClientGridView.SelectedRows[0].Cells[1].Value.ToString();
            clientphonetb.Text = ClientGridView.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            Con.Open(); 
            String myquery = "UPDATE client_tbl set ClientName = '" + clientnametbl.Text + "' ,ClientPhone = '" + clientphonetb.Text + "',ClientCountry='" + clientctrycb.SelectedItem.ToString() + "' where ClientId = " + clientidtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Edited");
            Con.Close();
            populate();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String query = "delete from Client_tbl where Clientid = " + clientidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Deleted");
            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "Select * from client_tbl where ClientName = '"+ClientSearchtb.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridView.DataSource = ds.Tables[0];
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

        private void ClientSearchtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientnametbl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
