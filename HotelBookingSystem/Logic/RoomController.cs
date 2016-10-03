using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingSystem.Data;

namespace HotelBookingSystem.Logic
{
    public static class RoomController
    {
        //Add new room to database
        public static void NewRoom(string description, bool doubleBed, decimal price)
        {
            using (var context = new HotelMasterEntities())
            {
                context.Rooms.Add(new Room()
                {
                    Description = description,
                    DoubleBed = doubleBed,
                    Price = price
                });
                context.SaveChanges();
            }
        }

        //Edit a room and save to database
        public static void EditRoom(int id, string description, bool doubleBed, decimal price)
        {
            using (var context = new HotelMasterEntities())
            {
                var selectedRoom = context.Rooms.FirstOrDefault(g => g.RoomID == id);
                if (selectedRoom != null)
                {
                    selectedRoom.Description = description;
                    selectedRoom.DoubleBed = doubleBed;
                    selectedRoom.Price = price;
                    context.SaveChanges();
                }
            }
        }

        //Get room by id
        public static Room GetRoomById(int id)
        {
            using (var context = new HotelMasterEntities())
            {
                return context.Rooms.FirstOrDefault(g => g.RoomID == id);
            }
        }

        //Get all rooms
        public static dynamic GetAllRoomDetails()
        {
            using (var context = new HotelMasterEntities())
            {
                return context.Rooms.Select(r => new
                {
                    r.RoomID,
                    r.Description,
                    r.DoubleBed,
                    Price = "$" + Math.Round(r.Price, 2)
                }).ToList();
            }
        }

        //Delete a room from the database
        public static void DeleteRoomById(int id)
        {
            using (var context = new HotelMasterEntities())
            {
                var room = context.Rooms.FirstOrDefault(r => r.RoomID == id);
                context.Rooms.Remove(room);
                context.SaveChanges();
            }
        }

        //Get available rooms for a date range
        public static dynamic GetAvailableRooms(DateTime checkIn, DateTime checkOut)
        {
            using (var context = new HotelMasterEntities())
            {
                var bookedRooms = context.Bookings.Where(b => (b.CheckInDate >= checkIn.Date && b.CheckInDate < checkOut.Date) || (b.CheckOutDate > checkIn.Date && b.CheckOutDate <= checkOut.Date)).Select(b => b.RoomIDFK);
                var availableRooms = context.Rooms.Where(r => !bookedRooms.Contains(r.RoomID)).Select(r => new
                {
                    r.RoomID,
                    r.Description,
                    r.DoubleBed,
                    r.Price
                }).ToList();
                return availableRooms;
            }
        }
    }
}
