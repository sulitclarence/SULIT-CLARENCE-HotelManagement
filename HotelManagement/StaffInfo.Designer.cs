namespace HotelManagement
{
    partial class StaffInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.staffphonetb = new System.Windows.Forms.TextBox();
            this.Staffnametbl = new System.Windows.Forms.TextBox();
            this.Staffidtbl = new System.Windows.Forms.TextBox();
            this.staffgendercb = new System.Windows.Forms.ComboBox();
            this.StaffGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.StaffSearchtb = new System.Windows.Forms.TextBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.StaffEditbtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(974, 100);
            this.panel1.TabIndex = 1;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff Information";
            // 
            // staffphonetb
            // 
            this.staffphonetb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffphonetb.ForeColor = System.Drawing.Color.Black;
            this.staffphonetb.Location = new System.Drawing.Point(94, 298);
            this.staffphonetb.Name = "staffphonetb";
            this.staffphonetb.Size = new System.Drawing.Size(164, 26);
            this.staffphonetb.TabIndex = 6;
            this.staffphonetb.Text = "Phone No.";
            this.staffphonetb.TextChanged += new System.EventHandler(this.staffphonetb_TextChanged);
            // 
            // Staffnametbl
            // 
            this.Staffnametbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staffnametbl.ForeColor = System.Drawing.Color.Black;
            this.Staffnametbl.Location = new System.Drawing.Point(94, 255);
            this.Staffnametbl.Name = "Staffnametbl";
            this.Staffnametbl.Size = new System.Drawing.Size(164, 26);
            this.Staffnametbl.TabIndex = 5;
            this.Staffnametbl.Text = "Staff Name";
            this.Staffnametbl.TextChanged += new System.EventHandler(this.Staffnametbl_TextChanged);
            // 
            // Staffidtbl
            // 
            this.Staffidtbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staffidtbl.ForeColor = System.Drawing.Color.Black;
            this.Staffidtbl.Location = new System.Drawing.Point(94, 213);
            this.Staffidtbl.Name = "Staffidtbl";
            this.Staffidtbl.Size = new System.Drawing.Size(164, 26);
            this.Staffidtbl.TabIndex = 4;
            this.Staffidtbl.Text = "Staff ID";
            this.Staffidtbl.TextChanged += new System.EventHandler(this.Staffidtbl_TextChanged);
            // 
            // staffgendercb
            // 
            this.staffgendercb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffgendercb.ForeColor = System.Drawing.Color.Black;
            this.staffgendercb.FormattingEnabled = true;
            this.staffgendercb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.staffgendercb.Location = new System.Drawing.Point(94, 384);
            this.staffgendercb.Name = "staffgendercb";
            this.staffgendercb.Size = new System.Drawing.Size(164, 26);
            this.staffgendercb.TabIndex = 7;
            this.staffgendercb.Text = "Gender";
            // 
            // StaffGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.StaffGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StaffGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffGridView.BackgroundColor = System.Drawing.Color.White;
            this.StaffGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StaffGridView.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.StaffGridView.EnableHeadersVisualStyles = false;
            this.StaffGridView.GridColor = System.Drawing.Color.DodgerBlue;
            this.StaffGridView.Location = new System.Drawing.Point(340, 187);
            this.StaffGridView.Name = "StaffGridView";
            this.StaffGridView.RowHeadersVisible = false;
            this.StaffGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffGridView.Size = new System.Drawing.Size(591, 347);
            this.StaffGridView.TabIndex = 12;
            this.StaffGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.StaffGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StaffGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StaffGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StaffGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StaffGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StaffGridView.ThemeStyle.GridColor = System.Drawing.Color.DodgerBlue;
            this.StaffGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StaffGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StaffGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StaffGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StaffGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StaffGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.StaffGridView.ThemeStyle.ReadOnly = false;
            this.StaffGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StaffGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.StaffGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StaffGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StaffGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffGridView_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.toppng_com_refresh_icon_png_ico_980x980__1_;
            this.pictureBox1.Location = new System.Drawing.Point(895, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(776, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 34);
            this.button4.TabIndex = 14;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // StaffSearchtb
            // 
            this.StaffSearchtb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffSearchtb.ForeColor = System.Drawing.Color.Black;
            this.StaffSearchtb.Location = new System.Drawing.Point(606, 152);
            this.StaffSearchtb.Name = "StaffSearchtb";
            this.StaffSearchtb.Size = new System.Drawing.Size(164, 26);
            this.StaffSearchtb.TabIndex = 13;
            this.StaffSearchtb.TextChanged += new System.EventHandler(this.ClientSearchtb_TextChanged);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.Black;
            this.Deletebtn.Location = new System.Drawing.Point(179, 477);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(79, 34);
            this.Deletebtn.TabIndex = 18;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // StaffEditbtn
            // 
            this.StaffEditbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.StaffEditbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffEditbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffEditbtn.ForeColor = System.Drawing.Color.Black;
            this.StaffEditbtn.Location = new System.Drawing.Point(179, 428);
            this.StaffEditbtn.Name = "StaffEditbtn";
            this.StaffEditbtn.Size = new System.Drawing.Size(79, 34);
            this.StaffEditbtn.TabIndex = 17;
            this.StaffEditbtn.Text = "EDIT";
            this.StaffEditbtn.UseVisualStyleBackColor = false;
            this.StaffEditbtn.Click += new System.EventHandler(this.StaffEditbtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Black;
            this.AddBtn.Location = new System.Drawing.Point(94, 428);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(79, 34);
            this.AddBtn.TabIndex = 16;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // passwordtb
            // 
            this.passwordtb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtb.ForeColor = System.Drawing.Color.Black;
            this.passwordtb.Location = new System.Drawing.Point(94, 340);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(164, 26);
            this.passwordtb.TabIndex = 19;
            this.passwordtb.Text = "Password";
            this.passwordtb.TextChanged += new System.EventHandler(this.passwordtb_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(94, 477);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 34);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(974, 567);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.StaffEditbtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.StaffSearchtb);
            this.Controls.Add(this.StaffGridView);
            this.Controls.Add(this.staffgendercb);
            this.Controls.Add(this.staffphonetb);
            this.Controls.Add(this.Staffnametbl);
            this.Controls.Add(this.Staffidtbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffInfo";
            this.Load += new System.EventHandler(this.StaffInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox staffphonetb;
        private System.Windows.Forms.TextBox Staffnametbl;
        private System.Windows.Forms.TextBox Staffidtbl;
        private System.Windows.Forms.ComboBox staffgendercb;
        private Guna.UI.WinForms.GunaDataGridView StaffGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox StaffSearchtb;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button StaffEditbtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Button btnBack;
    }
}