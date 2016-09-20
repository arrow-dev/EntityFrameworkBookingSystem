using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingSystem.Data;

namespace HotelBookingSystem.Logic
{
    public static class BookingController
    {
        public static void NewBooking(int invoiceId, int guestId, int roomId, DateTime checkIn, DateTime checkOut, int extraBeds)
        {
            using (var context = new HotelMasterEntities())
            {
                context.Bookings.Add(new Booking()
                {
                    InvoiceIDFK=invoiceId,
                    GuestIDFK=guestId,
                    RoomIDFK=roomId,
                    CheckInDate = checkIn,
                    CheckOutDate = checkOut,
                    ExtraBeds = extraBeds
                });
                context.SaveChanges();
            }
        }
        public static dynamic GetAllBookingDetails()
        {
            using (var context = new HotelMasterEntities())
            {
                return context.Bookings.Select(b => new
                {
                    b.BookingID,
                    b.GuestIDFK,
                    b.RoomIDFK,
                    b.CheckInDate,
                    b.CheckOutDate,
                    b.ExtraBeds,
                    b.Wifi,
                    b.Bar,
                    b.Phone
                }).ToList();
            }
        }
    }
}
