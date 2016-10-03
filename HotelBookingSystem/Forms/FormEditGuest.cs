using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Data;
using HotelBookingSystem.Logic;

namespace HotelBookingSystem
{
    public partial class FormEditGuest : Form
    {
        private int Id;

        public FormEditGuest(int id)
        {
            Id = id;
            var selectedGuest = GuestController.GetGuestById(Id);
            InitializeComponent();
            txtFirstName.Text = selectedGuest.FirstName;
            txtLastName.Text = selectedGuest.LastName;
            txtEmail.Text = selectedGuest.Email;
            txtAddress.Text = selectedGuest.Address;
            txtPhone.Text = selectedGuest.Phone;
        }

        //Edits a guest in the database
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length > 0 &&
                txtLastName.Text.Length > 0 &&
                txtAddress.Text.Length > 0 &&
                txtEmail.Text.Length > 0 &&
                txtPhone.Text.Length > 0)
            {
                GuestController.EditGuest(Id, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                DialogResult = DialogResult.OK;
            }
            
        }
    }
}
