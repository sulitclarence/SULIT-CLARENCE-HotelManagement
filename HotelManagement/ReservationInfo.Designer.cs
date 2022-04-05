namespace HotelManagement
{
    partial class ReservationInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReserId = new System.Windows.Forms.TextBox();
            this.Datein = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dateout = new System.Windows.Forms.DateTimePicker();
            this.ReservationGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Reservationsearchtb = new System.Windows.Forms.TextBox();
            this.RoomDeletebtn = new System.Windows.Forms.Button();
            this.RoomEditbtn = new System.Windows.Forms.Button();
            this.AddRoomBtn = new System.Windows.Forms.Button();
            this.Clientcb = new System.Windows.Forms.ComboBox();
            this.roomcb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.resIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationtblBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(967, 100);
            this.panel1.TabIndex = 3;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.Black;
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
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservation Information";
            // 
            // ReserId
            // 
            this.ReserId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserId.ForeColor = System.Drawing.Color.Black;
            this.ReserId.Location = new System.Drawing.Point(100, 200);
            this.ReserId.Name = "ReserId";
            this.ReserId.Size = new System.Drawing.Size(164, 26);
            this.ReserId.TabIndex = 8;
            this.ReserId.Text = "Rerservation ID";
            // 
            // Datein
            // 
            this.Datein.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datein.Location = new System.Drawing.Point(47, 352);
            this.Datein.Name = "Datein";
            this.Datein.Size = new System.Drawing.Size(217, 22);
            this.Datein.TabIndex = 11;
            this.Datein.ValueChanged += new System.EventHandler(this.Datein_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(127, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(110, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date Out";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Dateout
            // 
            this.Dateout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dateout.Location = new System.Drawing.Point(47, 412);
            this.Dateout.Name = "Dateout";
            this.Dateout.Size = new System.Drawing.Size(217, 22);
            this.Dateout.TabIndex = 13;
            this.Dateout.ValueChanged += new System.EventHandler(this.Dateout_ValueChanged);
            // 
            // ReservationGridView
            // 
            this.ReservationGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ReservationGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReservationGridView.AutoGenerateColumns = false;
            this.ReservationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReservationGridView.BackgroundColor = System.Drawing.Color.White;
            this.ReservationGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReservationGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReservationGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReservationGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ReservationGridView.ColumnHeadersHeight = 20;
            this.ReservationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resIdDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.dateOutDataGridViewTextBoxColumn});
            this.ReservationGridView.DataSource = this.reservationtblBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReservationGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReservationGridView.EnableHeadersVisualStyles = false;
            this.ReservationGridView.GridColor = System.Drawing.Color.DodgerBlue;
            this.ReservationGridView.Location = new System.Drawing.Point(284, 183);
            this.ReservationGridView.Name = "ReservationGridView";
            this.ReservationGridView.RowHeadersVisible = false;
            this.ReservationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReservationGridView.Size = new System.Drawing.Size(645, 347);
            this.ReservationGridView.TabIndex = 26;
            this.ReservationGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReservationGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReservationGridView.ThemeStyle.GridColor = System.Drawing.Color.DodgerBlue;
            this.ReservationGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ReservationGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReservationGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ReservationGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReservationGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReservationGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.ReservationGridView.ThemeStyle.ReadOnly = false;
            this.ReservationGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReservationGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReservationGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ReservationGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ReservationGridView.ThemeStyle.RowsStyle.Height = 22;
            this.ReservationGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReservationGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReservationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationGridView_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.toppng_com_refresh_icon_png_ico_980x980__1_;
            this.pictureBox1.Location = new System.Drawing.Point(893, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(774, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 31;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reservationsearchtb
            // 
            this.Reservationsearchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservationsearchtb.ForeColor = System.Drawing.Color.Black;
            this.Reservationsearchtb.Location = new System.Drawing.Point(604, 148);
            this.Reservationsearchtb.Name = "Reservationsearchtb";
            this.Reservationsearchtb.Size = new System.Drawing.Size(164, 26);
            this.Reservationsearchtb.TabIndex = 30;
            // 
            // RoomDeletebtn
            // 
            this.RoomDeletebtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.RoomDeletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomDeletebtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomDeletebtn.ForeColor = System.Drawing.Color.Black;
            this.RoomDeletebtn.Location = new System.Drawing.Point(163, 489);
            this.RoomDeletebtn.Name = "RoomDeletebtn";
            this.RoomDeletebtn.Size = new System.Drawing.Size(80, 34);
            this.RoomDeletebtn.TabIndex = 35;
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
            this.RoomEditbtn.Location = new System.Drawing.Point(163, 449);
            this.RoomEditbtn.Name = "RoomEditbtn";
            this.RoomEditbtn.Size = new System.Drawing.Size(80, 34);
            this.RoomEditbtn.TabIndex = 34;
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
            this.AddRoomBtn.Location = new System.Drawing.Point(68, 449);
            this.AddRoomBtn.Name = "AddRoomBtn";
            this.AddRoomBtn.Size = new System.Drawing.Size(80, 34);
            this.AddRoomBtn.TabIndex = 33;
            this.AddRoomBtn.Text = "ADD";
            this.AddRoomBtn.UseVisualStyleBackColor = false;
            this.AddRoomBtn.Click += new System.EventHandler(this.AddRoomBtn_Click);
            // 
            // Clientcb
            // 
            this.Clientcb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientcb.ForeColor = System.Drawing.Color.Black;
            this.Clientcb.FormattingEnabled = true;
            this.Clientcb.Location = new System.Drawing.Point(100, 240);
            this.Clientcb.Name = "Clientcb";
            this.Clientcb.Size = new System.Drawing.Size(164, 26);
            this.Clientcb.TabIndex = 36;
            this.Clientcb.Text = "Client Name";
            this.Clientcb.SelectedIndexChanged += new System.EventHandler(this.Clientcb_SelectedIndexChanged);
            // 
            // roomcb
            // 
            this.roomcb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomcb.ForeColor = System.Drawing.Color.Black;
            this.roomcb.FormattingEnabled = true;
            this.roomcb.Location = new System.Drawing.Point(100, 284);
            this.roomcb.Name = "roomcb";
            this.roomcb.Size = new System.Drawing.Size(164, 26);
            this.roomcb.TabIndex = 37;
            this.roomcb.Text = "Room ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 38;
            this.label4.Text = "Client";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 39;
            this.label5.Text = "Room";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(68, 489);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 34);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(68, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 34);
            this.button2.TabIndex = 41;
            this.button2.Text = "PRINT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // resIdDataGridViewTextBoxColumn
            // 
            this.resIdDataGridViewTextBoxColumn.DataPropertyName = "ResId";
            this.resIdDataGridViewTextBoxColumn.HeaderText = "ResId";
            this.resIdDataGridViewTextBoxColumn.Name = "resIdDataGridViewTextBoxColumn";
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "DateIn";
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            // 
            // dateOutDataGridViewTextBoxColumn
            // 
            this.dateOutDataGridViewTextBoxColumn.DataPropertyName = "DateOut";
            this.dateOutDataGridViewTextBoxColumn.HeaderText = "DateOut";
            this.dateOutDataGridViewTextBoxColumn.Name = "dateOutDataGridViewTextBoxColumn";
            // 
            // reservationtblBindingSource
            // 
            this.reservationtblBindingSource.DataSource = typeof(HotelManagement.Reservation_tbl);
            // 
            // ReservationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(967, 582);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roomcb);
            this.Controls.Add(this.Clientcb);
            this.Controls.Add(this.RoomDeletebtn);
            this.Controls.Add(this.RoomEditbtn);
            this.Controls.Add(this.AddRoomBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Reservationsearchtb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReservationGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dateout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Datein);
            this.Controls.Add(this.ReserId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationInfo";
            this.Load += new System.EventHandler(this.ReservationInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationtblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReserId;
        private System.Windows.Forms.DateTimePicker Datein;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Dateout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDataGridView ReservationGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Reservationsearchtb;
        private System.Windows.Forms.Button RoomDeletebtn;
        private System.Windows.Forms.Button RoomEditbtn;
        private System.Windows.Forms.Button AddRoomBtn;
        private System.Windows.Forms.ComboBox Clientcb;
        private System.Windows.Forms.ComboBox roomcb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn resIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservationtblBindingSource;
    }
}