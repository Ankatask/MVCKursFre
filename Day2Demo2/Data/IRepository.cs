using Day2Demo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2Demo2.Data
{
    public interface IRepository
    {
        IEnumerable<Booking> GetBookings();
        Booking GetBookingById(int id);
        void RemoveBookingById(int Id);
    }
}