namespace HotelBookingSystem
{
    partial class FormMain
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.tabGuests = new System.Windows.Forms.TabPage();
            this.btnEditGuest = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.dataGridViewGuests = new System.Windows.Forms.DataGridView();
            this.tabInvoices = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.numericUpDownBar = new System.Windows.Forms.NumericUpDown();
            this.lblBarCharge = new System.Windows.Forms.Label();
            this.btnBar = new System.Windows.Forms.Button();
            this.btnPhone = new System.Windows.Forms.Button();
            this.lblPhoneCharge = new System.Windows.Forms.Label();
            this.numericUpDownPhone = new System.Windows.Forms.NumericUpDown();
            this.checkBoxWIFI = new System.Windows.Forms.CheckBox();
            this.lblBookingManagement = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.tabRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.tabGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).BeginInit();
            this.tabInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBookings);
            this.tabControl.Controls.Add(this.tabRooms);
            this.tabControl.Controls.Add(this.tabGuests);
            this.tabControl.Controls.Add(this.tabInvoices);
            this.tabControl.Location = new System.Drawing.Point(37, 165);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1117, 345);
            this.tabControl.TabIndex = 0;
            // 
            // tabBookings
            // 
            this.tabBookings.Controls.Add(this.lblBookingManagement);
            this.tabBookings.Controls.Add(this.btnNewBooking);
            this.tabBookings.Controls.Add(this.checkBoxWIFI);
            this.tabBookings.Controls.Add(this.btnPhone);
            this.tabBookings.Controls.Add(this.lblPhoneCharge);
            this.tabBookings.Controls.Add(this.numericUpDownPhone);
            this.tabBookings.Controls.Add(this.btnBar);
            this.tabBookings.Controls.Add(this.lblBarCharge);
            this.tabBookings.Controls.Add(this.numericUpDownBar);
            this.tabBookings.Controls.Add(this.dataGridViewBookings);
            this.tabBookings.Location = new System.Drawing.Point(4, 22);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookings.Size = new System.Drawing.Size(1109, 319);
            this.tabBookings.TabIndex = 1;
            this.tabBookings.Text = "Bookings";
            this.tabBookings.UseVisualStyleBackColor = true;
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.Location = new System.Drawing.Point(852, 208);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(108, 26);
            this.btnNewBooking.TabIndex = 6;
            this.btnNewBooking.Text = "New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = true;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewBookings.MultiSelect = false;
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.RowHeadersVisible = false;
            this.dataGridViewBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookings.Size = new System.Drawing.Size(822, 307);
            this.dataGridViewBookings.TabIndex = 1;
            // 
            // tabRooms
            // 
            this.tabRooms.Controls.Add(this.btnEditRoom);
            this.tabRooms.Controls.Add(this.btnAddRoom);
            this.tabRooms.Controls.Add(this.dataGridViewRooms);
            this.tabRooms.Location = new System.Drawing.Point(4, 22);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabRooms.Size = new System.Drawing.Size(1109, 319);
            this.tabRooms.TabIndex = 2;
            this.tabRooms.Text = "Rooms";
            this.tabRooms.UseVisualStyleBackColor = true;
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.Location = new System.Drawing.Point(834, 45);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(269, 23);
            this.btnEditRoom.TabIndex = 5;
            this.btnEditRoom.Text = "Edit Room";
            this.btnEditRoom.UseVisualStyleBackColor = true;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(834, 16);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(269, 23);
            this.btnAddRoom.TabIndex = 4;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewRooms.MultiSelect = false;
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.RowHeadersVisible = false;
            this.dataGridViewRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRooms.Size = new System.Drawing.Size(822, 307);
            this.dataGridViewRooms.TabIndex = 3;
            // 
            // tabGuests
            // 
            this.tabGuests.Controls.Add(this.btnEditGuest);
            this.tabGuests.Controls.Add(this.btnAddGuest);
            this.tabGuests.Controls.Add(this.dataGridViewGuests);
            this.tabGuests.Location = new System.Drawing.Point(4, 22);
            this.tabGuests.Name = "tabGuests";
            this.tabGuests.Padding = new System.Windows.Forms.Padding(3);
            this.tabGuests.Size = new System.Drawing.Size(1109, 319);
            this.tabGuests.TabIndex = 0;
            this.tabGuests.Text = "Guests";
            this.tabGuests.UseVisualStyleBackColor = true;
            // 
            // btnEditGuest
            // 
            this.btnEditGuest.Location = new System.Drawing.Point(834, 45);
            this.btnEditGuest.Name = "btnEditGuest";
            this.btnEditGuest.Size = new System.Drawing.Size(269, 23);
            this.btnEditGuest.TabIndex = 2;
            this.btnEditGuest.Text = "Edit Guest";
            this.btnEditGuest.UseVisualStyleBackColor = true;
            this.btnEditGuest.Click += new System.EventHandler(this.btnEditGuest_Click);
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Location = new System.Drawing.Point(834, 16);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(269, 23);
            this.btnAddGuest.TabIndex = 1;
            this.btnAddGuest.Text = "Add Guest";
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // dataGridViewGuests
            // 
            this.dataGridViewGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuests.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewGuests.MultiSelect = false;
            this.dataGridViewGuests.Name = "dataGridViewGuests";
            this.dataGridViewGuests.RowHeadersVisible = false;
            this.dataGridViewGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGuests.Size = new System.Drawing.Size(822, 307);
            this.dataGridViewGuests.TabIndex = 0;
            // 
            // tabInvoices
            // 
            this.tabInvoices.Controls.Add(this.button1);
            this.tabInvoices.Controls.Add(this.dataGridViewInvoices);
            this.tabInvoices.Location = new System.Drawing.Point(4, 22);
            this.tabInvoices.Name = "tabInvoices";
            this.tabInvoices.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoices.Size = new System.Drawing.Size(1109, 319);
            this.tabInvoices.TabIndex = 3;
            this.tabInvoices.Text = "Invoices";
            this.tabInvoices.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Charge Invoice";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInvoices
            // 
            this.dataGridViewInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoices.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewInvoices.MultiSelect = false;
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.RowHeadersVisible = false;
            this.dataGridViewInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvoices.Size = new System.Drawing.Size(822, 307);
            this.dataGridViewInvoices.TabIndex = 2;
            // 
            // numericUpDownBar
            // 
            this.numericUpDownBar.DecimalPlaces = 2;
            this.numericUpDownBar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownBar.Location = new System.Drawing.Point(852, 62);
            this.numericUpDownBar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownBar.Name = "numericUpDownBar";
            this.numericUpDownBar.Size = new System.Drawing.Size(108, 20);
            this.numericUpDownBar.TabIndex = 7;
            // 
            // lblBarCharge
            // 
            this.lblBarCharge.AutoSize = true;
            this.lblBarCharge.Location = new System.Drawing.Point(833, 64);
            this.lblBarCharge.Name = "lblBarCharge";
            this.lblBarCharge.Size = new System.Drawing.Size(13, 13);
            this.lblBarCharge.TabIndex = 8;
            this.lblBarCharge.Text = "$";
            // 
            // btnBar
            // 
            this.btnBar.Location = new System.Drawing.Point(966, 60);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(136, 23);
            this.btnBar.TabIndex = 9;
            this.btnBar.Text = "Add bar charge";
            this.btnBar.UseVisualStyleBackColor = true;
            // 
            // btnPhone
            // 
            this.btnPhone.Location = new System.Drawing.Point(966, 106);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(136, 23);
            this.btnPhone.TabIndex = 12;
            this.btnPhone.Text = "Add phone charge";
            this.btnPhone.UseVisualStyleBackColor = true;
            // 
            // lblPhoneCharge
            // 
            this.lblPhoneCharge.AutoSize = true;
            this.lblPhoneCharge.Location = new System.Drawing.Point(833, 110);
            this.lblPhoneCharge.Name = "lblPhoneCharge";
            this.lblPhoneCharge.Size = new System.Drawing.Size(13, 13);
            this.lblPhoneCharge.TabIndex = 11;
            this.lblPhoneCharge.Text = "$";
            // 
            // numericUpDownPhone
            // 
            this.numericUpDownPhone.DecimalPlaces = 2;
            this.numericUpDownPhone.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPhone.Location = new System.Drawing.Point(852, 108);
            this.numericUpDownPhone.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPhone.Name = "numericUpDownPhone";
            this.numericUpDownPhone.Size = new System.Drawing.Size(108, 20);
            this.numericUpDownPhone.TabIndex = 10;
            // 
            // checkBoxWIFI
            // 
            this.checkBoxWIFI.AutoSize = true;
            this.checkBoxWIFI.Location = new System.Drawing.Point(852, 160);
            this.checkBoxWIFI.Name = "checkBoxWIFI";
            this.checkBoxWIFI.Size = new System.Drawing.Size(85, 17);
            this.checkBoxWIFI.TabIndex = 13;
            this.checkBoxWIFI.Text = "Enable WIFI";
            this.checkBoxWIFI.UseVisualStyleBackColor = true;
            // 
            // lblBookingManagement
            // 
            this.lblBookingManagement.AutoSize = true;
            this.lblBookingManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingManagement.Location = new System.Drawing.Point(848, 28);
            this.lblBookingManagement.Name = "lblBookingManagement";
            this.lblBookingManagement.Size = new System.Drawing.Size(137, 20);
            this.lblBookingManagement.TabIndex = 14;
            this.lblBookingManagement.Text = "Manage Bookings";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 537);
            this.Controls.Add(this.tabControl);
            this.Name = "FormMain";
            this.Text = "Hotel Booking System";
            this.tabControl.ResumeLayout(false);
            this.tabBookings.ResumeLayout(false);
            this.tabBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.tabRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.tabGuests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).EndInit();
            this.tabInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGuests;
        private System.Windows.Forms.DataGridView dataGridViewGuests;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Button btnEditGuest;
        private System.Windows.Forms.TabPage tabRooms;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.TabPage tabInvoices;
        private System.Windows.Forms.DataGridView dataGridViewInvoices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownBar;
        private System.Windows.Forms.CheckBox checkBoxWIFI;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Label lblPhoneCharge;
        private System.Windows.Forms.NumericUpDown numericUpDownPhone;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Label lblBarCharge;
        private System.Windows.Forms.Label lblBookingManagement;
    }
}

