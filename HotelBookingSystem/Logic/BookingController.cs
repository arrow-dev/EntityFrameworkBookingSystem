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
            }
        }
    }
}
