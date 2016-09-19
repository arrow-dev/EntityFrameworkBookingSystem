using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingSystem.Data;

namespace HotelBookingSystem.Logic
{
    public static class InvoiceController
    {
        public static void NewInvoice(int guestId)
        {
            using (var context = new HotelMasterEntities())
            {
                context.Invoices.Add(new Invoice()
                {
                    GuestIDFK = guestId
                });
            }
        }
    }
}
