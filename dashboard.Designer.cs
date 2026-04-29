namespace Reservation
{
    partial class dashboard
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
            panel1 = new Panel();
            btnClient = new Button();
            button1 = new Button();
            lblTitle = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            panel2 = new Panel();
            lblIncome = new Label();
            panel3 = new Panel();
            lblGuests = new Label();
            panel4 = new Panel();
            lblBooking = new Label();
            panel5 = new Panel();
            lblRooms = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panelAdmin = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(btnClient);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(130, 442);
            panel1.TabIndex = 0;
            // 
            // btnClient
            // 
            btnClient.BackColor = Color.CadetBlue;
            btnClient.BackgroundImageLayout = ImageLayout.Zoom;
            btnClient.Cursor = Cursors.Hand;
            btnClient.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClient.ForeColor = Color.WhiteSmoke;
            btnClient.Location = new Point(3, 151);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(124, 61);
            btnClient.TabIndex = 2;
            btnClient.Text = "CLIENT";
            btnClient.UseVisualStyleBackColor = false;
            btnClient.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(3, 84);
            button1.Name = "button1";
            button1.Size = new Size(124, 61);
            button1.TabIndex = 1;
            button1.Text = "ADMIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Verdana", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.WhiteSmoke;
            lblTitle.Location = new Point(12, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "OASIS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(148, 19);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 1;
            label1.Text = "Admin's Panel";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.CadetBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Room", "Guest", "Destination", "Reservation", "Amenities" });
            comboBox1.Location = new Point(2, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(46, 23);
            comboBox1.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(530, 409);
            button3.Name = "button3";
            button3.Size = new Size(57, 25);
            button3.TabIndex = 3;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(lblIncome);
            panel2.Location = new Point(14, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 91);
            panel2.TabIndex = 4;
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIncome.ImageAlign = ContentAlignment.TopLeft;
            lblIncome.Location = new Point(3, 0);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(103, 19);
            lblIncome.TabIndex = 0;
            lblIncome.Text = "Total Income";
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Controls.Add(lblGuests);
            panel3.Location = new Point(162, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(120, 91);
            panel3.TabIndex = 5;
            // 
            // lblGuests
            // 
            lblGuests.AutoSize = true;
            lblGuests.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGuests.ImageAlign = ContentAlignment.TopLeft;
            lblGuests.Location = new Point(0, 0);
            lblGuests.Name = "lblGuests";
            lblGuests.Size = new Size(97, 19);
            lblGuests.TabIndex = 1;
            lblGuests.Text = "Total Guests";
            // 
            // panel4
            // 
            panel4.BackColor = Color.CadetBlue;
            panel4.Controls.Add(lblBooking);
            panel4.Location = new Point(305, 66);
            panel4.Name = "panel4";
            panel4.Size = new Size(120, 91);
            panel4.TabIndex = 5;
            // 
            // lblBooking
            // 
            lblBooking.AutoSize = true;
            lblBooking.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBooking.ImageAlign = ContentAlignment.TopLeft;
            lblBooking.Location = new Point(3, 0);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(114, 19);
            lblBooking.TabIndex = 1;
            lblBooking.Text = "Total Bookings";
            // 
            // panel5
            // 
            panel5.BackColor = Color.CadetBlue;
            panel5.Controls.Add(lblRooms);
            panel5.Location = new Point(447, 66);
            panel5.Name = "panel5";
            panel5.Size = new Size(120, 91);
            panel5.TabIndex = 5;
            // 
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRooms.ImageAlign = ContentAlignment.TopLeft;
            lblRooms.Location = new Point(3, 0);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new Size(99, 19);
            lblRooms.TabIndex = 1;
            lblRooms.Text = "Total Rooms";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CadetBlue;
            btnUpdate.Location = new Point(155, 172);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 35);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.CadetBlue;
            btnDelete.Location = new Point(295, 172);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 35);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.CadetBlue;
            btnRefresh.Location = new Point(431, 172);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(127, 35);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(541, 171);
            dataGridView1.TabIndex = 9;
            // 
            // panelAdmin
            // 
            panelAdmin.Controls.Add(dataGridView1);
            panelAdmin.Controls.Add(btnRefresh);
            panelAdmin.Controls.Add(button3);
            panelAdmin.Controls.Add(btnDelete);
            panelAdmin.Controls.Add(btnUpdate);
            panelAdmin.Controls.Add(panel5);
            panelAdmin.Controls.Add(panel4);
            panelAdmin.Controls.Add(panel3);
            panelAdmin.Controls.Add(panel2);
            panelAdmin.Controls.Add(comboBox1);
            panelAdmin.Controls.Add(label1);
            panelAdmin.Location = new Point(136, 2);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(587, 437);
            panelAdmin.TabIndex = 10;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 435);
            Controls.Add(panelAdmin);
            Controls.Add(panel1);
            Name = "dashboard";
            Text = "dashboard";
            Load += dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label lblTitle;
        private Button btnClient;
        private Label label1;
        private ComboBox comboBox1;
        private Button button3;
        private Panel panel2;
        private Label lblIncome;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label lblGuests;
        private Label lblBooking;
        private Label lblRooms;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Panel panelAdmin;
    }
}