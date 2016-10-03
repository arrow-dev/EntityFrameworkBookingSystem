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
using HotelBookingSystem.Logic;

namespace HotelBookingSystem
{
    public partial class FormAddGuest : Form
    {
        public FormAddGuest()
        {
            InitializeComponent();
        }

        //Save a new guest to the database
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length > 0 &&
                txtLastName.Text.Length >0 &&
                txtAddress.Text.Length > 0 &&
                txtEmail.Text.Length > 0 &&
                txtPhone.Text.Length > 0)
            {
                GuestController.NewGuest(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
