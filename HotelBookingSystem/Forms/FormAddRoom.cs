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
    public partial class FormAddRoom : Form
    {
        public FormAddRoom()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Length > 0 &&  numPrice.Value > 0)
            {
                RoomController.NewRoom(txtDescription.Text, cbDouble.Checked, numPrice.Value);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
