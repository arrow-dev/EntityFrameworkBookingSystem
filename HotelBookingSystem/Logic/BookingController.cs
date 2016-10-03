using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Data;

namespace HotelBookingSystem.Logic
{
    public static class BookingController
    {

        //Create a new booking in the database
        public static void NewBooking(int invoiceId, int guestId, int roomId, DateTime checkIn, DateTime checkOut,
            int extraBeds)
        {
            using (var context = new HotelMasterEntities())
            {
                context.Bookings.Add(new Booking()
                {
                    InvoiceIDFK = invoiceId,
                    GuestIDFK = guestId,
                    RoomIDFK = roomId,
                    CheckInDate = checkIn,
                    CheckOutDate = checkOut,
                    ExtraBeds = extraBeds
                });
                context.SaveChanges();
            }
        }

        //Get a list of all bookings
        public static dynamic GetAllBookingDetails()
        {
            using (var context = new HotelMasterEntities())
            {
                return context.Bookings.Select(b => new
                {
                    b.BookingID,
                    b.Guest.FirstName,
                    b.Guest.LastName,
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

        //Get a list of current bookings
        public static dynamic GetCurrentBookingDetails()
        {
            using (var context = new HotelMasterEntities())
            {
                return  context.Bookings.Where(b => DateTime.Today >= b.CheckInDate && DateTime.Today <= b.CheckOutDate)
                        .Select(b => new
                        {
                            b.BookingID,
                            b.Guest.FirstName,
                            b.Guest.LastName,
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

        //Add bar charge to a booking
        public static void AddBarCharge(int bookingId, decimal ammount)
        {
            using (var context = new HotelMasterEntities())
            {
                var booking = context.Bookings.FirstOrDefault(b => b.BookingID == bookingId);
                if (booking != null)
                {
                    booking.Bar += ammount;
                }
                context.SaveChanges();
            }
        }

        //Add phone charge to a booking
        public static void AddPhoneCharge(int bookingId, decimal ammount)
        {
            using (var context = new HotelMasterEntities())
            {
                var booking = context.Bookings.FirstOrDefault(b => b.BookingID == bookingId);
                if (booking != null)
                {
                    booking.Phone += ammount;
                }
                context.SaveChanges();
            }
        }

        //Enable WIFI for a booking
        public static void AddWifiCharge(int bookingId)
        {
            using (var context = new HotelMasterEntities())
            {
                var booking = context.Bookings.FirstOrDefault(b => b.BookingID == bookingId);
                if (booking != null)
                {
                    booking.Wifi = true;
                }
                context.SaveChanges();
            }
        }

        //Delete a booking
        public static void DeleteBookingById(int id)
        {
            using (var context = new HotelMasterEntities())
            {
                var booking = context.Bookings.FirstOrDefault(b => b.BookingID == id);
                context.Bookings.Remove(booking);
                context.SaveChanges();
            }
        }

        //Get bookings by Guest name
        public static dynamic BookingsByName(string sequence)
        {
            using (var context = new HotelMasterEntities())
            {
                return context.Bookings.Where(b => (b.Guest.FirstName + " " + b.Guest.LastName).Contains(sequence))
                    .Select(b => new
                    {
                        b.BookingID,
                        b.Guest.FirstName,
                        b.Guest.LastName,
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
