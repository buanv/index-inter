namespace Reservation
{
    partial class clientroom
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
            dataGridView1 = new DataGridView();
            btnUpdate = new Button();
            button1 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(24, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(458, 185);
            dataGridView1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CadetBlue;
            btnUpdate.Location = new Point(24, 268);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 35);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Submit";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Location = new Point(355, 268);
            button1.Name = "button1";
            button1.Size = new Size(127, 35);
            button1.TabIndex = 8;
            button1.Text = "Description";
            button1.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Standard";
            Column1.HeaderText = "Room Type";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Capacity";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Room Rate";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Amenities";
            Column4.Name = "Column4";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Verdana", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.CadetBlue;
            lblTitle.Location = new Point(197, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 32);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "OASIS";
            // 
            // clientroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 504);
            Controls.Add(lblTitle);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(dataGridView1);
            Name = "clientroom";
            Text = "clientroom";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnUpdate;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label lblTitle;
    }
}