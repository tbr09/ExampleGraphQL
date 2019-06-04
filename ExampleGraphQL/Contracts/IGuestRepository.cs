using ExampleGraphQL.Models;
using System.Collections.Generic;

namespace ExampleGraphQL.Contracts
{
    public interface IGuestRepository
    {
        IEnumerable<Guest> GetGuests();
        Guest AddGuest(Guest guest);
    }
}
