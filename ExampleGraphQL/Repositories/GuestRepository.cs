using ExampleGraphQL.Contracts;
using ExampleGraphQL.Models;
using System;
using System.Collections.Generic;

namespace ExampleGraphQL.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        public List<Guest> Guests { get; set; }

        public GuestRepository()
        {
            Guests = new List<Guest>()
            {
                new Guest()
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Wick",
                    RegisterDate = DateTime.Now.AddDays(-10)
                },
                new Guest()
                {
                    Id = 2,
                    FirstName = "Jacob",
                    LastName = "Riverdale",
                    RegisterDate = DateTime.Now.AddDays(-4)
                },
                new Guest()
                {
                    Id = 3,
                    FirstName = "John",
                    LastName = "Smith",
                    RegisterDate = DateTime.Now.AddDays(-12)
                },
                new Guest()
                {
                    Id = 4,
                    FirstName = "John",
                    LastName = "Smith",
                    RegisterDate = DateTime.Now.AddDays(-14)
                },
                new Guest()
                {
                    Id = 5,
                    FirstName = "Patrick",
                    LastName = "Bravo",
                    RegisterDate = DateTime.Now.AddDays(-48)
                },
                new Guest()
                {
                    Id = 6,
                    FirstName = "Stephen",
                    LastName = "Meyer",
                    RegisterDate = DateTime.Now.AddDays(-20)
                },
                new Guest()
                {
                    Id = 7,
                    FirstName = "Spongebob",
                    LastName = "Squarepants",
                    RegisterDate = DateTime.Now.AddDays(-4)
                }
            };
        }

        public IEnumerable<Guest> GetGuests() => Guests;

        public Guest AddGuest(Guest guest)
        {
            Guests.Add(guest);
            return guest;
        }
    }
}
