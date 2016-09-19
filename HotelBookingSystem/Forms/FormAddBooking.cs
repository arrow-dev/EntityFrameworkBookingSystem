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
            LoadData();
        }

        public void LoadData()
        {
            dataGridViewGuests.DataSource = GuestController.GetAllGuestDetails();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            dataGridViewAvailableRooms.DataSource = RoomController.GetAvailableRooms(dtpCheckIn.Value, dtpCheckOut.Value);
        }
    }
}
