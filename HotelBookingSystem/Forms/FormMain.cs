using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            dataGridViewGuests.DataSource = GuestController.GetAllGuests();
            dataGridViewRooms.DataSource = RoomController.GetAllRooms();
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
    }
}
