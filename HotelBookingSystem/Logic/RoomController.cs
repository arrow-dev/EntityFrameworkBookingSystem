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

        public static Room GetRoomById(int id)
        {
            using (var context = new HotelMasterEntities())
            {
                return context.Rooms.FirstOrDefault(g => g.RoomID == id);
            }
        }

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

        public static void DeleteRoomById(int id)
        {
            using (var context = new HotelMasterEntities())
            {
                context.Rooms.Remove(GetRoomById(id));
            }
        }
    }
}
