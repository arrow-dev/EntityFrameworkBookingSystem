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
                    i.Guest.FirstName,
                    i.Guest.LastName,
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

        public static string PrintInvoice(int invoiceId)
        {
            string invoiceText = string.Empty;
            decimal invoiceTotal = 0.00m;

            using (var context = new HotelMasterEntities())
            {
                var bookings = context.Invoices.FirstOrDefault(i => i.InvoiceID == invoiceId).Bookings;

                foreach (var b in bookings)
                {
                    decimal bookingTotal = 0.00m;
                    invoiceText += "\nRoom: " + b.Room.Description;
                    invoiceText += "\nRoom Price: $" + Math.Round(b.Room.Price);
                    invoiceText += "\nBar Charge: $" + Math.Round(b.Bar);
                    invoiceText += "\nPhone Charge: $" + Math.Round(b.Phone);
                    if (b.Wifi)
                    {
                        invoiceText += "\nWIFI: $20";
                        bookingTotal += 20.00m;
                    }
                    if (b.ExtraBeds>0)
                    {
                        var extraBedCharge = b.ExtraBeds*30.00m;
                        invoiceText += "\nExtra beds: x" + b.ExtraBeds + "- $" + extraBedCharge;
                    }
                    bookingTotal += Math.Round(b.Room.Price) + Math.Round(b.Bar) + Math.Round(b.Phone);
                    invoiceTotal += bookingTotal;
                    invoiceText += "\nRoom Total: $" + bookingTotal;
                    invoiceText += "\n__________________________________\n";
                }
                invoiceText += "\n\nTotal: $" + invoiceTotal;
            }
            return invoiceText;
        }
    }
}
