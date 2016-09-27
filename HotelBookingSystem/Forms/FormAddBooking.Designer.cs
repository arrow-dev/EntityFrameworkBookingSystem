namespace HotelBookingSystem.Forms
{
    partial class FormAddBooking
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
            this.dataGridViewAvailableRooms = new System.Windows.Forms.DataGridView();
            this.dataGridViewGuests = new System.Windows.Forms.DataGridView();
            this.lblAv = new System.Windows.Forms.Label();
            this.lblGuests = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.numExtraBeds = new System.Windows.Forms.NumericUpDown();
            this.lblExtraBeds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraBeds)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAvailableRooms
            // 
            this.dataGridViewAvailableRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableRooms.Location = new System.Drawing.Point(12, 25);
            this.dataGridViewAvailableRooms.MultiSelect = false;
            this.dataGridViewAvailableRooms.Name = "dataGridViewAvailableRooms";
            this.dataGridViewAvailableRooms.RowHeadersVisible = false;
            this.dataGridViewAvailableRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvailableRooms.Size = new System.Drawing.Size(473, 160);
            this.dataGridViewAvailableRooms.TabIndex = 2;
            // 
            // dataGridViewGuests
            // 
            this.dataGridViewGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuests.Location = new System.Drawing.Point(12, 217);
            this.dataGridViewGuests.MultiSelect = false;
            this.dataGridViewGuests.Name = "dataGridViewGuests";
            this.dataGridViewGuests.RowHeadersVisible = false;
            this.dataGridViewGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGuests.Size = new System.Drawing.Size(473, 160);
            this.dataGridViewGuests.TabIndex = 3;
            // 
            // lblAv
            // 
            this.lblAv.AutoSize = true;
            this.lblAv.Location = new System.Drawing.Point(12, 9);
            this.lblAv.Name = "lblAv";
            this.lblAv.Size = new System.Drawing.Size(86, 13);
            this.lblAv.TabIndex = 4;
            this.lblAv.Text = "Available Rooms";
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Location = new System.Drawing.Point(12, 201);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(40, 13);
            this.lblGuests.TabIndex = 5;
            this.lblGuests.Text = "Guests";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(691, 25);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckIn.TabIndex = 6;
            this.dtpCheckIn.Value = new System.DateTime(2016, 9, 21, 8, 53, 38, 0);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(688, 9);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(49, 13);
            this.lblCheckIn.TabIndex = 7;
            this.lblCheckIn.Text = "Check in";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(688, 69);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(56, 13);
            this.lblCheckOut.TabIndex = 8;
            this.lblCheckOut.Text = "Check out";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(691, 85);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOut.TabIndex = 9;
            this.dtpCheckOut.Value = new System.DateTime(2016, 9, 21, 8, 54, 38, 0);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(691, 217);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(200, 160);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "Create Booking";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // numExtraBeds
            // 
            this.numExtraBeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numExtraBeds.Location = new System.Drawing.Point(691, 151);
            this.numExtraBeds.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numExtraBeds.Name = "numExtraBeds";
            this.numExtraBeds.ReadOnly = true;
            this.numExtraBeds.Size = new System.Drawing.Size(53, 26);
            this.numExtraBeds.TabIndex = 11;
            // 
            // lblExtraBeds
            // 
            this.lblExtraBeds.AutoSize = true;
            this.lblExtraBeds.Location = new System.Drawing.Point(688, 135);
            this.lblExtraBeds.Name = "lblExtraBeds";
            this.lblExtraBeds.Size = new System.Drawing.Size(57, 13);
            this.lblExtraBeds.TabIndex = 12;
            this.lblExtraBeds.Text = "Extra beds";
            // 
            // FormAddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 411);
            this.Controls.Add(this.lblExtraBeds);
            this.Controls.Add(this.numExtraBeds);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.lblAv);
            this.Controls.Add(this.dataGridViewGuests);
            this.Controls.Add(this.dataGridViewAvailableRooms);
            this.Name = "FormAddBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Booking";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraBeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAvailableRooms;
        private System.Windows.Forms.DataGridView dataGridViewGuests;
        private System.Windows.Forms.Label lblAv;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.NumericUpDown numExtraBeds;
        private System.Windows.Forms.Label lblExtraBeds;
    }
}