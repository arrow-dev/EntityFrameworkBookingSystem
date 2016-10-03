using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Data;
using HotelBookingSystem.Forms;
using HotelBookingSystem.Logic;

namespace HotelBookingSystem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            LoadDataGridViews();
        }

        private void LoadDataGridViews()
        {
            //Load data into gridviews
            dataGridViewGuests.DataSource = GuestController.GetAllGuestDetails();
            dataGridViewRooms.DataSource = RoomController.GetAllRoomDetails();
            dataGridViewAllBookings.DataSource = BookingController.GetAllBookingDetails();
            dataGridViewBookings.DataSource = BookingController.GetCurrentBookingDetails();
            dataGridViewInvoices.DataSource = InvoiceController.GetAllInvoiceDetails();

            //Set up event handlers to customize header names after data is loaded
            dataGridViewGuests.DataBindingComplete += DataGridViewGuests_DataBindingComplete;
            dataGridViewRooms.DataBindingComplete += DataGridViewRooms_DataBindingComplete;
            dataGridViewAllBookings.DataBindingComplete += DataGridViewAllBookings_DataBindingComplete;
            dataGridViewBookings.DataBindingComplete += DataGridViewBookings_DataBindingComplete;
            dataGridViewInvoices.DataBindingComplete += DataGridViewInvoices_DataBindingComplete;
        }

        private void DataGridViewGuests_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewGuests.Columns[0].HeaderText = "Guest ID";
            dataGridViewGuests.Columns[1].HeaderText = "First Name";
            dataGridViewGuests.Columns[2].HeaderText = "Last Name";
        }

        private void DataGridViewRooms_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewRooms.Columns[0].HeaderText = "Room ID";
            dataGridViewRooms.Columns[2].HeaderText = "Double Bed";
        }

        private void DataGridViewAllBookings_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewAllBookings.Columns[0].HeaderText = "Booking ID";
            dataGridViewAllBookings.Columns[1].HeaderText = "First Name";
            dataGridViewAllBookings.Columns[2].HeaderText = "Last Name";
            dataGridViewAllBookings.Columns[3].HeaderText = "Room ID";
            dataGridViewAllBookings.Columns[4].HeaderText = "Checkin";
            dataGridViewAllBookings.Columns[5].HeaderText = "Checkout";
            dataGridViewAllBookings.Columns[6].HeaderText = "Extra Beds";
        }

        private void DataGridViewBookings_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewBookings.Columns[0].HeaderText = "Booking ID";
            dataGridViewBookings.Columns[1].HeaderText = "First Name";
            dataGridViewBookings.Columns[2].HeaderText = "Last Name";
            dataGridViewBookings.Columns[3].HeaderText = "Room ID";
            dataGridViewBookings.Columns[4].HeaderText = "Checkin";
            dataGridViewBookings.Columns[5].HeaderText = "Checkout";
            dataGridViewBookings.Columns[6].HeaderText = "Extra Beds";
        }

        private void DataGridViewInvoices_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewInvoices.Columns[0].HeaderText = "Invoice ID";
            dataGridViewInvoices.Columns[1].HeaderText = "First Name";
            dataGridViewInvoices.Columns[2].HeaderText = "Last Name";
            dataGridViewInvoices.Columns[3].HeaderText = "Date Created";
            dataGridViewInvoices.Columns[4].HeaderText = "Date Charged";
        }

        //Open add guest form as a dialog, if it returns 'OK' result then reload the datagridviews
        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            if (new FormAddGuest().ShowDialog() == DialogResult.OK)
            {
              LoadDataGridViews();   
            }
        }

        //Open edit guest form as a dialog, if it returns 'OK' result then reload the datagridviews
        private void btnEditGuest_Click(object sender, EventArgs e)
        {
            if (dataGridViewGuests.SelectedRows.Count > 0)
            {
                if (new FormEditGuest(int.Parse(dataGridViewGuests.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog() == DialogResult.OK)
                {
                    LoadDataGridViews();
                }
            }
        }

        //Show a warning dialog and if it returns 'OK' result then delete the selected item
        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            if (dataGridViewGuests.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Guest and all associated data will be deleted!","Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    GuestController.DeleteGuestById(int.Parse(dataGridViewGuests.SelectedRows[0].Cells[0].Value.ToString()));
                    LoadDataGridViews();
                }
            }
        }

        //Open add room form as a dialog, if it returns 'OK' result then reload the datagridviews
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (new FormAddRoom().ShowDialog() == DialogResult.OK)
            {
                LoadDataGridViews();
            }
        }

        //Open edit room form as a dialog, if it returns 'OK' result then reload the datagridviews
        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                if (new FormEditRoom(int.Parse(dataGridViewRooms.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog() == DialogResult.OK)
                {
                    LoadDataGridViews();
                }
            }
        }

        //Add a bar charge to the selected booking
        private void btnBar_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                BookingController.AddBarCharge(Int32.Parse(dataGridViewBookings.SelectedRows[0].Cells[0].Value.ToString()), numericUpDownBar.Value);
                LoadDataGridViews();
            }
            else
            {
                NoBookingSelectedMessage();
            }

        }

        //Add a phone charge to the selected booking
        private void btnPhone_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                BookingController.AddPhoneCharge(
                    int.Parse(dataGridViewBookings.SelectedRows[0].Cells[0].Value.ToString()),
                    numericUpDownPhone.Value);
                LoadDataGridViews();
            }
            else
            {
                NoBookingSelectedMessage();
            }
        }

        //Show dialog, if 'OK' result then enable WIFI for the selected booking
        private void btnWIFI_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Enable WIFI for this booking?", "Enable WIFI", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BookingController.AddWifiCharge(int.Parse(dataGridViewBookings.SelectedRows[0].Cells[0].Value.ToString()));
                    LoadDataGridViews();
                }
            }
            else
            {
                NoBookingSelectedMessage();
            }
        }

        private void NoBookingSelectedMessage()
        {
            MessageBox.Show("You must select a booking!");
        }

        //Generate an invoice when the guest checks out
        private void btnChargeInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.SelectedRows.Count > 0)
            {
                if (InvoiceController.BookingsComplete(int.Parse(dataGridViewInvoices.SelectedRows[0].Cells[0].Value.ToString())))
                {
                    var invoice = InvoiceController.PrintInvoice(int.Parse(dataGridViewInvoices.SelectedRows[0].Cells[0].Value.ToString()));
                    MessageBox.Show(invoice);
                    LoadDataGridViews();
                }
                else
                {
                    MessageBox.Show("There are still active bookings for this invoice.");
                }
                
            }
        }

        //Delete selected room
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Room and all associated data will be deleted!", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    RoomController.DeleteRoomById(int.Parse(dataGridViewGuests.SelectedRows[0].Cells[0].Value.ToString()));
                    LoadDataGridViews();
                }
            }
        }

        //Open add booking form as a dialog, if it returns 'OK' result then reload the datagridviews
        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            if (new FormAddBooking().ShowDialog() == DialogResult.OK)
            {
                LoadDataGridViews();
            }
        }

        //Delete selected booking
        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllBookings.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Booking and all associated data will be deleted!", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BookingController.DeleteBookingById(int.Parse(dataGridViewAllBookings.SelectedRows[0].Cells[0].Value.ToString()));
                    LoadDataGridViews();
                }
            }
        }

        //Search functions
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewAllBookings.DataSource = BookingController.BookingsByName(txtSearch.Text);
        }

        private void txtSearchGuest_TextChanged(object sender, EventArgs e)
        {
            dataGridViewGuests.DataSource = GuestController.GuestsByName(txtSearchGuest.Text);
        }

        private void txtSearchInvoices_TextChanged(object sender, EventArgs e)
        {
            dataGridViewInvoices.DataSource = InvoiceController.InvoiceByName(txtSearchInvoices.Text);
        }
        //****************
    }
}
