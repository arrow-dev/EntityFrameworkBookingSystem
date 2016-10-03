using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Logic;

namespace HotelBookingSystem.Forms
{
    public partial class FormAddBooking : Form
    {
        public FormAddBooking()
        {
            InitializeComponent();
            SetDefaultCheckout();
            LoadData();
            dtpCheckIn.CloseUp += Dates_ValueChanged;
            dtpCheckOut.CloseUp += Dates_ValueChanged;
        }

        //When dates are changed check that the checkin is at least the current date and doesnt exceed the check out date
        private void Dates_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckIn.Value < DateTime.Today )
            {
                dtpCheckIn.Value = DateTime.Today;
                MessageBox.Show("Check in date cannot be before today's date.");
            }
            if (dtpCheckIn.Value >= dtpCheckOut.Value)
            {
                dtpCheckOut.Value = dtpCheckIn.Value.AddDays(1);
                MessageBox.Show("Check out date cannot be before check in date.");
            }
            LoadData();
        }

        //Sets default check in to current date and check out to current date + 1 day
        private void SetDefaultCheckout()
        {
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now.AddDays(1);
        }

        //Load data into datagridviews
        public void LoadData()
        {
            dataGridViewGuests.DataSource = GuestController.GetAllGuestDetails();
            dataGridViewAvailableRooms.DataSource = RoomController.GetAvailableRooms(dtpCheckIn.Value, dtpCheckOut.Value);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewGuests.SelectedRows.Count>0 && dataGridViewAvailableRooms.SelectedRows.Count>0)
            {
                var guestId = int.Parse(dataGridViewGuests.SelectedRows[0].Cells[0].Value.ToString());
                var roomId = int.Parse(dataGridViewAvailableRooms.SelectedRows[0].Cells[0].Value.ToString());
                var checkIn = dtpCheckIn.Value.Date;
                var checkOut = dtpCheckOut.Value.Date;
                var extraBeds = int.Parse(numExtraBeds.Value.ToString());
                var invoiceId = InvoiceController.GetCurrentInvoiceId(guestId);
                //Check if there is a current invoice, if not create one.
                if (invoiceId == 0)
                {
                    InvoiceController.NewInvoice(guestId);
                    invoiceId = InvoiceController.GetCurrentInvoiceId(guestId);
                }
                //Create Booking
                BookingController.NewBooking(invoiceId, guestId, roomId, checkIn, checkOut, extraBeds);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You must select a guest and a room.");
            }
            
        }

        private void dataGridViewAvailableRooms_DataBindingComplete(object sender,
            DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewAvailableRooms.Columns[0].HeaderText = "Room ID";
            dataGridViewAvailableRooms.Columns[2].HeaderText = "Double Bed";
        }

        private void dataGridViewGuests_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewGuests.Columns[0].HeaderText = "Guest ID";
            dataGridViewGuests.Columns[1].HeaderText = "First Name";
            dataGridViewGuests.Columns[2].HeaderText = "Last Name";
        }
    }
}
