using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleGraphQL.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public double Price { get; set; }
        public ReservationStatus Status { get; set; }
        public Guest Guest { get; set; }
        public Room Room { get; set; }
    }

    public enum ReservationStatus
    {
        Ordered,
        Paid,
        Completed
    }
}
