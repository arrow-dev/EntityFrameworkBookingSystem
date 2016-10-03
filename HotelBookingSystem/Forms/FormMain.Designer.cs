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
            this.tabAllBookings = new System.Windows.Forms.TabPage();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.dataGridViewAllBookings = new System.Windows.Forms.DataGridView();
            this.tabActiveBookings = new System.Windows.Forms.TabPage();
            this.lblWIFI = new System.Windows.Forms.Label();
            this.btnWIFI = new System.Windows.Forms.Button();
            this.lblBookingManagement = new System.Windows.Forms.Label();
            this.btnPhone = new System.Windows.Forms.Button();
            this.lblPhoneCharge = new System.Windows.Forms.Label();
            this.numericUpDownPhone = new System.Windows.Forms.NumericUpDown();
            this.btnBar = new System.Windows.Forms.Button();
            this.lblBarCharge = new System.Windows.Forms.Label();
            this.numericUpDownBar = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.tabGuests = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchGuest = new System.Windows.Forms.TextBox();
            this.btnDeleteGuest = new System.Windows.Forms.Button();
            this.btnEditGuest = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.dataGridViewGuests = new System.Windows.Forms.DataGridView();
            this.tabInvoices = new System.Windows.Forms.TabPage();
            this.btnChargeInvoice = new System.Windows.Forms.Button();
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.lblSearchInvoices = new System.Windows.Forms.Label();
            this.txtSearchInvoices = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabAllBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBookings)).BeginInit();
            this.tabActiveBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.tabRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.tabGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).BeginInit();
            this.tabInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAllBookings);
            this.tabControl.Controls.Add(this.tabActiveBookings);
            this.tabControl.Controls.Add(this.tabRooms);
            this.tabControl.Controls.Add(this.tabGuests);
            this.tabControl.Controls.Add(this.tabInvoices);
            this.tabControl.Location = new System.Drawing.Point(37, 165);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1117, 345);
            this.tabControl.TabIndex = 0;
            // 
            // tabAllBookings
            // 
            this.tabAllBookings.Controls.Add(this.lblSearch);
            this.tabAllBookings.Controls.Add(this.txtSearch);
            this.tabAllBookings.Controls.Add(this.btnDeleteBooking);
            this.tabAllBookings.Controls.Add(this.btnNewBooking);
            this.tabAllBookings.Controls.Add(this.dataGridViewAllBookings);
            this.tabAllBookings.Location = new System.Drawing.Point(4, 22);
            this.tabAllBookings.Name = "tabAllBookings";
            this.tabAllBookings.Size = new System.Drawing.Size(1109, 319);
            this.tabAllBookings.TabIndex = 4;
            this.tabAllBookings.Text = "All Bookings";
            this.tabAllBookings.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(831, 103);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(878, 100);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(834, 45);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(269, 23);
            this.btnDeleteBooking.TabIndex = 8;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.Location = new System.Drawing.Point(834, 16);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(269, 23);
            this.btnNewBooking.TabIndex = 7;
            this.btnNewBooking.Text = "New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = true;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // dataGridViewAllBookings
            // 
            this.dataGridViewAllBookings.AllowUserToOrderColumns = true;
            this.dataGridViewAllBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllBookings.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewAllBookings.MultiSelect = false;
            this.dataGridViewAllBookings.Name = "dataGridViewAllBookings";
            this.dataGridViewAllBookings.RowHeadersVisible = false;
            this.dataGridViewAllBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllBookings.Size = new System.Drawing.Size(822, 307);
            this.dataGridViewAllBookings.TabIndex = 2;
            // 
            // tabActiveBookings
            // 
            this.tabActiveBookings.Controls.Add(this.lblWIFI);
            this.tabActiveBookings.Controls.Add(this.btnWIFI);
            this.tabActiveBookings.Controls.Add(this.lblBookingManagement);
            this.tabActiveBookings.Controls.Add(this.btnPhone);
            this.tabActiveBookings.Controls.Add(this.lblPhoneCharge);
            this.tabActiveBookings.Controls.Add(this.numericUpDownPhone);
            this.tabActiveBookings.Controls.Add(this.btnBar);
            this.tabActiveBookings.Controls.Add(this.lblBarCharge);
            this.tabActiveBookings.Controls.Add(this.numericUpDownBar);
            this.tabActiveBookings.Controls.Add(this.dataGridViewBookings);
            this.tabActiveBookings.Location = new System.Drawing.Point(4, 22);
            this.tabActiveBookings.Name = "tabActiveBookings";
            this.tabActiveBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabActiveBookings.Size = new System.Drawing.Size(1109, 319);
            this.tabActiveBookings.TabIndex = 1;
            this.tabActiveBookings.Text = "Active Bookings";
            this.tabActiveBookings.UseVisualStyleBackColor = true;
            // 
            // lblWIFI
            // 
            this.lblWIFI.AutoSize = true;
            this.lblWIFI.Location = new System.Drawing.Point(841, 152);
            this.lblWIFI.Name = "lblWIFI";
            this.lblWIFI.Size = new System.Drawing.Size(119, 26);
            this.lblWIFI.TabIndex = 16;
            this.lblWIFI.Text = "Enable WIFI for the \r\nduration of the booking.";
            // 
            // btnWIFI
            // 
            this.btnWIFI.Location = new System.Drawing.Point(966, 152);
            this.btnWIFI.Name = "btnWIFI";
            this.btnWIFI.Size = new System.Drawing.Size(136, 26);
            this.btnWIFI.TabIndex = 15;
            this.btnWIFI.Text = "Enable WIFI";
            this.btnWIFI.UseVisualStyleBackColor = true;
            this.btnWIFI.Click += new System.EventHandler(this.btnWIFI_Click);
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
            // btnPhone
            // 
            this.btnPhone.Location = new System.Drawing.Point(966, 106);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(136, 23);
            this.btnPhone.TabIndex = 12;
            this.btnPhone.Text = "Add phone charge";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
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
            // btnBar
            // 
            this.btnBar.Location = new System.Drawing.Point(966, 60);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(136, 23);
            this.btnBar.TabIndex = 9;
            this.btnBar.Text = "Add bar charge";
            this.btnBar.UseVisualStyleBackColor = true;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
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
            this.tabRooms.Controls.Add(this.btnDeleteRoom);
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
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(834, 74);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(269, 23);
            this.btnDeleteRoom.TabIndex = 6;
            this.btnDeleteRoom.Text = "Delete Room";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
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
            this.tabGuests.Controls.Add(this.label1);
            this.tabGuests.Controls.Add(this.txtSearchGuest);
            this.tabGuests.Controls.Add(this.btnDeleteGuest);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(831, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search";
            // 
            // txtSearchGuest
            // 
            this.txtSearchGuest.Location = new System.Drawing.Point(878, 109);
            this.txtSearchGuest.Name = "txtSearchGuest";
            this.txtSearchGuest.Size = new System.Drawing.Size(225, 20);
            this.txtSearchGuest.TabIndex = 11;
            this.txtSearchGuest.TextChanged += new System.EventHandler(this.txtSearchGuest_TextChanged);
            // 
            // btnDeleteGuest
            // 
            this.btnDeleteGuest.Location = new System.Drawing.Point(834, 74);
            this.btnDeleteGuest.Name = "btnDeleteGuest";
            this.btnDeleteGuest.Size = new System.Drawing.Size(269, 23);
            this.btnDeleteGuest.TabIndex = 3;
            this.btnDeleteGuest.Text = "Delete Guest";
            this.btnDeleteGuest.UseVisualStyleBackColor = true;
            this.btnDeleteGuest.Click += new System.EventHandler(this.btnDeleteGuest_Click);
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
            this.tabInvoices.Controls.Add(this.lblSearchInvoices);
            this.tabInvoices.Controls.Add(this.txtSearchInvoices);
            this.tabInvoices.Controls.Add(this.btnChargeInvoice);
            this.tabInvoices.Controls.Add(this.dataGridViewInvoices);
            this.tabInvoices.Location = new System.Drawing.Point(4, 22);
            this.tabInvoices.Name = "tabInvoices";
            this.tabInvoices.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoices.Size = new System.Drawing.Size(1109, 319);
            this.tabInvoices.TabIndex = 3;
            this.tabInvoices.Text = "Invoices";
            this.tabInvoices.UseVisualStyleBackColor = true;
            // 
            // btnChargeInvoice
            // 
            this.btnChargeInvoice.Location = new System.Drawing.Point(834, 16);
            this.btnChargeInvoice.Name = "btnChargeInvoice";
            this.btnChargeInvoice.Size = new System.Drawing.Size(269, 23);
            this.btnChargeInvoice.TabIndex = 3;
            this.btnChargeInvoice.Text = "Charge Invoice";
            this.btnChargeInvoice.UseVisualStyleBackColor = true;
            this.btnChargeInvoice.Click += new System.EventHandler(this.btnChargeInvoice_Click);
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
            // lblSearchInvoices
            // 
            this.lblSearchInvoices.AutoSize = true;
            this.lblSearchInvoices.Location = new System.Drawing.Point(831, 54);
            this.lblSearchInvoices.Name = "lblSearchInvoices";
            this.lblSearchInvoices.Size = new System.Drawing.Size(41, 13);
            this.lblSearchInvoices.TabIndex = 14;
            this.lblSearchInvoices.Text = "Search";
            // 
            // txtSearchInvoices
            // 
            this.txtSearchInvoices.Location = new System.Drawing.Point(878, 51);
            this.txtSearchInvoices.Name = "txtSearchInvoices";
            this.txtSearchInvoices.Size = new System.Drawing.Size(225, 20);
            this.txtSearchInvoices.TabIndex = 13;
            this.txtSearchInvoices.TextChanged += new System.EventHandler(this.txtSearchInvoices_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 537);
            this.Controls.Add(this.tabControl);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Booking System";
            this.tabControl.ResumeLayout(false);
            this.tabAllBookings.ResumeLayout(false);
            this.tabAllBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBookings)).EndInit();
            this.tabActiveBookings.ResumeLayout(false);
            this.tabActiveBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.tabRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.tabGuests.ResumeLayout(false);
            this.tabGuests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).EndInit();
            this.tabInvoices.ResumeLayout(false);
            this.tabInvoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
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
        private System.Windows.Forms.TabPage tabActiveBookings;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.TabPage tabInvoices;
        private System.Windows.Forms.DataGridView dataGridViewInvoices;
        private System.Windows.Forms.Button btnChargeInvoice;
        private System.Windows.Forms.NumericUpDown numericUpDownBar;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Label lblPhoneCharge;
        private System.Windows.Forms.NumericUpDown numericUpDownPhone;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Label lblBarCharge;
        private System.Windows.Forms.Label lblBookingManagement;
        private System.Windows.Forms.Label lblWIFI;
        private System.Windows.Forms.Button btnWIFI;
        private System.Windows.Forms.TabPage tabAllBookings;
        private System.Windows.Forms.DataGridView dataGridViewAllBookings;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.Button btnDeleteGuest;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchGuest;
        private System.Windows.Forms.Label lblSearchInvoices;
        private System.Windows.Forms.TextBox txtSearchInvoices;
    }
}

