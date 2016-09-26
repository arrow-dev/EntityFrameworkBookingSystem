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
                    GuestIDFK = guestId,
                    DateCreated = DateTime.Today
                });
                context.SaveChanges();
            }
        }
        public static dynamic GetAllInvoiceDetails()
        {
            using (var context = new HotelMasterEntities())
            {
                return context.Invoices.Select(i => new
                {
                    i.InvoiceID,
                    i.GuestIDFK,
                    i.DateCreated,
                    i.DateCharged
                }).ToList();
            }
        }

        public static int GetCurrentInvoiceId(int guestId)
        {
            using (var context = new HotelMasterEntities())
            {
                var query = context.Invoices.Where(i => i.GuestIDFK == guestId && i.DateCharged == null).Select(i => i.InvoiceID).ToList();
                if (query.Count()>0)
                {
                    return query.First();
                }
                return 0;
            } 
        }
    }
}
