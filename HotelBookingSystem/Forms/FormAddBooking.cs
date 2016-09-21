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
            dtpCheckIn.ValueChanged += Dates_ValueChanged;
            dtpCheckOut.ValueChanged += Dates_ValueChanged;
        }

        private void Dates_ValueChanged(object sender, EventArgs e)
        {
            SetDefaultCheckout();
            LoadData();
        }

        private void SetDefaultCheckout()
        {
            if (dtpCheckOut.Value.Date <= dtpCheckIn.Value.Date)
            {
                dtpCheckOut.Value = dtpCheckIn.Value.AddDays(1);
            }
        }

        public void LoadData()
        {
            dataGridViewGuests.DataSource = GuestController.GetAllGuestDetails();
            dataGridViewAvailableRooms.DataSource = RoomController.GetAvailableRooms(dtpCheckIn.Value, dtpCheckOut.Value);
        }

        private void btnBook_Click(object sender, EventArgs e)
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
    }
}
