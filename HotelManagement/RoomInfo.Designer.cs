namespace HotelManagement
{
    partial class RoomInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Roomphonetbl = new System.Windows.Forms.TextBox();
            this.Roomnumtbl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Yesradio = new Guna.UI.WinForms.GunaRadioButton();
            this.Noradio = new Guna.UI.WinForms.GunaRadioButton();
            this.RoomDeletebtn = new System.Windows.Forms.Button();
            this.RoomEditbtn = new System.Windows.Forms.Button();
            this.AddRoomBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RoomSearchtb = new System.Windows.Forms.TextBox();
            this.RoomGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 100);
            this.panel1.TabIndex = 2;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.Location = new System.Drawing.Point(847, 68);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(50, 22);
            this.Datelbl.TabIndex = 2;
            this.Datelbl.Text = "Date";
            this.Datelbl.Click += new System.EventHandler(this.Datelbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rooms Information";
            // 
            // Roomphonetbl
            // 
            this.Roomphonetbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roomphonetbl.ForeColor = System.Drawing.Color.Black;
            this.Roomphonetbl.Location = new System.Drawing.Point(93, 290);
            this.Roomphonetbl.Name = "Roomphonetbl";
            this.Roomphonetbl.Size = new System.Drawing.Size(164, 26);
            this.Roomphonetbl.TabIndex = 7;
            this.Roomphonetbl.Text = "Room Phone";
            // 
            // Roomnumtbl
            // 
            this.Roomnumtbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roomnumtbl.ForeColor = System.Drawing.Color.Black;
            this.Roomnumtbl.Location = new System.Drawing.Point(93, 249);
            this.Roomnumtbl.Name = "Roomnumtbl";
            this.Roomnumtbl.Size = new System.Drawing.Size(164, 26);
            this.Roomnumtbl.TabIndex = 6;
            this.Roomnumtbl.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(89, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Free";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Yesradio
            // 
            this.Yesradio.BaseColor = System.Drawing.SystemColors.Control;
            this.Yesradio.CheckedOffColor = System.Drawing.Color.Gray;
            this.Yesradio.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Yesradio.FillColor = System.Drawing.Color.White;
            this.Yesradio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yesradio.Location = new System.Drawing.Point(148, 338);
            this.Yesradio.Name = "Yesradio";
            this.Yesradio.Size = new System.Drawing.Size(57, 20);
            this.Yesradio.TabIndex = 9;
            this.Yesradio.Text = "YES";
            // 
            // Noradio
            // 
            this.Noradio.BaseColor = System.Drawing.SystemColors.Control;
            this.Noradio.CheckedOffColor = System.Drawing.Color.Gray;
            this.Noradio.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Noradio.FillColor = System.Drawing.Color.White;
            this.Noradio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noradio.Location = new System.Drawing.Point(210, 338);
            this.Noradio.Name = "Noradio";
            this.Noradio.Size = new System.Drawing.Size(50, 20);
            this.Noradio.TabIndex = 11;
            this.Noradio.Text = "NO";
            // 
            // RoomDeletebtn
            // 
            this.RoomDeletebtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.RoomDeletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomDeletebtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomDeletebtn.ForeColor = System.Drawing.Color.Black;
            this.RoomDeletebtn.Location = new System.Drawing.Point(181, 425);
            this.RoomDeletebtn.Name = "RoomDeletebtn";
            this.RoomDeletebtn.Size = new System.Drawing.Size(76, 34);
            this.RoomDeletebtn.TabIndex = 21;
            this.RoomDeletebtn.Text = "DELETE";
            this.RoomDeletebtn.UseVisualStyleBackColor = false;
            this.RoomDeletebtn.Click += new System.EventHandler(this.RoomDeletebtn_Click);
            // 
            // RoomEditbtn
            // 
            this.RoomEditbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.RoomEditbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomEditbtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomEditbtn.ForeColor = System.Drawing.Color.Black;
            this.RoomEditbtn.Location = new System.Drawing.Point(188, 374);
            this.RoomEditbtn.Name = "RoomEditbtn";
            this.RoomEditbtn.Size = new System.Drawing.Size(69, 34);
            this.RoomEditbtn.TabIndex = 20;
            this.RoomEditbtn.Text = "EDIT";
            this.RoomEditbtn.UseVisualStyleBackColor = false;
            this.RoomEditbtn.Click += new System.EventHandler(this.RoomEditbtn_Click);
            // 
            // AddRoomBtn
            // 
            this.AddRoomBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRoomBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoomBtn.ForeColor = System.Drawing.Color.Black;
            this.AddRoomBtn.Location = new System.Drawing.Point(93, 374);
            this.AddRoomBtn.Name = "AddRoomBtn";
            this.AddRoomBtn.Size = new System.Drawing.Size(82, 34);
            this.AddRoomBtn.TabIndex = 19;
            this.AddRoomBtn.Text = "ADD";
            this.AddRoomBtn.UseVisualStyleBackColor = false;
            this.AddRoomBtn.Click += new System.EventHandler(this.AddRoomBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(778, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 34);
            this.button4.TabIndex = 24;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RoomSearchtb
            // 
            this.RoomSearchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomSearchtb.ForeColor = System.Drawing.Color.Black;
            this.RoomSearchtb.Location = new System.Drawing.Point(608, 145);
            this.RoomSearchtb.Name = "RoomSearchtb";
            this.RoomSearchtb.Size = new System.Drawing.Size(164, 26);
            this.RoomSearchtb.TabIndex = 23;
            // 
            // RoomGridView
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.RoomGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.RoomGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomGridView.BackgroundColor = System.Drawing.Color.White;
            this.RoomGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.RoomGridView.ColumnHeadersHeight = 20;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.RoomGridView.EnableHeadersVisualStyles = false;
            this.RoomGridView.GridColor = System.Drawing.Color.DodgerBlue;
            this.RoomGridView.Location = new System.Drawing.Point(342, 180);
            this.RoomGridView.Name = "RoomGridView";
            this.RoomGridView.RowHeadersVisible = false;
            this.RoomGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomGridView.Size = new System.Drawing.Size(591, 347);
            this.RoomGridView.TabIndex = 22;
            this.RoomGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RoomGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RoomGridView.ThemeStyle.GridColor = System.Drawing.Color.DodgerBlue;
            this.RoomGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RoomGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RoomGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RoomGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RoomGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RoomGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.RoomGridView.ThemeStyle.ReadOnly = false;
            this.RoomGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RoomGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.RoomGridView.ThemeStyle.RowsStyle.Height = 22;
            this.RoomGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomGridView_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.toppng_com_refresh_icon_png_ico_980x980__1_;
            this.pictureBox1.Location = new System.Drawing.Point(897, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(93, 425);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 34);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(976, 571);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.RoomSearchtb);
            this.Controls.Add(this.RoomGridView);
            this.Controls.Add(this.RoomDeletebtn);
            this.Controls.Add(this.RoomEditbtn);
            this.Controls.Add(this.AddRoomBtn);
            this.Controls.Add(this.Noradio);
            this.Controls.Add(this.Yesradio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Roomphonetbl);
            this.Controls.Add(this.Roomnumtbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomInfo";
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Roomphonetbl;
        private System.Windows.Forms.TextBox Roomnumtbl;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaRadioButton Yesradio;
        private Guna.UI.WinForms.GunaRadioButton Noradio;
        private System.Windows.Forms.Button RoomDeletebtn;
        private System.Windows.Forms.Button RoomEditbtn;
        private System.Windows.Forms.Button AddRoomBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox RoomSearchtb;
        private Guna.UI.WinForms.GunaDataGridView RoomGridView;
        private System.Windows.Forms.Button btnBack;
    }
}