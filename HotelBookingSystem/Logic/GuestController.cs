using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingSystem.Data;

namespace HotelBookingSystem.Logic
{
    public static class GuestController
    {
        //Add new guest to database
        public static void NewGuest(string firstName, string lastName, string email, string address, string phone)
        {
            using (var context = new HotelMasterEntities())
            {
                context.Guests.Add(new Guest()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Address = address,
                    Phone = phone
                });
                context.SaveChanges();
            }
        }

        //Edit guest
        public static void EditGuest(int id, string firstName, string lastName, string email, string address, string phone)
        {
            using (var context = new HotelMasterEntities())
            {
                var selectedGuest = context.Guests.FirstOrDefault(g => g.GuestID == id);
                if (selectedGuest != null)
                {
                    selectedGuest.FirstName = firstName;
                    selectedGuest.LastName = lastName;
                    selectedGuest.Email = email;
                    selectedGuest.Address = address;
                    selectedGuest.Phone = phone;
                    context.SaveChanges();
                }
            }
        }

        //Get guest details by id
        public static Guest GetGuestById(int id)
        {
            using (var context = new HotelMasterEntities())
            {
                return context.Guests.FirstOrDefault(g => g.GuestID == id);
            }
        }

        //Get all guests
        public static dynamic GetAllGuestDetails()
        {
            using (var context = new HotelMasterEntities())
            {
                return context.Guests.Select(g => new
                {
                    g.GuestID,
                    g.FirstName,
                    g.LastName,
                    g.Email,
                    g.Address,
                    g.Phone
                }).ToList();
            }
        }

        //Delete a guest
        public static void DeleteGuestById(int id)
        {
            using (var context = new HotelMasterEntities())
            {
                var guest = context.Guests.FirstOrDefault(g => g.GuestID == id);
                context.Guests.Remove(guest);
                context.SaveChanges();
            }
        }

        //Get guest by name
        public static dynamic GuestsByName(string sequence)
        {
            using (var context = new HotelMasterEntities())
            {
                return context.Guests.Where(g => (g.FirstName + " " + g.LastName).Contains(sequence))
                    .Select(g => new
                    {
                        g.GuestID,
                        g.FirstName,
                        g.LastName,
                        g.Email,
                        g.Address,
                        g.Phone
                    }).ToList();
            }
        }
    }
}
