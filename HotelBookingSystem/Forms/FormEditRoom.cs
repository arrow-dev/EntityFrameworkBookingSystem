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
    public partial class FormEditRoom : Form
    {
        private int Id;

        public FormEditRoom(int id)
        {
            Id = id;
            var selectedRoom = RoomController.GetRoomById(Id);
            InitializeComponent();
            txtDescription.Text = selectedRoom.Description;
            cbDouble.Checked = selectedRoom.DoubleBed;
            numPrice.Value = selectedRoom.Price;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Length  > 0 && numPrice.Value > 0)
            {
                RoomController.EditRoom(Id, txtDescription.Text, cbDouble.Checked, numPrice.Value);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
