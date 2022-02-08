using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int BkgNumber)
        {
            return new ReservationDTO()
            {
                Id = 1,
                BkgDate = DateTime.Now,
                CheckingDate = DateTime.Now.AddDays(30),
                CheckoutDate = DateTime.Now.AddDays(37),
                Amount = 10000,
                BkgNumber = 1
            };
        }
    }
}
