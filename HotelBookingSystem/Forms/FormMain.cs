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
            //Load data
            dataGridViewGuests.DataSource = GuestController.GetAllGuestDetails();
            dataGridViewRooms.DataSource = RoomController.GetAllRoomDetails();
            dataGridViewBookings.DataSource = BookingController.GetCurrentBookingDetails();
            dataGridViewInvoices.DataSource = InvoiceController.GetAllInvoiceDetails();

            //Set up event handlers to customize header names after data is loaded
            dataGridViewGuests.DataBindingComplete += DataGridViewGuests_DataBindingComplete;
            dataGridViewRooms.DataBindingComplete += DataGridViewRooms_DataBindingComplete;
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

        private void DataGridViewBookings_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void DataGridViewInvoices_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            if (new FormAddGuest().ShowDialog() == DialogResult.OK)
            {
              LoadDataGridViews();   
            }
        }

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

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (new FormAddRoom().ShowDialog() == DialogResult.OK)
            {
                LoadDataGridViews();
            }
        }

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
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            if (new FormAddBooking().ShowDialog() == DialogResult.OK)
            {
                LoadDataGridViews();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.SelectedRows.Count > 0)
            {
                var invoice = InvoiceController.PrintInvoice(int.Parse(dataGridViewInvoices.SelectedRows[0].Cells[0].Value.ToString()));
                MessageBox.Show(invoice);
            }
        }
    }
}
